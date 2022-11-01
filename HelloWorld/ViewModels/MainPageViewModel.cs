using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModels;

public class MainPageViewModel : ObservableObject
{
    private string _result = string.Empty;

    public string Result
    {
        get => _result;
        set => SetProperty(ref _result, value);
    }

    private RelayCommand _clickMeCommand;

    public RelayCommand ClickMeCommand => _clickMeCommand ?? new RelayCommand(() => { Result = "Hello World"; });

}
