let logEntryMonday = "first entry"
let logEntryTuesDay = "second entry"
let logEntryWednesday = "third entry"

let logEntriesWeek = ["first entry"; "second entry"; "third entry"]

let cards2 = [
  "Ace"
  "King"
  "Queen"
]

let numbers = [ 1 .. 5 ]

let cards = ["Ace"; "King"; "Queen"]

let newList = "Jack" :: cards // "Jack", "Ace", "King", "Queen" 
let otherCardList = ["Jack"; "10"]
let fullList = cards @ otherCardList // "Ace", "King", "Queen", "Jack", "10"

let otherCardList2 = ["10"; "9"]
let fullList2 = cards |> List.append ["Jack"] // "Jack", "Ace", "King", "Queen"
let fullList3 = cards |> List.append otherCardList2 // "10", "9", "Ace", "King", "Queen"

let list = [1; 2; 3; 4]
let itemOne = list.Item 1 // 2