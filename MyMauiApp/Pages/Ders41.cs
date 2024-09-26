using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace MyMauiApp.Pages;

public class Ders41 : ContentPage, IFmgLibHotReload
{
    public Ders41()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders41")
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .BackgroundColor(Pink)
                .Padding(10)
                .Center()
                .Children(
                    new Line()
                    .X1(0)
                    .X2(130)
                    .Y1(0)
                    .Y2(130)
                    .Stroke(Blue)
                    .StrokeThickness(5)
                    .StrokeDashArray(1, 1),

                    new Rectangle()
                    .Fill(Blue)
                    .Stroke(Red)
                    .StrokeThickness(3)
                    .RadiusX(50)
                    .RadiusY(10)
                    .SizeRequest(200, 100),

                    new Ellipse()
                    .Fill(Green)
                    .Stroke(Purple)
                    .StrokeThickness(7)
                    .SizeRequest(200, 150),

                    new Polygon()
                    .Fill(Black)
                    .Stroke(Yellow)
                    .StrokeThickness(3)
                    .FillRule(FillRule.Nonzero)
                    .Points(
                        new Point(0, 48),
                        new Point(0, 144),
                        new Point(96, 150),
                        new Point(100, 0),
                        new Point(192, 0),
                        new Point(192, 96),
                        new Point(50, 96),
                        new Point(48, 192),
                        new Point(150, 200),
                        new Point(144, 48)
                    ),

                    new Polyline()
                    .Fill(Black)
                    .Stroke(Yellow)
                    .StrokeThickness(3)
                    .FillRule(FillRule.Nonzero)
                    .Points(
                        new Point(0, 48),
                        new Point(0, 144),
                        new Point(96, 150),
                        new Point(100, 0),
                        new Point(192, 0),
                        new Point(192, 96),
                        new Point(50, 96),
                        new Point(48, 192),
                        new Point(150, 200),
                        new Point(144, 48)
                    ),

                    new Path()
                    .Stroke(Black)
                    .StrokeThickness(5)
                    .Aspect(Stretch.UniformToFill)
                    .AlignLeft()
                    .Data((Geometry)new PathGeometryConverter().ConvertFromInvariantString("M 10,100 L 100,100 100,50Z"))
                    //.Data(
                    //    new PathGeometry().Figures(
                    //        new PathFigure()
                    //        .IsClosed(true)
                    //        .StartPoint(10,100)
                    //        .Segments(
                    //            new LineSegment(new Point(100,100)),
                    //            new LineSegment(new Point(100,50))

                    //        )
                    //    )
                    //)
                )
            )
        );
    }
}
/*
<Path Stroke="Black"
      Aspect="Uniform"
      HorizontalOptions="Start">
    <Path.Data>
        <PathGeometry>
            <PathGeometry.Figures>
                <PathFigureCollection>
                    <PathFigure IsClosed="True"
                                StartPoint="10,100">
                        <PathFigure.Segments>
                            <PathSegmentCollection>
                                <LineSegment Point="100,100" />
                                <LineSegment Point="100,50" />
                            </PathSegmentCollection>
                        </PathFigure.Segments>
                    </PathFigure>
                </PathFigureCollection>
            </PathGeometry.Figures>
        </PathGeometry>
    </Path.Data>
</Path>
 
 */