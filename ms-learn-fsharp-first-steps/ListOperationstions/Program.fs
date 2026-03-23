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

// assume a type like so
type MagicCreature = { Name : string; Level: int; Attack: int }
let creatures = [
   { Name="Dragon"; Level=2; Attack=20 }
   { Name="Orc"; Level=1; Attack=5 }
   { Name="Demon"; Level=2; Attack=10 } 
]

// comparison function, -1 = less than, 1 = larger than, 0 = equal
let compareCreatures c1 c2 =
     if c1.Level < c2.Level then -1
     else if c1.Level > c2.Level then 1
     else if c1.Attack < c2.Attack then -1
     else if c1.Attack > c2.Attack then 1
     else 0

let sorted = List.sortWith compareCreatures creatures // { Name="Orc"; Level=1; Attack=5 }, { Name="Demon"; Level=2; Attack=10 }, { Name="Dragon"; Level=2; Attack=20 }
List.iter(fun item -> printfn "%s" item.Name) sorted

let listA = [1; 2; 3; 4]
let found = List.find( fun x -> x % 2 = 0) listA // 2 - Only the first element that matches the condition is returned.
printfn $"{found}"

List.find( fun x -> x % 2 = 0) listA |> printfn "%i"

let findValue aValue aList =
     let found = aList |> List.tryFind(fun item -> item = aValue)

     match found with
     | Some value -> printfn "%i" value
     | None -> printfn "Not found"

findValue 1 list // 1
findValue 5 list // Not found

let foundA = List.tryFindIndex(fun x -> x = 4) list
match foundA with
   | Some index -> printfn "%i" index
   | None -> printfn "Not found"

let sum = List.sum [1 .. 5] // sum = 15   
List.sum [0 .. 5] |> printf "%i"

type OrderItem = { Name: string; Cost:int }

let orderItems = [
       { Name="XBox"; Cost=500 }
       { Name="Book"; Cost=10 }
       { Name="Movie ticket"; Cost=7 }
     ]

let sumA = List.sumBy(fun item -> item.Cost) orderItems
printfn "%i" sumA // 517

orderItems |> List.sumBy(fun item -> item.Cost) |> printf "%i"

let numbers = [ 1.0; 2.5; 3.0 ]
let avg = List.average numbers
printfn "%f" avg // 2.166667

type WeatherMeasurement = { Date: string; Temperature: float }
let measurements = [
    { Date="07/20/2021"; Temperature=21.3 }
    { Date="07/21/2021"; Temperature=23.2 }
    { Date="07/22/2021"; Temperature=20.7 }
]

let avgBy = List.averageBy(fun m -> m.Temperature) measurements
printfn "%f" avgBy // 21.733333