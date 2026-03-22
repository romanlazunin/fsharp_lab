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

    let age = 66
    if age > 65 
    then printfn "Senior citizen"
    else printfn "Citizen"

    let agePersonA = 64
    let message = if agePersonA > 65 then "Senior citizen" else "Citizen"
    printfn "%s" message

    let agePersonB = 66
    if agePersonB > 65 then printfn "Person B: Senior citizen" else printfn "Person B: Citizen"

    let cardValue = 1
    let cardDescription = if cardValue = 1 then "Ace" elif cardValue = 14 then "Ace" else "A card"
    printfn "%s" cardDescription

    0 // return an integer exit code