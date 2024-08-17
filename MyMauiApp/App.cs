namespace MyMauiApp;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(new Ders29());
    }
}
