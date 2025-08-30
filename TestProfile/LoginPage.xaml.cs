using TestProfile.ViewModel;

namespace TestProfile;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}