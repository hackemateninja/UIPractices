namespace UIPractices.ViewModels

open CommunityToolkit.Mvvm.ComponentModel
open UIPractices.Models
open UIPractices.Services

type MainViewModel() =
  inherit ViewModelBase()
  
  [<ObservableProperty>]
  let mutable listItems: List<MainList> = MainWindowService.getItemsBeginner()
    
  member x.ListItems
     with get() = listItems
     and set value =
       listItems <- value
       x.SetProperty(&listItems, value) |> ignore
    
    