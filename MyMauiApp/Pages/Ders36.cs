namespace MyMauiApp.Pages;

public partial class Ders36 : FmgLibContentPage
{
    public Ders36()
    {
        
    }

    private void BtnClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        button.TextColor = Yellow;
    }
    public override void Build()
    {
        this
        .BackgroundColor(LightGray)
        //.BackgroundImageSource("dotnet_bot.png")
        .HideSoftInputOnTapped(true)
        .Content(
            new Entry()
            .Text("Click Me")
            .SizeRequest(160, 60)
            .TextColor(Red)
            .FontSize(20)
            .FontAttributes(Bold)
            .BackgroundColor(Yellow)
        );
    }
}
