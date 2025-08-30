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
    public partial class LoginViewModel : ObservableObject
    {
        public LoginViewModel()
        {
        }

        [RelayCommand]
        private async Task BackToMain()
        {
            await Shell.Current.GoToAsync("//Main");
        }

        [RelayCommand]
        private async Task GoToProfile()
        {
            await Shell.Current.GoToAsync($"//{nameof(UserProfilePage)}");
        }
    }
}
