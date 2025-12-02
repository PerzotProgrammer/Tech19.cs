using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmCommunityToolkit;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string newFoo = "hello";

    public ObservableCollection<FooItem> FooItemList { get; } = new();

    [RelayCommand]
    private void OnFooAdded()
    {
        FooItemList.Add(new FooItem
        {
            Foo = NewFoo,
            Bar = FooItemList.Count + 1
        });

        MessageBox.Show($"Foo added: {NewFoo}");
        NewFoo = string.Empty;
    }

    [RelayCommand]
    private void OnFooRemoved(FooItem selectedFooItem)
    {
        FooItemList.Remove(selectedFooItem);
        for (int i = 0; i < FooItemList.Count; i++)
            FooItemList[i].Bar = i + 1;

        MessageBox.Show("Foo was deleted!");
    }
}