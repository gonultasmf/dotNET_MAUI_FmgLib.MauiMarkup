﻿using System.Diagnostics;

namespace MyMauiApp.Pages;

public class Ders46 : ContentPage, IFmgLibHotReload
{
    public Ders46()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders46")
        .Content(
            //new VerticalStackLayout()
            //.Center()
            //.Children(
                //new Label()
                //.Text("Welcome to .NET MAUI!")
                //.Center()
                //.GestureRecognizers(
                //    new TapGestureRecognizer()
                //    .Buttons(ButtonsMask.Secondary)
                //    .OnTapped(async (s,e) =>
                //    {
                //        await DisplayAlert("Tıklandı", "TapGestureRecognizer ile tıklandı.", "OK");
                //    })
                //    //.Command(new Command(async () =>
                //    //{
                //    //    await DisplayAlert("Tıklandı", "TapGestureRecognizer ile tıklandı.", "OK");
                //    //}))
                //),

                //new PinchToZoomContainer()
                //.Content(
                //    new Image()
                //    .Source("dotnet_bot.png")
                //),

                //new BoxView()
                //.Assign(out var boxView)
                //.SizeRequest(75)
                //.Color(Green)
                //.GestureRecognizers(
                //    new SwipeGestureRecognizer()
                //    .Direction(Left | Right)
                //    .OnSwiped((s, e) =>
                //    {
                //        Debug.WriteLine(e.Direction);
                //    })
                //),

                new AbsoluteLayout()
                .Children(
                    new PanContainer()
                    .Content(
                        new Image()
                        .Source("dotnet_bot.png")
                        .SizeRequest(400,300)
                    )
                )
            //)
        );
    }
}

public class PanContainer : ContentView
{
    double panX, panY;

    public PanContainer()
    {
        // Set PanGestureRecognizer.TouchPoints to control the
        // number of touch points needed to pan
        this.GestureRecognizers(
            new PanGestureRecognizer()
            .OnPanUpdated(OnPanUpdated)
        );
    }

    void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Running:
                // Translate and pan.
                double boundsX = Content.Width;
                double boundsY = Content.Height;
                Content.TranslationX = Math.Clamp(panX + e.TotalX, -boundsX, boundsX);
                Content.TranslationY = Math.Clamp(panY + e.TotalY, -boundsY, boundsY);
                break;

            case GestureStatus.Completed:
                // Store the translation applied during the pan
                panX = Content.TranslationX;
                panY = Content.TranslationY;
                break;
        }
    }
}

public class PinchToZoomContainer : ContentView
{
    double currentScale = 1;
    double startScale = 1;
    double xOffset = 0;
    double yOffset = 0;

    public PinchToZoomContainer()
    {
        this.GestureRecognizers(
            new PinchGestureRecognizer().OnPinchUpdated(OnPinchUpdated)
        );
    }

    void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        if (e.Status == GestureStatus.Started)
        {
            // Store the current scale factor applied to the wrapped user interface element,
            // and zero the components for the center point of the translate transform.
            startScale = Content.Scale;
            Content.AnchorX = 0;
            Content.AnchorY = 0;
        }
        if (e.Status == GestureStatus.Running)
        {
            // Calculate the scale factor to be applied.
            currentScale += (e.Scale - 1) * startScale;
            currentScale = Math.Max(1, currentScale);

            // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
            // so get the X pixel coordinate.
            double renderedX = Content.X + xOffset;
            double deltaX = renderedX / Width;
            double deltaWidth = Width / (Content.Width * startScale);
            double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

            // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
            // so get the Y pixel coordinate.
            double renderedY = Content.Y + yOffset;
            double deltaY = renderedY / Height;
            double deltaHeight = Height / (Content.Height * startScale);
            double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

            // Calculate the transformed element pixel coordinates.
            double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
            double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);

            // Apply translation based on the change in origin.
            Content.TranslationX = Math.Clamp(targetX, -Content.Width * (currentScale - 1), 0);
            Content.TranslationY = Math.Clamp(targetY, -Content.Height * (currentScale - 1), 0);

            // Apply scale factor
            Content.Scale = currentScale;
        }
        if (e.Status == GestureStatus.Completed)
        {
            // Store the translation delta's of the wrapped user interface element.
            xOffset = Content.TranslationX;
            yOffset = Content.TranslationY;
        }
    }
}