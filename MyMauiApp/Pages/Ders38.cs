namespace MyMauiApp.Pages;

public class Ders38 : TabbedPage, IFmgLibHotReload
{
    public Ders38()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .UnselectedTabColor(Red)
        .SelectedTabColor(Green)
        //.ItemsSource(Pages)
        //.ItemTemplate(() =>
        //    //new Ders1()
        //    new ContentPage()
        //    .Title("Denem")
        //    .Content(
        //        new StackLayout()
        //        .Children(
        //            new Label()
        //            .Text("DENEME")
        //            .FontAttributes(Bold)
        //            .FontSize(32),

        //            new Image()
        //            .Source("dotnet_bot.png")
        //            .SizeRequest(120),

        //            new Label()
        //            .Text("Test amaçlıdır.")
        //            .FontAttributes(Bold)
        //            .FontSize(25),

        //            new Label()
        //            .Text("Test amaçlıdır.")
        //            .FontAttributes(Italic)
        //            .FontSize(20)
        //        )
        //    )
        //);
        .BarBackgroundColor(DarkGray)
        .BarTextColor(Yellow)
        .BackgroundColor(Pink)
        .Children(
            new Ders1(),
            new Ders2(),
            new Ders3(),
            new Ders4()
        );
    }

    public List<Page> Pages = new List<Page>
    {
        new Ders1(),
        new Ders2(),
        new Ders3(),
        new Ders4()
    };
}
