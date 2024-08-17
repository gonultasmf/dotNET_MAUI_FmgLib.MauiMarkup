namespace MyMauiApp.Pages;

public partial class Ders28 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new TableView()
            .Intent(TableIntent.Menu)
            .HasUnevenRows(true)
            .Root(
                new TableSection("Chapters")
                {
                    new TextCell()
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new TextCell()
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new TextCell()
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new TextCell()
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new TextCell()
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides.")
                },

                new TableSection("Menü")
                {
                    new ImageCell()
                    .ImageSource("dotnet_bot.png")
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new ImageCell()
                    .ImageSource("dotnet_bot.png")
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new ImageCell()
                    .ImageSource("dotnet_bot.png")
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new ImageCell()
                    .ImageSource("dotnet_bot.png")
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides."),
                    new ImageCell()
                    .ImageSource("dotnet_bot.png")
                    .Text("1. Introduction to .NET MAUI")
                    .Detail("Learn about .NET MAUI and what it provides.")
                },

                new TableSection("Settings")
                {
                    new SwitchCell()
                    .Text("Karanlık Tema")
                    .On(false)
                },

                new TableSection("Entry")
                {
                    new EntryCell()
                    .Label("Username")
                    .Placeholder("Kullanıcı adınız.")
                },

                new TableSection("Silent")
                {
                    new ViewCell()
                    .View(
                        new Grid()
                        .RowDefinitions(e => e.Auto().Auto())
                        .ColumnDefinitions(e => e.Star(.5).Star(.5))
                        .Children(
                            new Label()
                            .Text("Vibrate")
                            .Margin(10,10,0,0),

                            new Switch()
                            .Column(1)
                            .AlignRight(),

                            new Slider()
                            .Minimum(0)
                            .Maximum(10)
                            .Value(3)
                            .Margin(10)
                            .Row(1)
                            .ColumnSpan(2)
                        )
                    )
                }
            )
        );
    }
}
