namespace TestProfile.Services.Navigation;

public class MauiNavigationService : INavigationService
{
    public MauiNavigationService()
    {
    }

    public async Task InitializeAsync()
    {
        await NavigateToAsync("//Main");
    }

    
    public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
    {
        Task.Delay(500);
        var shellNavigation = new ShellNavigationState(route);

        return routeParameters != null
            ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
            : Shell.Current.GoToAsync(shellNavigation);
    }

    
    public Task PopAsync(int count = 1)
    {
        Task.Delay(500);
        string state = string.Join("/", new List<string>(new string[count]).Select(x => ".."));
        return Shell.Current.GoToAsync(state);
    }
}