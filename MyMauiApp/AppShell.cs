namespace MyMauiApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        /*
        this
        .ShellNavBarIsVisible(false)
        .Items(
            new TabBar()
            .Items(
                new Tab().Title("Ders1").Items(new ShellContent().ContentTemplate(() => new Ders1())),
                new Tab().Title("Ders2").Items(new ShellContent().ContentTemplate(() => new Ders2())),
                new Tab().Title("Ders3").Items(new ShellContent().ContentTemplate(() => new Ders3())),
                new Tab()
                .Title("Ders4")
                .Icon("dotnet_bot.png")
                .Items(new ShellContent().ContentTemplate(() => new Ders4()))
            )
        );
        */

        Routing.RegisterRoute(nameof(Ders1), typeof(Ders1));
        Routing.RegisterRoute(nameof(Ders2), typeof(Ders2));
        Routing.RegisterRoute(nameof(Ders3), typeof(Ders3));
        Routing.RegisterRoute(nameof(Ders4), typeof(Ders4));
        Routing.RegisterRoute(nameof(Ders5), typeof(Ders5));
        Routing.RegisterRoute(nameof(Ders6), typeof(Ders6));
       
        this
        .ShellNavBarIsVisible(false)
        .FlyoutHeaderBehavior(FlyoutHeaderBehavior.Fixed)
        .FlyoutIcon("dotnet_bot.png")
        .FlyoutBackdrop(Red)
        .FlyoutBehavior(FlyoutBehavior.Disabled)
        .FlyoutHeader(
            new ContentView()
            .HeightRequest(200)
            .Content(
                new Grid()
                .BackgroundColor(Black)
                .Children(
                    new Image()
                    .Source("dotnet_bot.png")
                    .Aspect(Aspect.AspectFill)
                    .Opacity(0.5),

                    new Label()
                    .Text("FmgLib")
                    .FontAttributes(Bold)
                    .FontSize(27)
                    .TextCenter()
                    .TextColor(White)
                )
            )
        )
        .FlyoutFooter(
            new ContentView()
            .HeightRequest(100)
            .Content(
                new VerticalStackLayout()
                .Spacing(5)
                .BackgroundColor(Black)
                .Children(
                    new Label()
                    .Text("FmgLib.MauiMarkup")
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .TextCenter()
                    .TextColor(LightGray),

                    new Label()
                    .Text("By FmgLib")
                    .FontAttributes(Bold)
                    .FontSize(27)
                    .TextCenter()
                    .TextColor(White)
                )
            )
        )
        .Items(
            new FlyoutItem()
            .Title("Denem")
            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsMultipleItems)
            .Items(
                new Tab()
                .Title("Domestic")
                .Icon("dotnet_bot.png")
                .Items(
                    new ShellContent()
                    .Title("Ders1")
                    .Icon("dotnet_bot.png")
                    .ContentTemplate(() => new Ders1()),

                    new ShellContent()
                    .Title("Ders2")
                    .Icon("dotnet_bot.png")
                    .ContentTemplate(() => new Ders2())
                ),

                new ShellContent()
                .Title("Ders3")
                .Icon("dotnet_bot.png")
                .ContentTemplate(() => new Ders3()),

                new ShellContent()
                .Title("Ders4")
                .Icon("dotnet_bot.png")
                .ContentTemplate(() => new Ders4()),

                new ShellContent()
                .Title("Ders5")
                .Icon("dotnet_bot.png")
                .ContentTemplate(() => new Ders5())
                .Route(nameof(Ders5))
            ),

            new ShellContent()
            .Title("Ders6")
            .Icon("dotnet_bot.png")
            .ContentTemplate(() => new Ders6()),

            new MenuItem()
            .Text("Help")
            .IconImageSource("dotnet_bot.png")
            .OnClicked(async (sender, e) =>
            {
                await Browser.OpenAsync("https://learn.microsoft.com/dotnet/maui/fundamentals/shell");
            })
        );
        

        //this
        //.Items(
        //    new FlyoutItem()
        //    .Title("Ders1")
        //    .Icon("dotnet_bot.png")
        //    .Items(new Tab().Items(new ShellContent().ContentTemplate(() => new Ders1()))),

        //    new FlyoutItem()
        //    .Title("Ders2")
        //    .Icon("dotnet_bot.png")
        //    .Items(new Tab().Items(new ShellContent().ContentTemplate(() => new Ders2())))
        //);

        //this
        //.Items(
        //    new ShellContent()
        //    .Title("Ders1")
        //    .Icon("dotnet_bot.png")
        //    .ContentTemplate(() => new Ders1()),

        //    new ShellContent()
        //    .Title("Ders2")
        //    .Icon("dotnet_bot.png")
        //    .ContentTemplate(() => new Ders2())
        //);
    }
}


public class AnimalSearchHandler : SearchHandler
{
    public List<Animal> Animals { get; set; } = new();
    public Type SelectedItemNavigationTarget { get; set; }

    public AnimalSearchHandler()
    {
        LoadData();
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
    protected override void OnQueryChanged(string oldValue, string newValue)
    {
        base.OnQueryChanged(oldValue, newValue);

        if (string.IsNullOrWhiteSpace(newValue))
        {
            ItemsSource = null;
        }
        else
        {
            ItemsSource = Animals
                .Where(animal => animal.Name.ToLower().Contains(newValue.ToLower()))
                .ToList<Animal>();
        }
    }

    protected override async void OnItemSelected(object item)
    {
        base.OnItemSelected(item);

        // Let the animation complete
        await Task.Delay(1000);

        ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
        // The following route works because route names are unique in this app.
        await Shell.Current.GoToAsync($"{GetNavigationTarget()}?name={((Animal)item).Name}");
    }

    string GetNavigationTarget()
    {
        //return (Shell.Current as AppShell).Routes.FirstOrDefault(route => route.Value.Equals(SelectedItemNavigationTarget)).Key;

        return "Dene";
    }
}