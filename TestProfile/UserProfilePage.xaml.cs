using TestProfile.ViewModel;

namespace TestProfile;

public partial class UserProfilePage : ContentPage
{
	public UserProfilePage(UserProfileViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}