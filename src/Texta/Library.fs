module Texta
(* Heavily inpired by the `chalk` package for NPM *)
(* This is a definite work-in-progress, but will be updated to be much smarter in the future *)

type Foreground =
    | Black = 30
    | Red = 31
    | Green = 32
    | Yellow = 33
    | Blue = 34
    | Magenta = 35
    | Cyan = 36
    | White = 37

type Background =
    | Black = 44
    | Red = 41
    | Green = 42
    | Yellow = 43
    | Blue = 44
    | Magenta = 45
    | Cyan = 46
    | White = 47

type Style =
    | Plain = 0
    | Bold = 1
    | Underline = 4

let format (fg:Foreground) message =
    let color = int fg
    Printf.ksprintf(fun res -> sprintf "\u001b[0;%dm%s\u001b[0m" color res) message

let black message = format Foreground.Black message
let red message = format Foreground.Red message
let green message = format Foreground.Green message
let yellow message = format Foreground.Yellow message
let blue message = format Foreground.Blue message
let magenta message = format Foreground.Magenta message
let cyan message = format Foreground.Cyan message
let white message = format Foreground.White message
