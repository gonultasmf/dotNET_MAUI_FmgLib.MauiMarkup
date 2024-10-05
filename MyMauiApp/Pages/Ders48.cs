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
                .OnClicked((s, e) =>
                {
                    var culture = Translator.Instance.CurrentCulture == CultureInfo.GetCultureInfo("tr-TR") ?
                        CultureInfo.GetCultureInfo("en-US") : CultureInfo.GetCultureInfo("tr-TR");
                    Translator.Instance.ChangeCulture(culture);
                })
            )
        );
    }
}