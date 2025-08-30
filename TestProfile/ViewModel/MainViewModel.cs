using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProfile.Services.Navigation;

namespace TestProfile.ViewModel
{
    public partial class MainViewModel:ObservableObject
    {
        public MainViewModel()
        {
        }

        [RelayCommand]
        private async Task GoToLogin()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
