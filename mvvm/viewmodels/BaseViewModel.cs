using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net8_mauiApp_loginPage.mvvm.viewmodels;

    public partial class BaseViewModel: ObservableObject
{
    [ObservableProperty]
    private string _title;
    [ObservableProperty]
    private bool _isBusy;



}

