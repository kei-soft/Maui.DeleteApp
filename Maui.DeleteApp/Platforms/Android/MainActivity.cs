using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;

namespace Maui.DeleteApp;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);

        try
        {
            var name = "com.test.app"; //this.ApplicationContext.PackageName;
            Intent intent = new Intent(Intent.ActionDelete);
            intent.SetData(Android.Net.Uri.Parse("package:" + name));
            StartActivity(intent);
        }
        catch (Exception ex)
        {
            Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            Finish();
        }
    }
}
