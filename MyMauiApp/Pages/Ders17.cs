namespace MyMauiApp.Pages;

public partial class Ders17 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Spacing(15)
            .Children(
                new Picker()
                .Title("Select Item")
                .ItemsSource(new List<string>
                {
                    "Item 1",
                    "Item 2",
                    "Item 3",
                    "Item 4",
                    "Item 5",
                    "Item 6"
                })
                .OnSelectedIndexChanged((sender, e) =>
                {
                    var picker = sender as Picker;
                    var temp = picker.Items[picker.SelectedIndex];
                })
            )
        );
    }
}
