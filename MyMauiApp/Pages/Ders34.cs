using Microsoft.Maui.Layouts;

namespace MyMauiApp.Pages;

public partial class Ders34 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new AbsoluteLayout()
            //.Margin(20)
            .Children(
                //new BoxView()
                //.Color(Silver)
                //.AbsoluteLayoutBounds(0,10,200,5),

                //new BoxView()
                //.Color(Silver)
                //.AbsoluteLayoutBounds(0, 20, 200, 5),

                //new BoxView()
                //.Color(Silver)
                //.AbsoluteLayoutBounds(10, 0, 5, 65),

                //new BoxView()
                //.Color(Silver)
                //.AbsoluteLayoutBounds(20, 0, 5, 65),

                //new Label()
                //.Text("Stylish Header")
                //.AbsoluteLayoutBounds(30,25,100,25)

                new BoxView()
                .Color(Blue)
                .AbsoluteLayoutBounds(0.5, 0, 100, 25)
                .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional),

                new BoxView()
                .Color(Green)
                .AbsoluteLayoutBounds(0, 0.5, 25, 100)
                .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional),

                new BoxView()
                .Color(Red)
                .AbsoluteLayoutBounds(1, 0.5, 25, 100)
                .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional),

                new BoxView()
                .Color(Black)
                .AbsoluteLayoutBounds(0.5, 1, 100, 25)
                .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional),

                new Label()
                .Text("Centered text")
                .AbsoluteLayoutBounds(0.5, 0.5, 110, 25)
                .AbsoluteLayoutFlags(AbsoluteLayoutFlags.PositionProportional)
            )
        );
    }
}
