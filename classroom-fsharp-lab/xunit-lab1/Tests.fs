module Tests

open System
open Xunit
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