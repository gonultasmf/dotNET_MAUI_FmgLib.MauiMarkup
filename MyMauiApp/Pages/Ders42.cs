using System.Diagnostics;

namespace MyMauiApp.Pages;

public class Ders42 : ContentPage, IFmgLibHotReload
{
    Image image;
    public Ders42()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders42")
        .ShellNavBarIsVisible(true)
        .ToolbarItems(
            new ToolbarItem()
            .Text("Add Item")
            .Priority(5)
            .IconImageSource("dotnet_bot.png")
            .OnClicked(async (sender, e) =>
            {
                ToolbarItem item = (ToolbarItem)sender;
                await DisplayAlert("Alert", $"You clicked the \"{item.Text}\" toolbar item.", "OK");
            }),

            new ToolbarItem()
            .Text("Delete Item")
            .Priority(3)
            .OnClicked(async (sender, e) =>
            {
                ToolbarItem item = (ToolbarItem)sender;
                await DisplayAlert("Alert", $"You clicked the \"{item.Text}\" toolbar item.", "OK");
            })
        )
        .Content(
            new VerticalStackLayout()
            .Center()
            .Children(
                new Image()
                .Assign(out image)
                .Source("dotnet_bot.png")
                .SizeRequest(200)
                .ToolTipPropertiesText("Bu bir resimdir.")
                //.OnLoaded(async (sender, e) =>
                //{
                //    await Rotate();
                //})
                ,

                new Button()
                //.Text("Close")
                .Text("Open Popup")
                .ToolTipPropertiesText("Bu bir butondur.")
                .OnClicked(async (sender, e) =>
                {
                    //await DisplayAlert("Alert", "You have been alerted", "OK");

                    //bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
                    //Debug.WriteLine("Answer: " + answer);

                    //string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
                    //Debug.WriteLine("Action: " + action);

                    //string action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
                    //Debug.WriteLine("Action: " + action);

                    string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", placeholder:"10" /*initialValue: "10"*/, maxLength: 2, keyboard: Keyboard.Numeric);
                    Debug.WriteLine("Action: " + result);

                    //await image.RotateTo(360, 2000, Easing.BounceOut);
                    //image.Rotation = 0;
                    //image.CancelAnimations();
                })
            )
        );
    }

    public async Task Rotate()
    {
        //await image.RotateTo(360, 2000,Easing.SpringOut);
        //await image.RelRotateTo(360, 2000);
        //await image.ScaleTo(1, 2000);
        ////await image.RelScaleTo(2, 2000);
        //await image.TranslateTo(-100, 0, 1000);    // Move image left
        //await image.TranslateTo(-100, -100, 1000); // Move image diagonally up and left
        //await image.TranslateTo(100, 100, 2000);   // Move image diagonally down and right
        //await image.TranslateTo(0, 100, 1000);     // Move image left
        //await image.TranslateTo(0, 0, 1000);       // Move image up
        //image.Opacity = 0;
        //await image.FadeTo(1, 4000);
        //image.Rotation = 0;
        //await Task.WhenAny<bool>
        //(
        //  image.RotateTo(360, 4000),
        //  image.ScaleTo(2, 2000)
        //);
        //await image.ScaleTo(1, 2000);
        
        //uint duration = 1 * 30 * 1000;
        //await Task.WhenAll
        //(
        //  image.RotateTo(307 * 360, duration),
        //  image.RotateXTo(251 * 360, duration),
        //  image.RotateYTo(199 * 360, duration)
        //);
    }
}