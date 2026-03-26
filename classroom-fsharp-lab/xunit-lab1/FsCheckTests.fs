module FsCheckTests

open System
open Xunit
open FsUnit.Xunit
open FsCheck
open FsCheck.Xunit
open Math

[<Property>]
let ``addition is commutative`` (a:int) (b:int) =
    a + b = b + a

[<Property>]
let ``adding zero does nothing`` (a:int) =
    a + 0 = a

[<Property>]
let ``add behaves like +`` (a:int) (b:int) =
    add a b = a + b

[<Property>]
let ``badAdd should behave like +`` (a:int) (b:int) =
    badAdd a b = a + b

[<Property>]
let ``conversion is reversible`` (knots: float) =
    let kmh = knotsToKmh knots
    let back = kmh / 1.852
    abs (knots - back) < 0.0001