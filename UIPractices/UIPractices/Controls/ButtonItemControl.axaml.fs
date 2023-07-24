namespace UIPractices.Controls
open System.Windows.Input
open Avalonia
open Avalonia.Controls.Primitives
open Avalonia.Media.Imaging
open Avalonia.Platform


type ButtonItemControl() as x =
  inherit TemplatedControl()
  
  static let TitleTextProperty =
    AvaloniaProperty
      .Register<ButtonItemControl, string>("TitleText")

  static let ImageLinkProperty =
    AvaloniaProperty.Register<ButtonItemControl, IBitmapImpl>("ImageLink")
  
  static let CommandProperty =
    AvaloniaProperty
      .Register<ButtonItemControl, ICommand>("Command")
  
  member public x.TitleText
    with get() = x.GetValue(TitleTextProperty)
    and set value = x.SetValue(TitleTextProperty, value) |> ignore

  member public x.ImageLink
    with get() = x.GetValue(ImageLinkProperty)
    and set value = x.SetValue(ImageLinkProperty, value) |> ignore
    
  member public x.Command
    with get() = x.GetValue(CommandProperty)
    and set value = x.SetValue(CommandProperty, value) |> ignore
    