namespace UIPractices.ViewModels

open CommunityToolkit.Mvvm.ComponentModel

(*/ 
type RelayCommand(execute: obj -> unit, canExecute: obj -> bool) as x =    
  let canExecuteChanged = Event<EventHandler, EventArgs>()

  interface ICommand with
    [<CLIEvent>]
    member this.CanExecuteChanged = canExecuteChanged.Publish
    member x.CanExecute parameter = canExecute(parameter)
    member x.Execute parameter = execute parameter
    
  member this.RaiseCanExecuteChanged() =
    canExecuteChanged.Trigger(x, EventArgs.Empty)
/*)

type ViewModelBase()=
  inherit ObservableObject()

  (*/ 
  let propertyChanged = Event<_, _>()

  interface INotifyPropertyChanged with
    [<CLIEvent>]
    member x.PropertyChanged = propertyChanged.Publish

  member x.NotifyPropertyChanged(propertyName: string) =
    Console.WriteLine "Notify"
    propertyChanged.Trigger(x, PropertyChangedEventArgs(propertyName))
    
  /*)
