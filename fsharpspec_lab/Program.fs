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

    0 // return an integer exit code