namespace MyMauiApp.Pages;

public partial class Ders16 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(15)
            .Children(
                new TimePicker()
                .Time(new TimeSpan(18,15,00))
                .TextColor(Red)
            )
        );
    }
}
