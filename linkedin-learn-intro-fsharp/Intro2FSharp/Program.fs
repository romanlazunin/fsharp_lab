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
    // Pipelines & composition
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

    let countVowels (word:string) =
        let mutable count = 0
        for character in word do
            match character with
            |'A'|'E'|'I'|'O'|'U' -> count <- count + 1
            | _ -> ()
        printfn $"Vowel count: {count}"
        word

    let processWords = getRandom >> countVowels >> encrypt

    // Control flow
    let votingAge = 18
    let getInput() = 
        printfn "How old are you?"
        let input = Console.ReadLine()
        try
            let age = int input
            Some age
        with 
        | ex ->
            printfn $"{ex.Message}"
            None

    // if age >= votingAge then
    //     printfn "You're all set to vote!"

    let validateVoter age min = 
        if age = min then "just old enough"
        elif age > min then "more than old enough"
        else "too young"

    let countLetters (word:string) = 
        if word.Length = 0 then
            None
        else
            let mutable count = 0
            for i in word do
                count <- count + 1
            Some count

    let checkOption result = 
        match result with
        | Some value -> value
        | None -> 0

    let termLimits() = 
        for i = 1 to 4 do
            printfn $"The president is in year {i}..."

    let vacationCountdown() =
        let mutable inOffice = true
        while inOffice do 
            for i = 4 downto 1 do
                printfn $"The president has {i} years to go!"
            printfn $"The president is on permanent vacation!"
            inOffice <- false

module DataGroups =
    // Tuples
    let origin = (0, 0)
    let fullname = ("Harrison", "Ferrone")

    // Multi-value tuples
    let userData = ("Harrison", 33, true)

    // Decomposing tuples
    let decompose tuple =
        // let x = fst tuple
        // let y = snd tuple
        let x, y = tuple
        printfn $"x: {x}, y: {y}"

    let decomposeBigTuple tuple =
        // let fst, snd, thr = tuple
        let fst, snd, _ = tuple
        // printfn $"1st: {fst}, 2nd: {snd}, 3rd: {thr}" 
        printfn $"1st: {fst}, 2nd: {snd}" 

    // Records
    type Author =
        {
            FirstName: string
            LastName: string
            Age: int
        }
        // Record members
        member this.Debug() = printfn $"\n{this.FirstName} {this.LastName} is {this.Age}"
        member _.GetGreeting() = printfn $"Happy coding!"

    type Status =
        | Active of author: Author
        | Sabattical of string
        | Retired of int

    let getStatus (status: Status) =
        match status with
        | Active (author = auth) -> printf $"Status: Active - {auth.GetGreeting()}"
        | Sabattical location -> printfn $"Status: On Sabattical in {location}"
        | Retired year-> printfn $"Status: Retired since {year}"

    type Client = Client of id: int

    let unwrapClient (Client id) =
        // let (Client id) = client
        printfn $"Client ID: {id}"


module Run =
    open GettingStarted
    open PipelineEtc
    open DataGroups

    Sabattical "Valencia, Spain"
    |> getStatus

    Client 007
    |> unwrapClient


    // Records
    // let myProfile = { FirstName = "Harrison"; LastName = "Ferrone"; Age = 33}
    // let updatedProfile = { myProfile with Age = 34}
    // // printfn $"\n{myProfile.FirstName} {myProfile.LastName} is {myProfile.Age}"
    // // printfn $"\n{updatedProfile.FirstName} {updatedProfile.LastName} is {updatedProfile.Age}"
    // myProfile.Debug()
    // updatedProfile.Debug()
    // updatedProfile.GetGreeting()

    // Tuples
    // decompose origin
    // decomposeBigTuple userData


    // Pipelines
    // let word = getRandom words
    // printfn $"{word}"

    // words
    // |> getRandom
    // |> encrypt

    // words |> processWords

    // Control flow
    // let result = validateVoter age votingAge
    // printfn $"You're {result} to vote."

    // let characterCount = countLetters result
    // printfn $"The string has {characterCount} characters."
    
    // getInput()
    // |> checkOption
    // |> fun age -> validateVoter age votingAge
    // |> fun result -> printfn $"You're {result} to vote."

    // // countLetters "Hello World"
    // countLetters ""
    // |> checkOption
    // |> fun result -> printfn $"The string has {result} characters."

    // termLimits()
    // vacationCountdown()


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