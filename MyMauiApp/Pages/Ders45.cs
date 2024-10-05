using System.Globalization;

namespace MyMauiApp.Pages;

public class Ders45 : ContentPage, IFmgLibHotReload
{
    public Ders45()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders45")
        .Content(
            new CheckBox()
            .IsChecked(e => e.Bindings(
                    new Binding().Path("Employee.IsOver16"),
                    new Binding().Path("Employee.HasPassedTest"),
                    new Binding().Path("Employee.IsSuspended")
                ).Converter(new AllTrueMultiConverter())
            )
        );
    }
}


public class AllTrueMultiConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values == null || !targetType.IsAssignableFrom(typeof(bool)))
        {
            return false;
            // Alternatively, return BindableProperty.UnsetValue to use the binding FallbackValue
        }

        foreach (var value in values)
        {
            if (!(value is bool b))
            {
                return false;
                // Alternatively, return BindableProperty.UnsetValue to use the binding FallbackValue
            }
            else if (!b)
            {
                return false;
            }
        }
        return true;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        if (!(value is bool b) || targetTypes.Any(t => !t.IsAssignableFrom(typeof(bool))))
        {
            // Return null to indicate conversion back is not possible
            return null;
        }

        if (b)
        {
            return targetTypes.Select(t => (object)true).ToArray();
        }
        else
        {
            // Can't convert back from false because of ambiguity
            return null;
        }
    }
}