#r "packages/build/FAKE/tools/FakeLib.dll"

open System
open Fake

let run fileName args workingDir =
    printfn "CWD: %s" workingDir
    let fileName, args =
        if EnvironmentHelper.isUnix
        then fileName, args else "cmd", ("/C " + fileName + " " + args)
    let ok = execProcess (fun info ->
            info.FileName <- fileName
            info.WorkingDirectory <- workingDir
            info.Arguments <- args) TimeSpan.MaxValue
    if not ok then failwith (sprintf "'%s> %s %s' task failed" workingDir fileName args)

let dotnet = "dotnet"
let npm = "npm"
let projects =  [ "src"; "app" ]

Target "Clean" <| fun _ ->
    projects 
    |> List.collect (fun proj -> [ proj </> "bin"; proj </> "obj" ])
    |> List.iter CleanDir

    [ "public" </> "bundle.js"
      "public" </> "bundle.js.map" ]
    |> List.iter DeleteFile

Target "DotnetRestore" <| fun _ ->
    projects
    |> List.iter (run dotnet "restore --no-cache")

let publish projectPath = fun () ->
    run dotnet "pack -c Release" projectPath
    let nugetKey =
        match environVarOrNone "NUGET_KEY" with
        | Some nugetKey -> nugetKey
        | None -> failwith "The Nuget API key must be set in a NUGET_KEY environmental variable"
    let nupkg = System.IO.Directory.GetFiles(projectPath </> "bin" </> "Release") |> Seq.head
    let pushCmd = sprintf "nuget push %s -s nuget.org -k %s" nupkg nugetKey
    run dotnet pushCmd projectPath

Target "PublishNuget" (publish "src")

Target "NpmInstall" <| fun _ ->
    run npm "install" "."

Target "Watch" <| fun () ->
  run dotnet "fable npm-run start" "app"

"Clean" 
  ==> "DotnetRestore"
  ==> "NpmInstall"
  ==> "Watch"  

"Clean" 
  ==> "DotnetRestore"
  ==> "PublishNuget"

RunTargetOrDefault "Clean"