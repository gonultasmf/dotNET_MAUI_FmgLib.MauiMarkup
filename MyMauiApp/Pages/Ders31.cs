namespace MyMauiApp.Pages;

public partial class Ders31 : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Margin(10)
            .Spacing(10)
            .Center()
            .Children(
                new HorizontalStackLayout()
                .Spacing(10)
                .FillHorizontal()
                .Children(
                    new Label().Text("Username:").AlignCenterLeft(),
                    new Entry()
                    .Placeholder("Kullanıcı adınız.")
                    .WidthRequest(250)
                    .FillHorizontal()
                ),

                new HorizontalStackLayout()
                .Spacing(10)
                .FillHorizontal()
                .Children(
                    new Label().Text("Password:").AlignCenterLeft(),
                    new Entry()
                    .Placeholder("Şifreniz.")
                    .IsPassword(true)
                    .WidthRequest(250)
                    .FillHorizontal()
                ),

                new Button()
                .Center()
                .Text("LOGIN")
                .SizeRequest(200,50)
            )
        );
    }
}
