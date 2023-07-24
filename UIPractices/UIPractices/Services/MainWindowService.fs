namespace UIPractices.Services

open System
open Avalonia
open Avalonia.Collections
open Avalonia.Platform

module Helpers =
  open Avalonia.Media.Imaging
  let createBitMap (path: string): IReadableBitmapImpl =
    let uri = Uri($"avares://UIPractices/Assets/{path}")
    let assets = AvaloniaLocator.Current.GetService<IAssetLoader>()
    let asset = assets.Open(uri)
    new Bitmap(asset)



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

