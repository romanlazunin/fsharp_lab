open System

module CustomFunctions =
    // Functions & expressions
    let increaseByOne x = x + 1
    let areBothTrue x y = x && y
    let addValues (x: string) (y: string) : string = x + y
    let increment = increaseByOne
    let applyAndDouble (fn:int -> int) (x:int) = fn x * 2
    let rec fib n = if n < 2 then 1 else fib(n - 1) + fib(n - 2)

module GettingStarted = 
    open CustomFunctions
    // Binding values
    let welcome: string = "Welcome to "

    // Mutability
    let mutable courseTitle = "Intro 2 FSharp!"
    courseTitle <- "Intro 2 FSharp!"

    // Operations
    let message = addValues welcome courseTitle

    // Immutability
    let capMessage = message.ToUpper()

    let energyLevel: int = 10
    // let turnItToEleven = increment energyLevel
    let turnItToEleven = applyAndDouble increaseByOne 10

    // Booleans
    let awake: bool = true
    let readyToGo = turnItToEleven >= 11
    // let start = areBothTrue awake readyToGo
    let startPartial = areBothTrue awake
    let start = startPartial readyToGo
    let stop = startPartial false

    // Console input
    let getUsername() : string = 
        printfn "Enter your name:"
        Console.ReadLine()

    // Printing  to console
    let printWelcome() =
        printfn $"\n{message}"

    let debug (name:string) =
        printfn $"\nEnergy level is at {energyLevel} but I need it to go to {turnItToEleven}"
        printfn $"Are you ready {name}? {start}"

module PipelineEtc =
    let words = ["Hello"; "World"; "FSharp"]
    let getRandom(pool:list<string>) = 
        let random = Random()
        pool 
        |> List.map (fun x -> x.ToLower())
        |> List.item(random.Next(pool.Length))
        |> fun x -> x.ToUpper()

    let encrypt word = 
        let encryptedWord = word |> String.map (fun x -> '*')
        printfn $"Encrypted word {word} as {encryptedWord}"

module Run =
    open GettingStarted
    open PipelineEtc

    // Pipelines
    // let word = getRandom words
    // printfn $"{word}"

    words
    |> getRandom
    |> encrypt

    // Getting started
    // let name = getUsername()
    // printWelcome()
    // debug name

    Console.ReadKey() |> ignore

(*/// Explicit entry point
[<EntryPoint>]
let main args = 
    printfn "Arguments passed to function: %A" args
    0 // return 0 to indicate success
*)