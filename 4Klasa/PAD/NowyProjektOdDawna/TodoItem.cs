using CommunityToolkit.Mvvm.ComponentModel;

namespace NowyProjektOdDawna;

public partial class TodoItem(string title, string content, bool isDone) : ObservableObject
{
    private static long CurrentIndex = 1;
    [ObservableProperty] private long _id = CurrentIndex++;
    [ObservableProperty] private string _title = title;
    [ObservableProperty] private string _content = content;
    [ObservableProperty] private bool _isDone = isDone;
    [ObservableProperty] private DateTime _creationDate = DateTime.Now;
    [ObservableProperty] private DateTime _lastModified = DateTime.Now;
}