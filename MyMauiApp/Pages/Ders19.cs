namespace MyMauiApp.Pages;

public partial class Ders19 : FmgLibContentPage
{
    Label label;
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .FillBothDirections()
            .Children(
                new Switch()
                .OnColor(Green)
                .ThumbColor(Pink)
                .Center()
                .OnToggled((sender, e) =>
                {
                    label.IsVisible = e.Value;
                }),

                new Label()
                .Assign(out label)
                .FontSize(30)
                .FontAttributes(Bold)
                .Text("FmgLib.MauiMarkup")
                .IsVisible(false)
            )
        );
    }
}
