namespace UIPractices

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open UIPractices.ViewModels
open UIPractices.Views

type App() =
  inherit Application()
  
  override this.Initialize() =
    AvaloniaXamlLoader.Load(this)

  override this.OnFrameworkInitializationCompleted() =
    match this.ApplicationLifetime with
    | :? IClassicDesktopStyleApplicationLifetime as desktopLifetime ->
        desktopLifetime.MainWindow <- MainWindow(DataContext = MainViewModel())
    | _ -> ()
    base.OnFrameworkInitializationCompleted()