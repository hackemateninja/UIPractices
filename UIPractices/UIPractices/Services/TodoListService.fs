namespace UIPractices.Services

module TodoListService =
  open UIPractices.Models
  let getItems (): List<TodoItem> =
    [
      { Description= "Walk the dog"; IsChecked = false }
      { Description= "Go to the gym"; IsChecked = false }
      { Description= "code with Avalonia"; IsChecked = false }
      { Description= "Learn F#"; IsChecked = true }
    ]
