namespace UIPractices.Views

open Avalonia
open Avalonia.Controls
open Avalonia.Interactivity
open Avalonia.Markup.Xaml

type SliderWindow () as x =
  inherit Window()
  
  let mutable currentProfile = 0
  let mutable grid0 = Grid()
  let mutable grid1 = Grid()
  let mutable grid2 = Grid()
  let mutable slider = Slider()
  
  do
    x.InitializeComponent()
    grid0 <- x.FindControl<Grid> "Grid0" 
    grid1 <- x.FindControl<Grid> "Grid1" 
    grid2 <- x.FindControl<Grid> "Grid2" 
    slider <- x.FindControl<Slider> "Slider0" 
    
  member private x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)
    
  member private x.SliderChange (sender: obj) (e: AvaloniaPropertyChangedEventArgs) =
    let idx = int slider.Value
    match idx with
      | 0 ->
        grid0.IsVisible <- true
        grid1.IsVisible <- false
        grid2.IsVisible <- false
        currentProfile <- 0
      | 1 ->
        grid0.IsVisible <- false
        grid1.IsVisible <- true
        grid2.IsVisible <- false
        currentProfile <- 1
      | 2 ->
        grid0.IsVisible <- false
        grid1.IsVisible <- false
        grid2.IsVisible <- true
        currentProfile <- 2
      | _ -> ()
        
  member private x.ClickPrev (sender: obj) (e: RoutedEventArgs) =
    currentProfile <- currentProfile - 1
    if currentProfile < 0 then currentProfile <- 2
    slider.Value <- currentProfile
    
  member private x.ClickNext (sender: obj) (e: RoutedEventArgs) =
    currentProfile <- currentProfile + 1
    if currentProfile > 2 then currentProfile <- 0
    slider.Value <- currentProfile