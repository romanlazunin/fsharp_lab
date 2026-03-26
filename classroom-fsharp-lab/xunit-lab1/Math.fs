module Math

let add a b = a + b

let divide a b =
    if b = 0 then failwith "division by zero"
    else a / b

let tryDivide a b =
    if b = 0 then None
    else Some (a / b)