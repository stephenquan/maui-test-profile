using TestProfile.Services.Navigation;

namespace TestProfile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeRouting();
            InitializeComponent();
        }

        protected override async void OnHandlerChanged()
        {
            base.OnHandlerChanged();
            await Shell.Current.GoToAsync("//Main");
        }

        private static void InitializeRouting()
        {
            Routing.RegisterRoute($"//{nameof(LoginPage)}", typeof(LoginPage));
            Routing.RegisterRoute($"//{nameof(UserProfilePage)}", typeof(UserProfilePage));
        }
    }
}
