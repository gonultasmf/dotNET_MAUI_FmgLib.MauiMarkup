namespace MyMauiApp.Pages;

public partial class Ders2 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Title("Ders 2")
        .NavigationPageHasNavigationBar(true)
        .NavigationPageBackButtonTitle("Deneme")
        .IconImageSource("dotnet_bot.png")
        .Content(
            new Button()
            .Text("Click Me")
            .SizeRequest(160,60)
            .BorderWidth(3)
            .BorderColor(Red)
            .CornerRadius(10)
            .TextColor(Red)
            .FontSize(20)
            .FontAttributes(Bold)
            .OnClicked(BtnClicked)
            .VisualStateGroups(new VisualStateGroupList
            {
                new VisualStateGroup()
                .Name("CommonStates")
                .States(
                    new VisualState<Button> (VisualStates.VisualElement.Normal, e => e
                    .TextColor(e => e.OnLight(White).OnDark(AppColors.Primary))
                    .BackgroundColor(e => e.OnLight(AppColors.Primary).OnDark(White))),

                    new VisualState<Button> (VisualStates.VisualElement.Disabled, e => e
                    .TextColor(e => e.OnLight(AppColors.Gray950).OnDark(AppColors.Gray200))
                    .BackgroundColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray600)))
                )
            })
        );
        //NavigationPage.SetHasBackButton(this, true);
    }

    private async void BtnClicked(object sender, EventArgs e)
    {
        var button = sender as Button;
        button.TextColor = Yellow;

        //await Navigation.PushAsync(new Ders3());
        await Shell.Current.GoToAsync($"Ders3?Dene=denemeamacli");
    }
}
