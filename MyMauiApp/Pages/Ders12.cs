namespace MyMauiApp.Pages;

public partial class Ders12 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new SearchBar()
                .Placeholder("Arama yap.")
                .CancelButtonColor(Red)
                .OnSearchButtonPressed(async (sender, e) =>
                {
                    var searchBar = sender as SearchBar;
                    var temp = searchBar.Text;

                    if (searchBar.IsSoftInputShowing())
                        await searchBar.HideSoftInputAsync(System.Threading.CancellationToken.None);
                })
            )
        );
    }
}
