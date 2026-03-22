open System

let mutable quit = false
let no = 11
while not quit do
   printf "Guess a number: "
   let guess = Console.ReadLine() 
   let guessNo = int guess
   if guessNo = no then
      quit <- true
      printfn "You guessed correctly %i is the secret number" no
   else
      printfn "%i is incorrect" guessNo