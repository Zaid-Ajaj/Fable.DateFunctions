#r "paket: groupref Build //"
#load ".fake/build.fsx/intellisense.fsx"

open System
open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.Core.TargetOperators

module Tools =
    let private findTool tool winTool =
        let tool = if Environment.isUnix then tool else winTool
        match ProcessUtils.tryFindFileOnPath tool with
        | Some t -> t
        | _ ->
            let errorMsg =
                tool + " was not found in path. " +
                "Please install it and make sure it's available from your path. "
            failwith errorMsg

    let private runTool (cmd:string) args workingDir =
        let arguments = args |> String.split ' ' |> Arguments.OfArgs
        Command.RawCommand (cmd, arguments)
        |> CreateProcess.fromCommand
        |> CreateProcess.withWorkingDirectory workingDir
        |> CreateProcess.ensureExitCode
        |> Proc.run
        |> ignore

    let dotnet cmd workingDir =
        let result =
            DotNet.exec (DotNet.Options.withWorkingDirectory workingDir) cmd ""
        if result.ExitCode <> 0 then failwithf "'dotnet %s' failed in %s" cmd workingDir

    let femto args = args |> sprintf "femto %s" |> dotnet
    let node = runTool (findTool "node" "node.exe")
    let yarn = runTool (findTool "yarn" "yarn.cmd")

let libraryPath = "src"
let appPath = "app"
let projects =  [ libraryPath; appPath ]
let appBuildPath = ".fable-build"

Target.create "Clean" <| fun _ ->
    projects 
    |> List.collect (fun proj -> [ proj </> "bin"; proj </> "obj" ])
    |> Shell.cleanDirs 

    [ "public" </> "bundle.js"
      "public" </> "bundle.js.map" ]
    |> List.iter File.delete

Target.create "DotnetRestore" <| fun _ ->
    projects
    |> List.iter (Tools.dotnet "restore --no-cache")

let publish proj =
    Tools.dotnet "restore --no-cache" proj
    Tools.dotnet "pack -c Release" proj
    let nugetKey =
        match Environment.environVarOrNone "NUGET_KEY" with
        | Some nugetKey -> nugetKey
        | None -> failwith "The Nuget API key must be set in a NUGET_KEY environmental variable"
    let nupkg =
        Directory.GetFiles(proj </> "bin" </> "Release")
        |> Seq.head
        |> Path.GetFullPath
    Tools.dotnet (sprintf "nuget push %s -s nuget.org -k %s" nupkg nugetKey) proj

Target.create "PublishNuget" (fun _ -> publish libraryPath)

Target.create "YarnInstall" <| fun _ ->
    Tools.yarn "install" "."

Target.create "Watch" <| fun _ ->
    Tools.dotnet (sprintf "fable watch --outDir %s --run webpack-dev-server" appBuildPath) appPath

Target.create "Build" <| fun _ -> 
    Tools.yarn "run build" "."

"Clean" 
  ==> "DotnetRestore"
  ==> "YarnInstall"
  ==> "Watch"  

"Clean"
  ==> "DotnetRestore"
  ==> "YarnInstall"
  ==> "Build"

"Clean" 
  ==> "DotnetRestore"
  ==> "PublishNuget"

Target.runOrDefaultWithArguments "Build"