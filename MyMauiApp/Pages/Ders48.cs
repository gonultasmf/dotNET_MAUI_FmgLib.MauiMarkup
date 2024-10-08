using System.Globalization;

namespace MyMauiApp.Pages;

public class Ders48 : ContentPage, IFmgLibHotReload
{
    public Ders48()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders48")
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Label()
                .Text(e => e.Translate("Hello"))
                .FontSize(20)
                .Center(),


                new Label()
                .Text(e => e.Translate("Msg"))
                .FontSize(18)
                .Center(),

                new Button()
                .Text(e => e.Translate("Change"))
                .OnClicked( async (s, e) =>
                {
                    var culture = Translator.Instance.CurrentCulture == CultureInfo.GetCultureInfo("tr-TR") ?
                        CultureInfo.GetCultureInfo("en-US") : CultureInfo.GetCultureInfo("tr-TR");
                    Preferences.Default.Set("defaultLang", culture.Name);
                    Translator.Instance.ChangeCulture(culture);

                    await SecureStorage.Default.SetAsync("oauth_token", "secret-oauth-token-value");
                    string oauthToken = await SecureStorage.Default.GetAsync("oauth_token");
                    bool success = SecureStorage.Default.Remove("oauth_token");
                    SecureStorage.Default.RemoveAll();
                })
            )
        );
    }
}