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

let format fg message =
    let color = int fg
    Printf.sprintf("\\e[0;%dm%s\\e[0m") color message

let black = format Foreground.Black
let red = format Foreground.Red
let green = format Foreground.Green
let yellow = format Foreground.Yellow
let blue = format Foreground.Blue
let magenta = format Foreground.Magenta
let cyan = format Foreground.Cyan
let white = format Foreground.White