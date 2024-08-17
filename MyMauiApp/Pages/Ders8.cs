namespace MyMauiApp.Pages;

public partial class Ders8 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new HorizontalStackLayout()
            .Spacing(0)
            .Center()
            .Children(
                new CheckBox()
                .IsChecked(true)
                .Color(Red)
                .OnCheckedChanged((sender, e) =>
                {
                    var text = (sender as CheckBox).IsChecked.ToString();
                }),

                new Label()
                .Text("Beni Hatırla")
                .TextCenterLeft()
            )
        );
    }
}
