namespace MyMauiApp.Pages;

public partial class Ders30 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new Border()
            .StrokeThickness(4)
            .Stroke(Red)
            .Padding(20)
            .Margin(20)
            .Content(
                new StackLayout()
                //.Margin(20)
                .Orientation(StackOrientation.Horizontal)
                .Spacing(10)
                .Children(
                    new Label().Text("En üst"),
                    new Label().Text("2. sıra"),
                    new Label().Text("3. sıra"),
                    new Label().Text("4. sıra"),
                    new Label().Text("en alt")
                )
            )
            
        );
    }
}
