namespace MyMauiApp.Pages;

public partial class Ders29 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new CardView()
                .CardTitle("My Template")
            )
        );
    }
}

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty =
        BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
    public static readonly BindableProperty CardDescriptionProperty =
        BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }

    public string CardDescription
    {
        get => (string)GetValue(CardDescriptionProperty);
        set => SetValue(CardDescriptionProperty, value);
    }

    public CardView()
    {
        this
        .Content(
            new Frame()
            .CornerRadius(20)
            .BorderColor(LightGray)
            .BackgroundColor(LightGray)
            .BindingContext(this)
            .SizeRequest(350,150)
            .Padding(10)
            .Content(
                new Grid()
                .ColumnDefinitions(e => e.Auto().Star())
                .Children(
                    new Image()
                    .Source("dotnet_bot.png")
                    .SizeRequest(60),

                    new Label()
                    .Text(e => e.Path(nameof(CardTitle)))
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .Column(1)
                    .CenterVertical()
                )
                
            )
        );
    }
}
