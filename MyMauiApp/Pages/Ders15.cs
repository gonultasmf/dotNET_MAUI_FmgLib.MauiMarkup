namespace MyMauiApp.Pages;

public partial class Ders15 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(15)
            .Children(
                new DatePicker()
                .MinimumDate(DateTime.Now)
                .MaximumDate(DateTime.Now.AddMonths(4))
                .Date(DateTime.Now.AddDays(2))
            )
        );
    }
}
