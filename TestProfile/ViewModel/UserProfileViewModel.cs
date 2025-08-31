using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestProfile.ViewModel
{
    public partial class UserProfileViewModel : ObservableObject
    {
        public UserProfileViewModel()
        {
        }

        [RelayCommand]
        private async Task GoToLogin()
        {
            await Shell.Current.GoToAsync($"../{nameof(LoginPage)}");
        }
    }
}
