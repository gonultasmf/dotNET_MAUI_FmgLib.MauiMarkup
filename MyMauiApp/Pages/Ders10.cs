using Microsoft.Maui.Controls.Shapes;

namespace MyMauiApp.Pages;

public partial class Ders10 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Border()
                .Stroke(Green)
                .StrokeShape(new RoundRectangle().CornerRadius(20))
                .StrokeThickness(4)
                .Background("#2B0B98".ToColor())
                .Padding(16,8)
                .Content(
                    new Label()
                    .Text(".NET MAUI")
                    .TextColor(White)
                    .FontAttributes(Bold)
                    .FontSize(25)
                )
            )
        );
    }
}
