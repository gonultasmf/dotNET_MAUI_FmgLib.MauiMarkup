namespace MyMauiApp.Pages;

public partial class Ders2 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new Button()
            .Text("Click Me")
            .SizeRequest(160,60)
            .BorderWidth(3)
            .BorderColor(Red)
            .CornerRadius(10)
            .TextColor(Red)
            .FontSize(20)
            .FontAttributes(Bold)
            .OnClicked(BtnClicked)
        );
    }

    private void BtnClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        button.TextColor = Yellow;
    }
}
