
namespace TestProfile.Services.Navigation;

public interface INavigationService
{
    Task InitializeAsync();

    Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

    Task PopAsync(int count = 1);
}
