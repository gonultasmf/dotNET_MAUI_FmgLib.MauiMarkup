namespace MyMauiApp.Pages;

public class Ders39 : ContentPage, IFmgLibHotReload
{
    public Ders39()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        //.Resources(
        //    new ResourceDictionary
        //    {
        //        Color temp = new Color(10,20,40)
        //    }
        //)
        .Title("Ders39")
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star().Star())
            .Center()
            .Children(
                new Label()
                .Text(".NET MAUI!")
                .FontSize(30)
                .FontAttributes(Bold)
                .Shadow(
                    new Shadow()
                    .Brush(Red)
                    .Opacity(0.5f)
                    .Radius(10)
                    .Offset(new Point(5,5))
                ),

                new Image()
                .Row(1)
                .Source("dotnet_bot.png")
                .SizeRequest(200,100)
                .Shadow(
                    new Shadow()
                    .Brush(Yellow)
                    .Opacity(0.5f)
                    .Radius(20)
                    .Offset(new Point(15, 15))
                )
            )
        );
    }
}