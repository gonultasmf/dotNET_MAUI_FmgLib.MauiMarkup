using System.Diagnostics;

namespace MyMauiApp.Pages;

public partial class Ders23 : FmgLibContentPage
{
    public Ders23()
    {
        BindingContext = this;
    }
    public List<AnimalGroup> AnimalGroups { get; set; }
    public override void Build()
    {
        LoadData();

        this
        .Content(
            new ListView()
            .Margin(10)
            .SelectionMode(ListViewSelectionMode.None)
            .VerticalScrollBarVisibility(Never)
            .IsPullToRefreshEnabled(true)
            .IsGroupingEnabled(true)
            .SeparatorColor(Red) // her item arasındaki çizginin rengini ayarlar.
            .GroupHeaderTemplate(new DataTemplate(() => 
                new ViewCell().View(
                    new Label()
                    .Text(e => e.Path("Name"))
                    .FontSize(18)
                    .FontAttributes(Bold)
                    .BackgroundColor(LightGray)
                    .TextCenterLeft()
                )
            ))
            //.RowHeight(80)
            .ItemsSource(e => e.Path("AnimalGroups"))
            .ItemTemplate(new DataTemplate(() =>
                /*
                new ViewCell().View(
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
                */
                /*
                new TextCell()
                .Text(e => e.Path("Name"))
                .Detail(e => e.Path("Details"))
                */

                new ImageCell()
                .ImageSource(e => e.Path("ImageUrl"))
                .Text(e => e.Path("Name"))
                .Detail(e => e.Path("Details"))
            ))
            .OnRefreshing(async (sender, e) =>
            {
                await Task.Delay(2000);
                (sender as ListView).IsRefreshing = false;
            })
            .OnScrolled((sender, e) =>
            {
                Debug.WriteLine($"x: {e.ScrollX}  y: {e.ScrollY}");
            })
        );
    }

    private void LoadData()
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

public class AnimalGroup : List<Animal>
{
    public string Name { get; set; }
    public AnimalGroup(string name)
    {
        Name = name;
    }
}

public class Animal
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string ImageUrl { get; set; }
}
