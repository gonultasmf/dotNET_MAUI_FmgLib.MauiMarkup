namespace MyMauiApp.Pages;

public partial class Ders26 : FmgLibContentPage
{
    public List<Animal> Animals { get; set; } = new();

    public Ders26()
    {
        BindingContext = this;
        LoadData();
    }

    IndicatorView iv;

    public override void Build()
    {
        this
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star().Auto())
            .Margin(20)
            .Center()
            .Children(
                new IndicatorView()
                .Assign(out iv)
                .Row(1)
                .IndicatorSize(20)
                .IndicatorColor(LightGray)
                .SelectedIndicatorColor(Blue)
                .CenterHorizontal(),

                new CarouselView()
                .IndicatorView(iv)
                .ItemsSource(e => e.Path("Animals"))
                .ItemsLayout(
                    new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                    .ItemSpacing(20)
                )
                .ItemTemplate(new DataTemplate(() =>
                    new StackLayout()
                    .Children(
                        new Frame()
                        .HasShadow(true)
                        .BorderColor(DarkGray)
                        .CornerRadius(5)
                        .Margin(10)
                        .HeightRequest(300)
                        .Center()
                        .Content(
                            new StackLayout()
                            .Children(
                                new Label()
                                .Text(e => e.Path("Name"))
                                .FontAttributes(Bold)
                                .FontSize(20)
                                .Center(),

                                new Image()
                                .Source(e => e.Path("ImageUrl"))
                                .SizeRequest(150)
                                .Aspect(Aspect.AspectFill)
                                .CenterHorizontal(),

                                new Label()
                                .Text(e => e.Path("Location"))
                                .CenterHorizontal(),

                                new Label()
                                .Text(e => e.Path("Details"))
                                .FontAttributes(Italic)
                                .MaxLines(5)
                                .LineBreakMode(LineBreakMode.TailTruncation)
                                .CenterHorizontal()
                            )
                        )
                    )
                ))
            )
        );
    }

    private void LoadData()
    {
        for (int i = 1; i <= 6; i++)
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
