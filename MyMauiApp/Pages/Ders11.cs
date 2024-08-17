using Microsoft.Maui.Controls.Shapes;

namespace MyMauiApp.Pages;

public partial class Ders11 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Frame()
                .Margin(10)
                .BorderColor(Black)
                .CornerRadius(60)
                .SizeRequest(120)
                .IsClippedToBounds(true)
                .HasShadow(true)
                .Center()
                .Content(
                    new Image()
                    .Source("dotnet_bot.png")
                    .SizeRequest(120)
                    .Aspect(Aspect.AspectFill)
                    .Margin(-20)
                )
            )
        );
    }
}
