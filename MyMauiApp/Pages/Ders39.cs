namespace MyMauiApp.Pages;

public partial class Ders39 : ContentPage, IFmgLibHotReload
{
    public Ders39()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Content(
            new StackLayout()
            .Margin(30)
            .Children(
                new CardView()
                .BackgroundColor(DarkGray)
                .ControlTemplate(template)
                .CardTitle("Deneme")
                .CardDescription("Deneme amaçlıdır."),

                new CardView()
                .BackgroundColor(DarkGray)
                .ControlTemplate(template)
                .CardTitle("Test")
                .CardDescription("Test amaçlıdır.")
            )
        );
    }

    ControlTemplate template = new ControlTemplate(() =>
        new Frame()
        .SizeRequest(300)
        .Content(
            new Grid()
                .ColumnDefinitions(e => e.Auto().Star())
                .Children(
                    new Image()
                    .Source("dotnet_bot.png")
                    .SizeRequest(120),

                    new Label()
                    .Text(e => e.Path("CardTitle"))
                    .TextColor(White)
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .Column(1)
                    .CenterVertical()
                )
        )
    );
}