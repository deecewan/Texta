module TextaTest.Library

open NUnit.Framework
open FsUnit

type InitMsgUtils() =
    inherit FSharpCustomMessageFormatter()

[<Test>]
let ``the methods output the correct colors`` () =
    Texta.black("Test") |> should equal "\u001b[0;30mTest\u001b[0m"
    Texta.red("Test") |> should equal "\u001b[0;31mTest\u001b[0m"
    Texta.green("Test") |> should equal "\u001b[0;32mTest\u001b[0m"
    Texta.yellow("Test") |> should equal "\u001b[0;33mTest\u001b[0m"
    Texta.blue("Test") |> should equal "\u001b[0;34mTest\u001b[0m"
    Texta.magenta("Test") |> should equal "\u001b[0;35mTest\u001b[0m"
    Texta.cyan("Test") |> should equal "\u001b[0;36mTest\u001b[0m"
    Texta.white("Test") |> should equal "\u001b[0;37mTest\u001b[0m"

[<Test>]
let ``you can pass format strings to the functions`` () =
  let message = Texta.red("This is a %s") "test"
  message |> should equal "\u001b[0;31mThis is a test\u001b[0m"
