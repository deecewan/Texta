module TextaTest.Library

open NUnit.Framework
open FsUnit

type InitMsgUtils() =
    inherit FSharpCustomMessageFormatter()

[<Test>]
let ``the methods output the correct colors`` () =
    Texta.black("Test") |> should equal "\\e[0;30mTest\\e[0m"
    Texta.red("Test") |> should equal "\\e[0;31mTest\\e[0m"
    Texta.green("Test") |> should equal "\\e[0;32mTest\\e[0m"
    Texta.yellow("Test") |> should equal "\\e[0;33mTest\\e[0m"
    Texta.blue("Test") |> should equal "\\e[0;34mTest\\e[0m"
    Texta.magenta("Test") |> should equal "\\e[0;35mTest\\e[0m"
    Texta.cyan("Test") |> should equal "\\e[0;36mTest\\e[0m"
    Texta.white("Test") |> should equal "\\e[0;37mTest\\e[0m"
