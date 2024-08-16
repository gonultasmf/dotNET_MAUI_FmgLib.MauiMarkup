namespace MyMauiApp.Pages;

public partial class Ders1 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new Label()
            .Text("FmgLib.MauiMarkup")
            .CharacterSpacing(2)
            .FontSize(30)
            .FontAttributes(Italic)
            .TextColor(Red)
            .TextCenter()
            //.HorizontalTextAlignment(TextAlignment.Center)
            //.VerticalTextAlignment(TextAlignment.Center)
        );
    }
}
