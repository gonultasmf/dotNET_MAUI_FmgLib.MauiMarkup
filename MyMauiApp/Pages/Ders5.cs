namespace MyMauiApp.Pages;

public partial class Ders5 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Image()
                .Source(
                    new UriImageSource()
                    .Uri(new Uri("https://aka.ms/campus.jpg"))
                    .CacheValidity(new TimeSpan(10,10,10))
                )
                .SizeRequest(300),
                //.Aspect(Aspect.AspectFill)

                new Button()
                .Text("Click")
                .OnClicked(async (sender, e) =>
                {
                    await Shell.Current.GoToAsync("..");
                })
            )
        );
    }
}
