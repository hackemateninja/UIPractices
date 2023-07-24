namespace UIPractices.ViewModels

open CommunityToolkit.Mvvm.ComponentModel


type TodoListAddItemViewModel () =
  inherit ViewModelBase()
  
  [<ObservableProperty>]
  let mutable description = ""
  
  member x.Description
    with get () = description
    and set value =
      description <- value
      x.SetProperty(&description, value) |>ignore

