namespace UIPractices.ViewModels

open System
open CommunityToolkit.Mvvm.ComponentModel
open UIPractices.Models
open UIPractices.Services

type TodoListViewModel () =
  inherit ViewModelBase()
  
  [<ObservableProperty>]
  let mutable listItems: List<TodoItem> = []
  
  do
    listItems <- TodoListService.getItems()
  
  member x.Items
    with get () = listItems
    and set value =
      listItems <- value
      x.SetProperty(&listItems, value) |>ignore
     