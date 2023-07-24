namespace UIPractices.Services

open System
open Avalonia.Platform

module Helpers =
  open Avalonia.Media.Imaging
  let createBitMap (path: string) =
    let uri = Uri($"avares://UIPractices/Assets/{path}")
    try
        use stream  = AssetLoader.Open(uri)
        Bitmap.DecodeToWidth(stream, 75)
    with ex ->
        printfn "Error al leer la imagen: %s" ex.Message
        null


module MainWindowService =
  open UIPractices.Models
  let getItemsBeginner (): List<MainList> =
    [
      {Id = 0; TitleText= "CALCULATOR"; ImageLink = Helpers.createBitMap "calculator.png"}
      {Id = 1; TitleText= "SLIDER"; ImageLink = Helpers.createBitMap "slider.png"}
      {Id = 2; TitleText= "FLAT DASHBOARD"; ImageLink = Helpers.createBitMap "dashboard.png"}
      {Id = 3; TitleText= "AUTO WRITER"; ImageLink = Helpers.createBitMap "writer.png"}
      {Id = 4; TitleText= "TODO LIST"; ImageLink = Helpers.createBitMap "clipboard.png"}
      {Id = 5; TitleText= "SPLASH SCREEN"; ImageLink = Helpers.createBitMap  "splash.png"}
      {Id = 6; TitleText= "WEATHER"; ImageLink = Helpers.createBitMap "weather.png"}
      {Id = 7; TitleText= "CLOCK"; ImageLink = Helpers.createBitMap "clock.png"}
      {Id = 8; TitleText= "PROGRESS"; ImageLink =Helpers.createBitMap "circular.png"}
    ]

