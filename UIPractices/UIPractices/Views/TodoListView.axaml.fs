namespace UIPractices.Views

open Avalonia.Controls
open Avalonia.Interactivity
open Avalonia.Markup.Xaml
open UIPractices.ViewModels

type TodoListView() as x =
  inherit UserControl()
  
  do
    x.InitializeComponent()
    
  member x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)
    