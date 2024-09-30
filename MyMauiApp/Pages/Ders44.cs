using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace MyMauiApp.Pages;

public class Ders44 : ContentPage, IFmgLibHotReload
{
    public Ders44()
    {
        this.InitializeHotReload();
    }
    Slider slider;
    public void Build()
    {
        this
        .BindingContext(new HslColorViewModel())
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star(count:2))
            .FillBothDirections()
        //.Children(
        //    new BoxView()
        //    .Color(e => e.Path("Color"))
        //    .CenterHorizontal()
        //    .WidthRequest(300)
        //    .HeightRequest(e => e.Path("WidthRequest").Source(new RelativeBindingSource(RelativeBindingSourceMode.Self, typeof(HslColorViewModel)))),

        //    new VerticalStackLayout()
        //    .Row(1)
        //    .Children(
        //        new Label()
        //        .CenterHorizontal()
        //        .IsEnabled(e => e.Path("Name")/*.Convert((int param) => param != 0).ConvertBack((bool param) => param ? 1 : 0)*/)
        //        .Text(e => e.Path("Name")/*.Converter(new IntToBoolConverter())*/),

        //        new Slider()
        //        .CenterVertical()
        //        .Value(e => e.Path("Hue")),

        //        new Slider()
        //        .CenterVertical()
        //        .Value(e => e.Path("Saturation")),

        //        new Slider()
        //        .CenterVertical()
        //        .Value(e => e.Path("Luminosity"))
        //    )
        //)
        .Children(
            new VerticalStackLayout()
            .BindableLayoutItemsSource(e => e.Path("Dizi"))
            .Row(1)
            .BindableLayoutItemTemplate(new DataTemplate(() =>
                new Label()
                .CenterHorizontal()
                .TextColor(Red)
                .Text(e => e.Path("."))
            )),

            new Button()
            .Row(1)
            .Text("Tıkla")
            .Command(e => e.Path("GetCommand"))
            .CommandParameter("deneme")
        )
        /*
        //.Children(
        //    (IView)new VerticalStackLayout()
        //    .BindableLayoutItemsSource(e => e.Path("Dizi"))
        //    .Row(1)
        //    .BindableLayoutItemTemplate(new DataTemplate(() =>
        //        new Label()
        //        .CenterHorizontal()
        //        .Text(e => e.Path("."))
        //    ))
        //)
    //.Children(
    //    new Slider()
    //    .Row(1)
    //    .Assign(out slider)
    //    .CenterVertical()
    //    .Maximum(360),

    //    new Label()
    //    //.BindingContext(slider)
    //    .Text("ROTATING TEXT")
    //    .Rotation(e => e.Path(nameof(Slider.Value)).Source(slider).BindingMode(BindingMode.TwoWay))
    //    .AlignTopCenter()
    //    .Margin(50)
    //    .FontSize(18),

    //    new Label()
    //    .Row(2)
    //    //.BindingContext(slider)
    //    .Text(e => e.Path("Value").Source(slider).StringFormat("The Slider value is {0}").BindingMode(BindingMode.OneWayToSource))
    //    .AlignBottomCenter()
    //)
    //.Children(
    //    new Label()
    //    .Assign(out var label)
    //    .Text("ROTATING TEXT")
    //    .AlignTopCenter()
    //    .Margin(50)
    //    .FontSize(18),

    //    new Slider()
    //    .Row(1)
    //    .Assign(out slider)
    //    .Value(e => e.Path(nameof(Label.Opacity)).Source(label))
    //    .CenterVertical()
    //    .Maximum(1)
    //    .Minimum(0),

    //    new Label()
    //    .Row(2)
    //    //.BindingContext(slider)
    //    .Text(e => e.Path("Value").Source(slider).StringFormat("The Slider value is {0}"))
    //    .AlignBottomCenter()
    //)
        */
        );
    }
}

public class IntToBoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int)value != 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? 1 : 0;
    }
}

public class HslColorViewModel : INotifyPropertyChanged
{
    Color color;
    string name;
    float hue;
    float saturation;
    float luminosity;
    List<string> dizi = new List<string>();

    public event PropertyChangedEventHandler PropertyChanged;

    public ICommand GetCommand => new Command<string>((parameter) =>
    {
        Dizi = ["123", "456", "789", "2142"];
    });

    public List<string> Dizi
    {
        get => dizi ??= new List<string>();
        set
        {
            if(dizi != value)
            {
                dizi = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dizi"));
            }
        }
    }

    public float Hue
    {
        get
        {
            return hue;
        }
        set
        {
            if (hue != value)
            {
                Color = Color.FromHsla(value, saturation, luminosity);
            }
        }
    }

    public float Saturation
    {
        get
        {
            return saturation;
        }
        set
        {
            if (saturation != value)
            {
                Color = Color.FromHsla(hue, value, luminosity);
            }
        }
    }

    public float Luminosity
    {
        get
        {
            return luminosity;
        }
        set
        {
            if (luminosity != value)
            {
                Color = Color.FromHsla(hue, saturation, value);
            }
        }
    }

    public Color Color
    {
        get
        {
            return color;
        }
        set
        {
            if (color != value)
            {
                color = value;
                hue = color.GetHue();
                saturation = color.GetSaturation();
                luminosity = color.GetLuminosity();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saturation"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Luminosity"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));

                Name = color.ToString();
            }
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (name != value)
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
    }
}