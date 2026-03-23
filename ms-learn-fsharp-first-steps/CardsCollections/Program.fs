let cards = [ 0 .. 5 ]
let hand = []

let drawCard (tuple: int list * int list) = 
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard

    let hand = 
        draw
        |> List.append [firstCard]

    (deck.Tail, hand)

let d, h = (cards, hand) |> drawCard |> drawCard

printfn "Deck: %A Hand: %A" d h // Deck: [2; 3; 4; 5] Hand: [1; 0]

let cards2 = [ 1 .. 5 ]
List.iter(fun i -> printf "%i " i) cards2 // 1 2 3 4 5

printfn ""
for i in cards do printf "%i " i

type Person = { FirstName: string; LastName: string  }
let people = [
   { FirstName="Albert"; LastName= "Einstein" }
   { FirstName="Marie"; LastName="Curie" }
]
let nobelPrizeWinners = List.map (fun person -> person.FirstName + person.LastName) people 
printfn "%A" nobelPrizeWinners // ["Albert Einstein"; "Marie Curie"]

let filteredList = List.filter(fun i-> i % 2 = 0) cards2
List.iter(fun i -> printfn "item %i" i) filteredList // item 2 item 4

let list = [2; 1; 5; 3]
let sortedList = List.sort list // 1 2 3 5

let fruits = ["Banana"; "Apple"; "Pineapple"]
let sortedFruits = List.sortBy (fun (fruit : string) -> fruit.Length) fruits // Apple, Banana, Pineapple

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

let list2 = [1; 2; 3; 4]
let found = List.find( fun x -> x % 2 = 0) list2 // 2 - Only the first element that matches the condition is returned.
