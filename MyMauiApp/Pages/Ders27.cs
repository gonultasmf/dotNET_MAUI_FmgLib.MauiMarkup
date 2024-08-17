namespace MyMauiApp.Pages;

public partial class Ders27 : FmgLibContentPage
{
    public List<Animal> Animals { get; set; } = new();

    public Ders27()
    {
        BindingContext = this;
        LoadData();
    }

    public override void Build()
    {
        this
        .Content(
            new CollectionView()
            .ItemsSource(e => e.Path("Animals"))
            .Margin(10)
            .ItemsLayout(
                new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                .ItemSpacing(10)
            )
            .ItemTemplate(new DataTemplate(() =>
                new SwipeView()
                .RightItems(
                    new SwipeItem()
                    .Text("Delete")
                    .BackgroundColor(Red)
                    .OnClicked((sender, e) =>
                    {
                        var temp = (sender as SwipeItem).Text;
                    })
                )
                .LeftItems(
                    new SwipeItem()
                    .Text("Favorite")
                    .BackgroundColor(Green)
                    .OnClicked((sender, e) =>
                    {
                        var temp = (sender as SwipeItem).Text;
                    })
                )
                .Content(
                    new Grid()
                    .RowDefinitions(e => e.Auto().Auto())
                    .ColumnDefinitions(e => e.Auto().Auto())
                    .Spacing(15)
                    .Padding(10)
                    .Children(
                        new Image()
                        .Source(e => e.Path("ImageUrl"))
                        .SizeRequest(60)
                        .Aspect(Aspect.AspectFill)
                        .RowSpan(2),

                        new Label()
                        .Text(e => e.Path("Name"))
                        .FontAttributes(Bold)
                        .Column(1),

                        new Label()
                        .Text(e => e.Path("Location"))
                        .FontAttributes(Italic)
                        .Row(1)
                        .Column(1)
                    )
                )
            ))
        );
    }

    private void LoadData()
    {
        for (int i = 1; i <= 15; i++)
        {
            Animals.Add(new()
            {
            ImageUrl = "dotnet_bot.png",
            Name = $"Monkey {i}",
            Details = $"Details {i}",
            Location = $"Location {i}"
            });
        }
    }
}
