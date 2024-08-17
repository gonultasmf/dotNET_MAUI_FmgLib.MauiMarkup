
namespace MyMauiApp.Pages;

public partial class Ders24 : FmgLibContentPage
{
    public List<AnimalGroup> AnimalGroups { get; set; }
    public List<Animal> Animals { get; set; } = new();

    public Ders24()
    {
        BindingContext = this;
        //LoadData();
        LoadDataGroup();
    }

    public override void Build()
    {
        this
        .Content(
            new RefreshView()
            .OnRefreshing(async (sender, e) =>
            {
                await Task.Delay(2000);
                LoadDataGroup();
                ((RefreshView)sender).IsRefreshing = false;
            })
            .Content(
                new CollectionView()
                .Margin(10)
                .Header(
                    new Grid()
                    .Children(
                        new Label()
                        .Text("Hayvanlar")
                        .FontAttributes(Bold)
                        .FontSize(20)
                        .TextColor(Blue)
                        .Center()
                    )
                )
                .Footer(
                    new Grid()
                    .Children(
                        new Label()
                        .Text("@2024 FmgLib.MauiMarkup")
                        .FontAttributes(Bold)
                        .FontSize(20)
                        .TextColor(Blue)
                        .Center()
                    )
                )
                .IsGrouped(true)
                .SelectionMode(SelectionMode.None)
                //.ItemsSource(e => e.Path(nameof(Animals)))
                .ItemsSource(e => e.Path(nameof(AnimalGroups)))
                //.ItemsLayout(
                //    new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                //    .Span(2)
                //    .HorizontalItemSpacing(30)
                //    .VerticalItemSpacing(10)
                //)
                .ItemsLayout(
                    new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                    .ItemSpacing(10)
                )
                .ItemTemplate(new DataTemplate(() =>
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
                ))
                .EmptyView(
                    new Grid()
                    .Children(
                        new Label()
                        .Text("Listemiz boş...")
                        .FontAttributes(Bold)
                        .FontSize(20)
                        .TextColor(Red)
                        .Center()
                    )
                )
                .GroupHeaderTemplate(new DataTemplate(() =>
                    new Label()
                    .Text(e => e.Path("Name"))
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .TextColor(Red)
                    .AlignCenterLeft()
                ))
                .GroupFooterTemplate(new DataTemplate(() =>
                    new Label()
                    .Text(e => e.Path("Name"))
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .TextColor(Red)
                    .AlignCenterLeft()
                ))
                .ItemsUpdatingScrollMode(ItemsUpdatingScrollMode.KeepScrollOffset)

            )
        );
    }



    private void LoadData()
    {
        for (int i = 1; i <= 25; i++)
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

    private void LoadDataGroup()
    {
        AnimalGroups = new List<AnimalGroup>();

        for (int i = 1; i < 5; i++)
        {
            var group = new AnimalGroup($"Group {i}");

            for (int j = 1; j < 7; j++)
            {
                group.Add(new Animal
                {
                    ImageUrl = "dotnet_bot.png",
                    Name = $"Monkey {j}",
                    Details = $"Details {j}",
                    Location = $"Location {j}",
                });
            }
            AnimalGroups.Add(group);
        }
    }
}
