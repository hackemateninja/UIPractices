namespace UIPractices.Views

open Avalonia
open Avalonia.Controls
open Avalonia.Input
open Avalonia.Markup.Xaml
open UIPractices.Controls
open UIPractices.Views

type MainWindow() as x = 
  inherit Window ()
  
  let openWindow(window: Window) =
    window.ShowDialog(x)|>ignore
    
  do
    x.InitializeComponent()

  member private x.InitializeComponent() =
    x.AttachDevTools()
    AvaloniaXamlLoader.Load(x)
    
  member x.OpenWindow(sender: obj) (e: TappedEventArgs) =
    let control = sender :?> ButtonItemControl
    match string control.Tag with
    | "0"  -> CalculatorWindow()|>openWindow
    | "1"  -> SliderWindow()|>openWindow
    | "2"  -> FlatDashBoardWindow()|>openWindow
    | "3"  -> AutoWriteWindow()|>openWindow
    | "4"  -> TodoListWindow()|>openWindow
    | "5"  -> CalculatorWindow()|>openWindow
    | "6"  -> CalculatorWindow()|>openWindow
    | "7"  -> CalculatorWindow()|>openWindow
    | "8"  -> CalculatorWindow()|>openWindow
    | _ -> ()
    