namespace MyMauiApp.Pages;

public partial class Ders4 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Center()
            .Spacing(10)
            .Children(
                new Editor()
                .Placeholder("Mesajınızı bırakın...")
                .WidthRequest(300)
                .AutoSize(EditorAutoSizeOption.TextChanges)
                //.MaxLength(10)
                .Keyboard(Keyboard.Chat)
                .IsTextPredictionEnabled(true)
                .TextTransform(TextTransform.Lowercase)
                .OnCompleted((sender, e) =>
                {
                    string text = ((Entry)sender).Text;
                })
            )
        );
    }
}

