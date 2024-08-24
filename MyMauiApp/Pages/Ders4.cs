namespace MyMauiApp.Pages;

public partial class Ders4 : FmgLibContentPage
{
    public override void Build()
    {
        Shell.SetSearchHandler(this, new AnimalSearchHandler
        {
            Placeholder = "Enter search term",
            ShowsResults = true,
            DisplayMemberName = "Name"
        });

        this
        .Title("Ders4")
        .IconImageSource("dotnet_bot.png")
        .ShellNavBarIsVisible(true)
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

