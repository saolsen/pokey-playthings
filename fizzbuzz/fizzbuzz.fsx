module fizzbuzz.Main

open System

// Fizzbuzz as an active pattern
let (|FizzBuzz|Fizz|Buzz|Number|) (n: int) =
  let fizz = n % 3 = 0
  let buzz = n % 5 = 0

  if fizz && buzz then FizzBuzz
  elif fizz then Fizz
  elif buzz then Buzz
  else Numbe

let fizzBuzz n =
  match n with
    | FizzBuzz -> "fizzbuzz"
    | Fizz -> "fizz"
    | Buzz -> "buzz"
    | Number -> n.ToString()

[<EntryPoint>]
let main args =
  [1 .. 100] |> Seq.map fizzBuzz |> Seq.iter (printfn "%s")
  0
