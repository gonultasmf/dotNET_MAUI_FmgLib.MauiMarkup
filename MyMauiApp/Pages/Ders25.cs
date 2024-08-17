namespace MyMauiApp.Pages;

public partial class Ders25 : FmgLibContentPage
{
    public List<Animal> Animals { get; set; } = new();

    public Ders25()
    {
        BindingContext = this;
        LoadData();
    }

    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Children(
                new CarouselView()
                .ItemsSource(e => e.Path("Animals"))
                .PeekAreaInsets(120)
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
                .EmptyView("No items to display.")
                .OnCurrentItemChanged((sender, e) =>
                {
                    Animal previousItem = e.PreviousItem as Animal;
                    Animal currentItem = e.CurrentItem as Animal;
                    //Debug.WriteLine($"")
                })
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
}
