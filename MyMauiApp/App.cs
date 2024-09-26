using Microsoft.Maui.Controls.StyleSheets;

namespace MyMauiApp;

public partial class App : Application, IFmgLibHotReload
{
    public App()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(
            //new NavigationPage(new Ders2())
            //.BarBackgroundColor(Red)
            //.BarTextColor(Yellow)
            //.HasBackButton(true)
            //.IconColor(White)
            //.IconImageSource("")
            //.TitleIconImageSource("")
            //.TitleView(new Button())
            //new AppShell()
            new Ders43()
        );
    }
}
