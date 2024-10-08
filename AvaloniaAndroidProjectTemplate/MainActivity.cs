using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace Andromeda.ROOTNAMESPACE.Avalonia.Android;

[Activity(
    Label = "Andromeda APPNAME",
    Theme = "@style/MyTheme.NoActionBar",
    Icon = "@drawable/main",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder);
    }
}
