using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        private async Task GoToProfile()
        {
            await Shell.Current.GoToAsync($"../{nameof(UserProfilePage)}");
        }
    }
}
