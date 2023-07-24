namespace UIPractices.ViewModels

open System
open CommunityToolkit.Mvvm.ComponentModel
open CommunityToolkit.Mvvm.Input

type FlatDashBoardViewModel() as x =
  inherit ViewModelBase()
  
  [<ObservableProperty>]
  let mutable _currentView = ViewModelBase()
  let home = FlatDashBoardHomeViewModel()
  let discovery = FlatDashBoardDiscoveryViewModel()
  
  do
    _currentView <- home
  
  member x.CurrentView
    with get () =
      _currentView
    and set value =
      x.SetProperty(&_currentView, value) |> ignore
   
  [<RelayCommand>]    
  member x.ChangeToDiscoveryViewCommand() =
    x.CurrentView <- discovery
    
  [<RelayCommand>]    
  member x.ChangeToHomeViewCommand() =
    x.CurrentView <- home