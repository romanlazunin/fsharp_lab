let cardNo = 12

let cardDescription = 
   if cardNo = 1 || cardNo = 14 then "Ace"
   elif cardNo = 11 then "Jack"
   elif cardNo = 12 then "Queen"
   elif cardNo = 13 then "King"
   else string cardNo
printfn "%s" cardDescription

let list = [1; 2; 3; 4; 5]
for i in list do
   printf "%d " i

printfn ""
for i = 1 to 10 do
  printf "%i " i  // prints 1 2 3 4 5 6 7 8 9 10

printfn ""
for i = 10 downto 1 do
  printf "%i " i  // prints 10 9 8 7 6 5 4 3 2 1