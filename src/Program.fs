// Learn more about F# at http://fsharp.org

open System
open Parse

[<EntryPoint>]
let main argv =
    fromString argv.[0]
    // printfn "Hello World from F#! %A" argv.[0]
    0 // return an integer exit code
