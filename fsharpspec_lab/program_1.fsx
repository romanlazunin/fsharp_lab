let numbers = [ 1 .. 10 ]
let square x = x * x
let squares = List.map square numbers
printfn "N^2 = %A" squares