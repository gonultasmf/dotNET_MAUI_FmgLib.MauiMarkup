namespace MyMauiApp.Pages;

public partial class Ders6 : FmgLibContentPage
{
    ProgressBar progressBar;
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Spacing(10)
            .Center()
            .Children(
                new ProgressBar()
                .Assign(out progressBar)
                .SizeRequest(250)
                //.Progress(.75)
                .ProgressColor(Green),

                new Button()
                .BackgroundColor(Green)
                .Text("+")
                .FontAttributes(Bold)
                .OnClicked(async (sender, e) =>
                {
                    //progressBar.Progress += .10;
                    await progressBar.ProgressTo(0.75, 900, Easing.CubicOut);
                }),

                new Button()
                .BackgroundColor(Red)
                .Text("-")
                .FontAttributes(Bold)
                .OnClicked((sender, e) =>
                {
                    progressBar.Progress -= .10;
                })
            )
        );
    }
}
