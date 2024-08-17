namespace MyMauiApp.Pages;

public partial class Ders22 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new RefreshView()
            .RefreshColor(Red)
            .OnRefreshing(async (sender, e) =>
            {
                await Task.Delay(3000);
                (sender as RefreshView).IsRefreshing = false;
            })
            .Content(
                new ScrollView()
                .Margin(20)
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
            )
        );
    }
}
