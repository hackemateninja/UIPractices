namespace UIPractices.ViewModels

open System
open CommunityToolkit.Mvvm.ComponentModel
open CommunityToolkit.Mvvm.Input

type TodoListWindowViewModel () =
  inherit ViewModelBase()
  
  [<ObservableProperty>]
  let mutable _currentView = ViewModelBase()
  
  let _addItemView = TodoListAddItemViewModel()
  
  let _todoItemView = TodoListViewModel()
  
  do
    _currentView <- _todoItemView

  member x.CurrentView
    with get() = _currentView
    and set value =
      x.SetProperty(&_currentView, value) |> ignore
      
  member x.ChangeToAddItem () =
    Console.WriteLine "hello frorm view model "
    x.CurrentView <- _addItemView