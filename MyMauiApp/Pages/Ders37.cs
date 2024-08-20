
namespace MyMauiApp.Pages;

public partial class Ders37 : FlyoutPage, IFmgLibHotReload
{
    public Ders37()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Flyout(
            new ContentPage()
            .Padding(20)
            .Title("Menü")
            .Content(
                new VerticalStackLayout()
                .Spacing(15)
                .Children(
                    new Label().Text("Menü Başlık").FontAttributes(Bold).Padding(10),
                    new Button().Text("Ders 1").OnClicked(OnClickedButton),
                    new Button().Text("Ders 2").OnClicked(OnClickedButton)
                )
            )
        )
        .Detail(
            new NavigationPage(new ContentPage()
                .Title("Ders 3")
                .Content(
                    new Label()
                    .Text("Hoşgeldiniz. Kanala abone olun.")
                    .FontAttributes(Bold)
                    .TextColor(Red)
                    .Center()
                )
            )
        );
    }

    private void OnClickedButton(object? sender, EventArgs e)
    {
        var btn = sender as Button;
        NavigateTo(btn.Text);
    }

    private void NavigateTo(string page)
    {
        if (page == "Ders 1")
        {
            this.Detail(new NavigationPage(new Ders1()));
        }
        else if (page == "Ders 2")
        {
            this.Detail(new NavigationPage(new Ders2()));
        }

        this.IsPresented(false);
    }
}

