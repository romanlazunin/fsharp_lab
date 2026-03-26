open System
open System.Net.Http

let readAoCInput (url: string) (sessionCookie: string) =
    async {
        use client = new HttpClient()
        client.DefaultRequestHeaders.Add("Cookie", $"session={sessionCookie}")
        let! response = client.GetStringAsync(url) |> Async.AwaitTask
        return response
    }

let session = Environment.GetEnvironmentVariable("AOC_SESSION")

let input = readAoCInput "https://adventofcode.com/2015/day/1/input" session
            |> Async.RunSynchronously

// printfn "%s" input

let mutable position = 1
let mutable sum_position = 0
let mutable sum = 0
for character in input do
    if character = '(' then sum <- sum + 1 
    else sum <- sum - 1

    if sum = -1 && sum_position = 0 then 
        sum_position <- position

    position <- position + 1

printfn "%d" sum_position
