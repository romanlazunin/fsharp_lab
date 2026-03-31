// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"

// Binding values
let welcome: string = "Welcome to "

// Mutability
let mutable courseTitle = "Intro 2 FSharp!"
courseTitle <- "Intro 2 FSharp!"


// Operations
let message = welcome + courseTitle

// Immutability
let capMessage = message.ToUpper()

let energyLevel: int = 10
let turnItToEleven = energyLevel + 1

// Booleans
let awake: bool = true
let readyToGo = turnItToEleven >= 11
let start = awake && readyToGo

// Printing  to console
printfn "%s" message
printfn $"{message}"
printfn $"\nEnergy level is at {energyLevel} but I need it to go to {turnItToEleven}"
printfn $"Are you ready? {start}"

(*/// Explicit entry point
[<EntryPoint>]
let main args = 
    printfn "Arguments passed to function: %A" args
    0 // return 0 to indicate success
*)