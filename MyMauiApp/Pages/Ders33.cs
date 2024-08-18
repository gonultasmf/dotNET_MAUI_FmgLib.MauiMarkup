using Microsoft.Maui.Layouts;

namespace MyMauiApp.Pages;

public partial class Ders33 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new FlexLayout()
            .Direction(FlexDirection.Row)
            .JustifyContent(FlexJustify.Start)
            .AlignItems(FlexAlignItems.Stretch)
            .Wrap(FlexWrap.Wrap)
            //.Position(FlexPosition.Absolute)
            .AlignContent(FlexAlignContent.Start)
            .Children(
                new Label()
                .Text("1. Label")
                .FontSize(30)
                .FlexOrder(5),

                new Label()
                .Text("2. Label")
                .FontSize(30)
                .FlexGrow(0)
                .FlexOrder(4),

                new Image()
                .Source("dotnet_bot.png")
                .FlexAlignSelf(FlexAlignSelf.End)
                .FlexShrink(0.5f)
                .FlexOrder(3),

                new Label()
                .Text("4. Label")
                .FontSize(30)
                .FlexBasis(new FlexBasis(0.25f, true))
                .FlexOrder(2),

                new Button()
                .Text("5. Button")
                .FlexAlignSelf(FlexAlignSelf.Stretch)
                .FlexShrink(0)
                .FlexOrder(1)
            )
        );
    }
}
