namespace MyMauiApp.Pages;

public partial class Ders1 : ContentPage, IFmgLibHotReload
{
    public Ders1()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders 1")
        .IconImageSource("dotnet_bot.png")
        .Content(
            new Label()
            .Text("FmgLib.MauiMarkup")
            .CharacterSpacing(2)
            .FontSize(30)
            .FontAttributes(Italic)
            .TextColor(Green)
            .TextCenter()
        );
    }
}