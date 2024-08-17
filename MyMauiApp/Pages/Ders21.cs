using System.Diagnostics;

namespace MyMauiApp.Pages;

public partial class Ders21 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new ScrollView()
            .Margin(20)
            .Orientation(ScrollOrientation.Both)
            .HorizontalScrollBarVisibility(Always)
            .VerticalScrollBarVisibility(Always)
            .OnScrolled((sender, e) =>
            {
                Debug.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
            })
            .Content(
                new VerticalStackLayout()
                .Children(
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative"),
                    new Label()
                    .FontAttributes(Bold)
                    .FontSize(30)
                    .Text("FOR the most wild, yet most homely narrative")
                )
            )
        );
    }
}
