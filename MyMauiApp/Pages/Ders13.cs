namespace MyMauiApp.Pages;

public partial class Ders13 : FmgLibContentPage
{
    Label label, displayLabel;
    public override void Build()
    {
        this
        .Content(
            new Grid()
            .FillBothDirections()
            .Children(
                new Label()
                .Assign(out label)
                .Text("ROTATING TEXT")
                .AlignTopCenter()
                .Margin(50)
                .FontSize(18),

                new Slider()
                .CenterVertical()
                .Maximum(360)
                .OnValueChanged((sender, e) =>
                {
                    double value = e.NewValue;
                    label.Rotation = value;
                    displayLabel.Text = String.Format("The Slider value is {0}", value);
                }),

                new Label()
                .Assign(out displayLabel)
                .Text("(uninitialized)")
                .AlignBottomCenter()
            )
        );
    }
}
