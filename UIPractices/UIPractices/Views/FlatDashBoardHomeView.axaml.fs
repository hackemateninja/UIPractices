namespace UIPractices.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml


type FlatDashBoardHomeView () as x =
  inherit UserControl()
  
  do
    x.InitializeComponent()
  
  member x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)