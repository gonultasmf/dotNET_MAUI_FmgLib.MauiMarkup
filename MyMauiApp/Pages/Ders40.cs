namespace MyMauiApp.Pages;

public class Ders40 : ContentPage, IFmgLibHotReload
{
    public Ders40()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders40")
        .Content(
            new VerticalStackLayout()
            .Spacing(20)
            .Children(
                new MyView()
                .CardTitle("Deneme 1")
                .CardDescription("Deneme açıklama 1")
                .ControlTemplate(template),

                new MyView()
                .CardTitle("Deneme 2")
                .CardDescription("Deneme açıklama 2")
                .ControlTemplate(template)
            )
        );
    }

    ControlTemplate template = new ControlTemplate(() =>
         new Frame()
            .CornerRadius(20)
            .BorderColor(LightGray)
            .BackgroundColor(LightGray)
            .SizeRequest(350, 150)
            .Padding(10)
            .Content(
                new Grid()
                .ColumnDefinitions(e => e.Auto().Star())
                .RowDefinitions(e => e.Star().Star())
                .Children(
                    new Image()
                    .Source("dotnet_bot.png")
                    .SizeRequest(150)
                    .RowSpan(2),

                    new Label()
                    .Text(e => e.Path("CardTitle").Source(RelativeBindingSource.TemplatedParent))
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .Column(1)
                    .CenterVertical(),

                    new Label()
                    .Text(e => e.Path("CardDescription").Source(RelativeBindingSource.TemplatedParent))
                    .FontAttributes(Italic)
                    .FontSize(16)
                    .Column(1)
                    .Row(1)
                    .CenterVertical()
                )

            )
    );
}

public class MyView : ContentView
{
    public static readonly BindableProperty CardTitleProperty =
        BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(MyView), string.Empty);
    public static readonly BindableProperty CardDescriptionProperty =
        BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(MyView), string.Empty);

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
}