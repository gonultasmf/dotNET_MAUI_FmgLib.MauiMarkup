namespace MyMauiApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        /*
        this
        .Items(
            new TabBar()
            .Items(
                new Tab().Title("Ders1").Items(new ShellContent().ContentTemplate(() => new Ders1())),
                new Tab().Title("Ders2").Items(new ShellContent().ContentTemplate(() => new Ders2()))
            )
        );
        */

        /*
        this
        .FlyoutHeaderBehavior(FlyoutHeaderBehavior.CollapseOnScroll)
        .Items(
            new FlyoutItem()
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
            ),

            new ShellContent()
            .Title("Ders6")
            .Icon("dotnet_bot.png")
            .ContentTemplate(() => new Ders6())
        );

        */
    }
}
