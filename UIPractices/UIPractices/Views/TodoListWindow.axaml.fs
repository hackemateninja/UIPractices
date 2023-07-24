namespace UIPractices.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml
open UIPractices.ViewModels

type TodoListWindow () as x =
  inherit Window()
  
  do
    x.InitializeComponent()
    x.DataContext <- TodoListWindowViewModel()
    
  member x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)