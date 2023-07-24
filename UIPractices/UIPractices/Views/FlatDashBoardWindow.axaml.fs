namespace UIPractices.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml

type FlatDashBoardWindow() as x =
  inherit Window()
  
  do
    x.InitializeComponent()
    
  member private x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)