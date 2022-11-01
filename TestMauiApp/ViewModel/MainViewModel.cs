using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMauiApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    public string text;

    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text))
            return;
        Items.Add(Text);
        Text = string.Empty;
    }
    [RelayCommand]
    void Delete(string s)
    {
        if (items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}
