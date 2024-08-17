namespace MyMauiApp.Pages;

public partial class Ders20 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(10)
            .FillBothDirections()
            .Children(
                new BoxView()
                .Color(Red)
                .SizeRequest(160)
                .Center()
                .CornerRadius(20,0,0,20),

                new BoxView()
                .HeightRequest(1)
                .Margin(10)
                .Color(Black)
            )
        );
    }
}
