namespace MyMauiApp.Pages;

public partial class Ders35 : FmgLibContentPage
{
    public List<Animal> Animals { get; set; } = new();

    public Ders35()
    {
        LoadData();
        BindingContext = this;
    }

    public override void Build()
    {
        this
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .BindableLayoutItemsSource(e => e.Path("Animals"))
                .BindableItemTemplateSelector(new TechItemTemplateSelector())
                .BindableLayoutEmptyView(
                    new StackLayout()
                    .Center()
                    .Children(
                        new Label()
                        .Text("None.")
                        .FontSize(20)
                        .FontAttributes(Italic),

                        new Label()
                        .Text("Try harder and return later?")
                        .FontSize(20)
                        .FontAttributes(Italic)
                    )
                )
            )
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

public class TechItemTemplateSelector : DataTemplateSelector
{
    DataTemplate CustomTemplate = new DataTemplate(() =>
                    new Grid()
                    .RowDefinitions(e => e.Auto().Auto())
                    .ColumnDefinitions(e => e.Auto().Auto())
                    .Spacing(15)
                    .Padding(10)
                    .BackgroundColor(LightGray)
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
                        .Text(e => e.Path("Details"))
                        .FontAttributes(Italic)
                        .Row(1)
                        .Column(1)
                    )
                );
    DataTemplate DefaultTemplate = new DataTemplate(() =>
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
                );

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return int.Parse(((Animal)item).Name.Split(' ').Last()) % 2 == 0 ? CustomTemplate : DefaultTemplate;
    }
}
