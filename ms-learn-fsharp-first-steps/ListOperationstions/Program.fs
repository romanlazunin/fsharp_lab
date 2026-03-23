let cards = [ 1 .. 5 ]
List.iter(fun i -> printf "%i " i) cards // 1 2 3 4 5

printfn ""
for i in cards do printf "%i " i

type Person = { FirstName: string; LastName: string  }
let people = [
   { FirstName="Albert"; LastName= "Einstein" }
   { FirstName="Marie"; LastName="Curie" }
]
let nobelPrizeWinners = List.map (fun person -> person.FirstName + " " + person.LastName) people 

printfn ""
printfn "%A" nobelPrizeWinners // ["Albert Einstein"; "Marie Curie"]

let filteredList = List.filter(fun i-> i % 2 = 0) cards
List.iter(fun i -> printfn "item %i" i) filteredList // item 2 item 4

// Sorting
let list = [2; 1; 5; 3]
let sortedList = List.sort list // 1 2 3 5
List.iter(fun i -> printf "%i " i) sortedList

let fruits = ["Banana"; "Apple"; "Pineapple"]
let sortedFruits = List.sortBy (fun (fruit : string) -> fruit.Length) fruits // Apple, Banana, Pineapple
printfn ""
List.iter(fun fruit -> printfn "%s" fruit) sortedFruits