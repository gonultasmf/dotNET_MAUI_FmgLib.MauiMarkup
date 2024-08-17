namespace MyMauiApp.Pages;

public partial class Ders3 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Spacing(10)
            .Children(
                new Entry()
                //.Text("deneme 1244")
                .Placeholder("Username")
                .SizeRequest(220, 50)
                .ClearButtonVisibility(ClearButtonVisibility.WhileEditing)
                .IsReadOnly(false)
                .MaxLength(10)
                .Keyboard(Keyboard.Chat)
                .IsTextPredictionEnabled(true)
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
