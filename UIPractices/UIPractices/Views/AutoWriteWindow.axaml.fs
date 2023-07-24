namespace UIPractices.Views

open System
open Avalonia.Controls
open Avalonia.Interactivity
open Avalonia.Markup.Xaml
open Avalonia.Threading
open Microsoft.FSharp.Control


type AutoWriteWindow () as x =
  inherit Window()

  let mutable textBox = Unchecked.defaultof<TextBox>

  let mutable currentIdx = 0

  let timer = DispatcherTimer()

  let getClipboardText () =
    (*let clip = TopLevel.GetTopLevel(textBox).Clipboard.GetTextAsync()
    let clipBoard = AvaloniaLocator.GetService<IClipboard>()*)
    async{
      return! TopLevel.GetTopLevel(textBox).Clipboard.GetTextAsync() |> Async.AwaitTask
    }|> Async.RunSynchronously

  do
    x.InitializeComponent()
    textBox <- x.FindControl<TextBox> "TextBox0"
    timer.Interval <- TimeSpan.FromMilliseconds 100
    timer.Tick.Add(x.TimerTick())

  member private x.InitializeComponent() =
    AvaloniaXamlLoader.Load(x)

  member private x.TimerTick (sender: obj) (e: EventArgs) =
    let clipText = getClipboardText()

    if currentIdx < clipText.Length then
        textBox.Text <- textBox.Text + string clipText.[currentIdx]
        currentIdx <- currentIdx + 1
    else
      timer.Stop()


  member private x.StartAutoWrite (sender: obj) (e: RoutedEventArgs) =
    currentIdx <- 0
    textBox.Text = "String.Empty" |> ignore
    timer.Start()