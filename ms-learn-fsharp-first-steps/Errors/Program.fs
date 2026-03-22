open System

[<EntryPoint>]
let main argv =
    let aNumber = 0
    printfn "Here's a number %i" aNumber

    Console.Write "Type a value:"
    let str = Console.ReadLine()
    printfn "You typed %s" str

    let first = "32"
    let numberVersion = System.Int32.Parse first 
    printfn "Number %i" numberVersion // Output: Number 32

    let second = "34"
    let secondNumberVersion =  int second
    printfn "Number %i" secondNumberVersion

    let no = 10
    let isDivisibleByTwo = no % 2 = 0
    printfn "Divisible by two %b" isDivisibleByTwo

    0 // return an integer exit code