using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NowyProjektOdDawna;

public partial class TodoViewModel : ObservableObject
{
    public ObservableCollection<TodoItem> TodoItems { get; } = [];

    [ObservableProperty] private TodoItem? _selectedItem;
    [ObservableProperty] private string _newTitle = null!;
    [ObservableProperty] private string _newContent = null!;
    [ObservableProperty] private bool _newIsDone;

    public ICommand AddNewTodoCommand { get; }

    public ICommand ModifyTodoCommand { get; }

    public TodoViewModel()
    {
        AddNewTodoCommand = new RelayCommand(AddNewTodo);
        ModifyTodoCommand = new RelayCommand(ModifyTodo);
    }

    private void AddNewTodo()
    {
        TodoItems.Add(new TodoItem(NewTitle, NewContent, NewIsDone));
    }

    private void ModifyTodo()
    {
        if (SelectedItem == null)
        {
            MessageBox.Show(
                "Please select item first.",
                "Could not modify",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            return;
        }

        SelectedItem.Title = NewTitle;
        SelectedItem.Content = NewContent;
        SelectedItem.IsDone = NewIsDone;
        SelectedItem.LastModified = DateTime.Now;
    }
}