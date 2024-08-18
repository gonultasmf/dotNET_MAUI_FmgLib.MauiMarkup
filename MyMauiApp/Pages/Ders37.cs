namespace MyMauiApp.Pages;

public partial class Ders37 : FlyoutPage, IFmgLibHotReload
{
    public Ders37()
    {
        //this.InitializeHotReload();
    }

    private void OnMenuItemClicked(object? sender, EventArgs e)
    {
        var btn = sender as Button;
        NavigateTo(btn.Text);
    }

    private void NavigateTo(string page)
    {
        if (page == "Home")
        {
            Detail = new NavigationPage(new ContentPage()
                        .Title("Home")
                        .Content(
                            new Label()
                            .Text("Welcome to the Home Page!")
                            .Center()
                        ));
        }
        else if (page == "Settings")
        {
            Detail = new NavigationPage(new ContentPage()
                        .Title("Setting")
                        .Content(
                            new Label()
                            .Text("Welcome to the Settings Page!")
                            .Center()
                        ));
        }

        this.IsPresented(false);
    }

    public void Build()
    {
        this
        .Flyout(
            new ContentPage()
            .Padding(20)
            .Title("Menu")
            .Content(
                new VerticalStackLayout()
                .Spacing(15)
                .Children(
                    new Label().Text("Menü").FontAttributes(Bold).Padding(10),
                    new Button().Text("Home").OnClicked(OnMenuItemClicked),
                    new Button().Text("Settings").OnClicked(OnMenuItemClicked)
                )
            )
        )
        .Detail(
            new NavigationPage(new ContentPage()
                .Title("Home")
                .Content(
                    new Label()
                    .Text("Welcome to the Home 2 Page!")
                    .FontAttributes(Bold)
                    .TextColor(Red)
                    .FontSize(25)
                    .Center()
                ))
        );
    }
}

