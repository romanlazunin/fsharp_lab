open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message

    let numbers = [ 1 .. 10 ]
    let square x = x * x
    let squares = List.map square numbers
    printfn "N^2 = %A" squares

    let name = "Chris"

    let mutable name = "Tobias"
    name <- "Luis" // this statement is now allowed

    let goodWeatherToday = true
    let badWeatherToday = false

    let currentYear = 2026
    let greeting = "Hej"
    let oneAndAHalf = 1.5
    let twoAndAHalf:float = 2.5
    printfn "Greeting: %s" greeting

    Console.WriteLine("Console.WriteLine output")

    let name = "Luis"
    let company = "Microsoft"
    printfn $"Name: {name}, Company: {company}"

    let firstNumber = 2000
    let secondNumber = 26
    printfn $"The year is: {firstNumber + secondNumber}"

    printfn "Current year: %i" (firstNumber + secondNumber)
    printfn "The weather is good today: %b" goodWeatherToday

    0 // return an integer exit code