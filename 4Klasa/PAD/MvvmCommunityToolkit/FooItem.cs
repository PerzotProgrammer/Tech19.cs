using CommunityToolkit.Mvvm.ComponentModel;

namespace MvvmCommunityToolkit;

public partial class FooItem : ObservableObject
{
    [ObservableProperty] private string foo;
    [ObservableProperty] private int bar;
}