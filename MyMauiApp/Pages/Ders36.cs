namespace MyMauiApp.Pages;

public partial class Ders36 : ContentPage, IFmgLibHotReload
{
    public Ders36()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        //.BackgroundColor(Red)
        //.BackgroundImageSource("dotnet_bot.png")
        .Title("Content Page")
        .Padding(50)
        .Content(
            new VerticalStackLayout()
            .AlignCenterLeft()
            .Spacing(10)
            .Children(
                new Label()
                .Text("Content Page")
                .TextColor(Black)
                .FontAttributes(Bold)
                .FontSize(30)
                .Center(),

                new Label()
                .Text("Content Page")
                .TextColor(Black)
                .FontAttributes(Bold)
                .FontSize(30)
                .Center(),

                new Label()
                .Text("Content Page")
                .TextColor(Black)
                .FontAttributes(Bold)
                .FontSize(30)
                .Center()
            )
        );
    }
}
