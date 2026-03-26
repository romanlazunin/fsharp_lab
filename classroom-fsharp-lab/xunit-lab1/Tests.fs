module Tests

open System
open Xunit
open FsUnit.Xunit
open Math

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let ``1 + 1 = 2`` () =
    Assert.Equal(2, 1 + 1)

[<Fact>]
let ``basic arithmetic works`` () =
    Assert.Equal(4, 2 + 2)
    Assert.Equal(0, 2 - 2)
    Assert.True(3 > 1)

[<Fact>]
let ``add 2 3 = 5`` () =
    Assert.Equal(5, add 2 3)

[<Fact>]
let ``use actual and expected`` () =
    let expected = 4
    let actual = 2 + 2
    Assert.Equal(expected, actual)

[<Theory>]
[<InlineData(1, 2, 3)>]
[<InlineData(2, 3, 5)>]
[<InlineData(10, 5, 15)>]
let ``add works for many values`` a b expected =
    Assert.Equal(expected, add a b)

[<Fact>]
let ``divide by zero throws`` () =
    Assert.Throws<System.Exception>(fun () -> divide 1 0 |> ignore)

[<Fact>]
let ``tryDivide handles zero`` () =
    match tryDivide 10 0 with
    | None -> Assert.True(true)
    | Some _ -> Assert.True(false)

[<Fact>]
let ``nice style`` () =
    let result = 2 + 2
    result |> should equal 4