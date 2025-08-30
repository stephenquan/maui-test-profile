using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TestProfile.Services.Navigation;
using TestProfile.ViewModel;

namespace TestProfile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<MainViewModel>();
            //builder.Services.AddTransient<UserProfilePage>();
            builder.Services.AddTransient<UserProfileViewModel>();
            builder.Services.AddSingleton<INavigationService,MauiNavigationService>();
            return builder.Build();
        }
    }
}
