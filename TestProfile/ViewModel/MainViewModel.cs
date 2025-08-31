using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestProfile.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
        }

        [RelayCommand]
        private async Task GoToLogin()
        {
            await Shell.Current.GoToAsync($"{nameof(LoginPage)}");
        }

        [RelayCommand]
        public void GarbageCollect()
        {
            GC.Collect();
        }
    }
}
