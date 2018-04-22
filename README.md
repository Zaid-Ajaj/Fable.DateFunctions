# Fable.DateFunctions 

Fable binding for [date-fns](https://date-fns.org/), this binding implements the imports as 120+ extension methods for `DateTime` instances (and a couple of static members for `DateTime`). 32 Languages are supported for formatting dates.

## Installation 
Install the binding from Nuget
```
paket add Fable.DateFunctions --project path/to/Proj.fsproj 
```
Install the actual Javascript library from npm
```
npm install --save date-fns
```
Now from your F# code
```fs
open Fable.DateFunctions 

let now = DateTime.Now
now.SubtractDays(-1).IsInThePast() // true
```

## Todo (PRs are welcome)
 - Quarter helpers
 - ISO Week-Numbering Year Helpers
 - More docs
 - Testing

## Build and running the app

1. Start Fable server and Webpack dev server: `./build.sh Watch`
2. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after 
saving.


