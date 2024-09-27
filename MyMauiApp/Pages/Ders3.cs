
using System.Web;

namespace MyMauiApp.Pages;

[QueryProperty(nameof(Dene), "Dene")]
public partial class Ders3 : FmgLibContentPage, IQueryAttributable
{
    public string Dene { get; set; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Dene = HttpUtility.HtmlDecode(query["Dene"].ToString());
    }

    public override void Build()
    {
        this
        .Title("Ders3")
        .NavigationPageBackButtonTitle("deneme")
        .IconImageSource("dotnet_bot.png")
        .ShellNavBarIsVisible(true)
        .Content(
            new VerticalStackLayout()
            .Center()
            .Spacing(10)
            .Children(
                new Entry()
                //.Text(Dene)
                .Placeholder("Username")
                .SizeRequest(220, 50)
                .ClearButtonVisibility(ClearButtonVisibility.WhileEditing)
                .IsReadOnly(false)
                .MaxLength(10)
                .Keyboard(Keyboard.Chat)
                .IsTextPredictionEnabled(true)
                .AttachedNumericValidationBehaviorAttachBehavior(true)
                //.SelectionLength(4)
                .TextTransform(TextTransform.Lowercase)
                
                .OnCompleted((sender, e) =>
                {
                    string text = ((Entry)sender).Text;
                }),

                new Entry()
                .Placeholder("Password")
                .SizeRequest(220, 50)
                .IsPassword(true)
                .ClearButtonVisibility(ClearButtonVisibility.WhileEditing)
            )
        );
    }
}

public static class AttachedNumericValidationBehavior
{
    public static readonly BindableProperty AttachBehaviorProperty =
        BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(AttachedNumericValidationBehavior), false, propertyChanged: OnAttachBehaviorChanged);

    public static bool GetAttachBehavior(BindableObject view)
    {
        return (bool)view.GetValue(AttachBehaviorProperty);
    }

    public static void SetAttachBehavior(BindableObject view, bool value)
    {
        view.SetValue(AttachBehaviorProperty, value);
    }

    static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
    {
        Entry entry = view as Entry;
        if (entry == null)
        {
            return;
        }

        bool attachBehavior = (bool)newValue;
        if (attachBehavior)
        {
            entry.TextChanged += OnEntryTextChanged;
        }
        else
        {
            entry.TextChanged -= OnEntryTextChanged;
        }
    }

    static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
    {
        double result;
        bool isValid = double.TryParse(args.NewTextValue, out result);
        ((Entry)sender).TextColor = isValid ? Green : Red;
    }
    
}
