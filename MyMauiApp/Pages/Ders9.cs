namespace MyMauiApp.Pages;

public partial class Ders9 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new HorizontalStackLayout()
            .Spacing(3)
            .Center()
            .Children(
                new Label().Text("Cinsiyet: ").TextCenter(),

                new RadioButton()
                .Content("Kadın")
                .BorderColor(Red)
                .BorderWidth(2)
                .OnCheckedChanged((sender, e) =>
                {
                    var temp = (sender as RadioButton).IsChecked.ToString();
                }),
                new RadioButton().Content("Erkek")
            )
        );
    }
}
