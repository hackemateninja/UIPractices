namespace UIPractices.Views

open System
open Avalonia.Controls
open Avalonia.Interactivity
open Avalonia.Markup.Xaml

type CalculatorWindow () as x =
  inherit Window()
  
  do
    x.InitializeComponent()
  
  member private x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)
    
  member private x.Calculate(sender: obj) (e: RoutedEventArgs) =
    let _cen = x.FindControl<TextBox>("Cen")
    let _fa = x.FindControl<TextBox>("Fa")
    let mutable C = 0.0
    if Double.TryParse(_cen.Text, &C) then
      let F = C * (9.0 / 5.0) + 32.0
      _fa.Text <- F.ToString("0.0")
    else
      _cen.Text <- "0"
      _fa.Text <- "0"
    Console.WriteLine $"Calculate {_cen.Text} {_fa.Text}"