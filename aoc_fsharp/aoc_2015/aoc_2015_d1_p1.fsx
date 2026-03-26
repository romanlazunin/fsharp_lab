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

printfn "%s" input

