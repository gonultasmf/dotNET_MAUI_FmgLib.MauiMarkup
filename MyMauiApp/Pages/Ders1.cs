using FmgLib.MauiMarkup;

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
        .MenuBarItems(
            new MenuBarItem()
            {
                new MenuFlyoutItem().Text("Exit")
                    .OnClicked(e => Application.Current.Quit()),
            }.Text("My Menu"),
            new MenuBarItem()
            {
                new MenuFlyoutItem().Text("Blue")  
                    .OnClicked(e => this.BackgroundColor = Colors.Blue),
                new MenuFlyoutItem().Text("Red")
                    .OnClicked(e => this.BackgroundColor = Colors.Red),
                new MenuFlyoutItem().Text("Black")
                    .OnClicked(e => this.BackgroundColor = Colors.Black)
            }.Text("Theme")
        )
        .Title("")
        .IconImageSource("dotnet_bot.png")
        .Content(
            new Label()
            .Text("FmgLib.MauiMarkup")
            .CharacterSpacing(2)
            .FontSize(30)
            .FontAttributes(Italic)
            .TextColor(Green)
            .TextCenter()
            .SemanticDescription("My name is Mustafa")
            .Center()

        //new Border()
        //.SizeRequest(400,200)
        //.Center()
        //.Stroke(Transparent)
        //.Background(new SolidColorBrush().Color(Yellow))
        //.Background(
        //    new LinearGradientBrush()
        //    .StartPoint(new Point(1,1))
        //    .EndPoint(new Point(0,1))
        //    .GradientStops(
        //        new GradientStop().Color(Yellow).Offset(0.1f),
        //        new GradientStop().Color(Green).Offset(1.0f)

        //    )
        //)
        //.Background(
        //    new RadialGradientBrush()
        //    .Center(new Point(0.5,0.5))
        //    .Radius(0.25)
        //    .GradientStops(
        //        new GradientStop().Color(Yellow).Offset(0.1f),
        //        new GradientStop().Color(Red).Offset(0.6f),
        //        new GradientStop().Color(Green).Offset(1.0f)
        //    )
        //)
        );
    }
}