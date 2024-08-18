namespace MyMauiApp.Pages;

public partial class Ders32 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star(33).Absolute(100).Auto().Star(33))
            .ColumnDefinitions(e => e.Star(33).Absolute(60).Auto().Star(33))
            //.ColumnSpacing(5)
            //.RowSpacing(5)
            .Spacing(5,25)
            .Margin(10)
            .Children(
                new BoxView()
                .Color(Red)
                .Row(0)
                .Column(0),

                new BoxView()
                .Color(Blue)
                .Row(1)
                .Column(0),

                new BoxView()
                .Color(Yellow)
                .Row(2)
                .Column(0),

                new BoxView()
                .Color(Brown)
                .Row(0)
                .Column(1),

                new BoxView()
                .Color(Black)
                .Row(1)
                .Column(1),

                new BoxView()
                .Color(Gray)
                .Row(2)
                .Column(1),

                new BoxView()
                .Color(Pink)
                .Row(0)
                .Column(2),

                new BoxView()
                .Color(Purple)
                .Row(1)
                .Column(2),
                //.RowSpan(2)

                new BoxView()
                .SizeRequest(30,50)
                .Color(Orange)
                .Row(2)
                .Column(2)
            )
        );
    }
}
