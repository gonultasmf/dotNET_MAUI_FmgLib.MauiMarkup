using Microsoft.Maui.Controls.Shapes;

namespace MyMauiApp.Pages;

public class Ders41 : ContentPage, IFmgLibHotReload
{
    Image image;
    public Ders41()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders41")
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Image()
                .Assign(out image)
                .Source("dotnet_bot.png")
                .SizeRequest(200)
                .OnLoaded(async (sender, e) =>
                {
                    await Rotate();
                })
            )
        );
    }

    public async Task Rotate()
    {
        await image.RotateTo(360, 2000);
        await image.RelRotateTo(360, 2000);
        await image.ScaleTo(1, 2000);
        //await image.RelScaleTo(2, 2000);
        await image.TranslateTo(-100, 0, 1000);    // Move image left
        await image.TranslateTo(-100, -100, 1000); // Move image diagonally up and left
        await image.TranslateTo(100, 100, 2000);   // Move image diagonally down and right
        await image.TranslateTo(0, 100, 1000);     // Move image left
        await image.TranslateTo(0, 0, 1000);       // Move image up
        image.Opacity = 0;
        await image.FadeTo(1, 4000);
        image.Rotation = 0;
        await Task.WhenAny<bool>
        (
          image.RotateTo(360, 4000),
          image.ScaleTo(2, 2000)
        );
        await image.ScaleTo(1, 2000);
        // 10 minute animation
        uint duration = 1 * 60 * 1000;
        await Task.WhenAll
        (
          image.RotateTo(307 * 360, duration),
          image.RotateXTo(251 * 360, duration),
          image.RotateYTo(199 * 360, duration)
        );
    }
}