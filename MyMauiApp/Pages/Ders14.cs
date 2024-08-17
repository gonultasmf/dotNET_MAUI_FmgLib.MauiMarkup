namespace MyMauiApp.Pages;

public partial class Ders14 : FmgLibContentPage
{
    int count = 0;
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(15)
            .Children(
                new Label()
                .Assign(out var label)
                .Text("Count: 0"),

                new ImageButton()
                .Source("dotnet_bot.png")
                .SizeRequest(150,70)
                .BorderWidth(2)
                .BorderColor(Black)
                .OnClicked((sender, e) =>
                {
                    label.Text = $"Count: {++count}";
                })
            )
        );
    }
}
