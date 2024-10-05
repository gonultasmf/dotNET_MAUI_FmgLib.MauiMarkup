namespace MyMauiApp.Pages;

public class Ders47 : ContentPage, IFmgLibHotReload
{
    private Switch testSwitch;
    public Ders47()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Ders47")
        //.Resources(new ResourceDictionary
        //{
        //    new Style<Entry>(e => e
        //        .BackgroundColor(Pink)
        //        .TextColor(Purple))
        //    {
        //        new Trigger(typeof(Entry))
        //            .Property(Entry.IsFocusedProperty)
        //            .Value(true)
        //            .Setters(
        //                new Setters<Entry>(e => e
        //                    .BackgroundColor(Yellow)
        //                    .TextColor(Green))
        //            )
        //    }
        //})
        .Content(
            //new VerticalStackLayout()
            //.Center()
            //.Children(
            //    new Entry()
            //    .Assign(out var entryUser)
            //    .Placeholder("Username")
            //    //.Triggers(
            //    //    new Trigger(typeof(Entry))
            //    //    .Property(Entry.IsFocusedProperty)
            //    //    .Value(true)
            //    //    .Setters(
            //    //        new Setters<Entry>(e => e
            //    //            .BackgroundColor(Yellow)
            //    //            .TextColor(Green))
            //    //    )
            //    //)
            //    //.Triggers(
            //    //    new EventTrigger()
            //    //    .Event("TextChanged")
            //    //    .Actions(new NumericValidationTriggerAction())
            //    //)
            //    ,

            //    new Entry()
            //    .Assign(out var entry)
            //    .Placeholder("Password")
            //    .Triggers(
            //        new Trigger(typeof(Entry))
            //        .Property(Entry.IsFocusedProperty)
            //        .Value(true)
            //        .EnterActions(new FadeTriggerAction(0))
            //        .ExitActions(new FadeTriggerAction(1))
            //    ),

            //    new Button()
            //    .Text("SAVE")
            //    //.Triggers(
            //    //    new DataTrigger(typeof(Button))
            //    //    .Binding(e => e.Path("Text.Length").Source(entry))
            //    //    .Value(0)
            //    //    .Setters(new Setters<Button>(e => e.IsEnabled(false)))
            //    //)
            //    //.Triggers(
            //    //    new MultiTrigger(typeof(Button))
            //    //    .Conditions(
            //    //        new BindingCondition()
            //    //        .Binding(e => e.Path("Text.Length").Source(entry))
            //    //        .Value(0),

            //    //        new BindingCondition()
            //    //        .Binding(e => e.Path("Text.Length").Source(entryUser))
            //    //        .Value(0)
            //    //    )
            //    //    .Setters(new Setters<Entry>(e => e.IsEnabled(false)))
            //    //)
            //)
            //new Grid()
            //.Children(
            //    new Switch()
            //    .Center()
            //    .Assign(out testSwitch)
            //)
            //.Style(
            //    new Style<Grid>
            //    {
            //        new VisualState<Grid>(e => e.BackgroundColor(Red))
            //        {
            //            //async e => {
            //            //    await e.AnimateBackgroundColorTo(Colors.Blue, 1000);
            //            //},

            //            //new StateTrigger()
            //            //    .IsActive(e => e.Path("IsToggled").Source(testSwitch))
            //            //    .OnIsActiveChanged(OnCheckedStateIsActiveChanged)
            //            new CompareStateTrigger()
            //            .Property(e => e.Path("IsToggled").Source(testSwitch))
            //            .Value(true)
            //        },

            //        new VisualState<Grid>(e => e.BackgroundColor(Green))
            //        {
            //            //async e => {
            //            //    await e.AnimateBackgroundColorTo(Colors.Yellow, 300);
            //            //},

            //            //new StateTrigger()
            //            //    .IsActive(e => e.Path("IsToggled").Source(testSwitch).Negate())
            //            //    .OnIsActiveChanged(OnUncheckedStateIsActiveChanged)

            //            new CompareStateTrigger()
            //            .Property(e => e.Path("IsToggled").Source(testSwitch))
            //            .Value(false)
            //        },
            //    }
            //)

            new VerticalStackLayout()
            .Center()
            .Children(
                new Label().Text("Change orientation").FontSize(40)
            )
            .Style(
                new Style<VerticalStackLayout>
                {
                    new VisualState<VerticalStackLayout>(e => e.BackgroundColor(Blue))
                    {
                        new OrientationStateTrigger().Orientation(DisplayOrientation.Portrait)
                    },

                    new VisualState<VerticalStackLayout>(e => e.BackgroundColor(Red))
                    {
                        new OrientationStateTrigger().Orientation(DisplayOrientation.Landscape)
                    }
                }
            )
        );
    }

    void OnCheckedStateIsActiveChanged(StateTrigger sender)
    {
        System.Diagnostics.Debug.WriteLine($"Checked state active: {sender.IsActive}");
    }

    void OnUncheckedStateIsActiveChanged(StateTrigger sender)
    {
        System.Diagnostics.Debug.WriteLine($"Unchecked state active: {sender.IsActive}");
    }
}

public class FadeTriggerAction : TriggerAction<VisualElement>
{
    public int StartsFrom { get; set; }

    public FadeTriggerAction(int startsFrom)
    {
        StartsFrom = startsFrom;
    }

    protected override void Invoke(VisualElement sender)
    {
        sender.Animate("FadeTriggerAction", new Animation((d) =>
        {
            var val = StartsFrom == 1 ? d : 1 - d;
            sender.BackgroundColor = Color.FromRgb(1, val, 1);
        }),
        length: 1000, // milliseconds
        easing: Easing.Linear);
    }
}

public class NumericValidationTriggerAction : TriggerAction<Entry>
{
    protected override void Invoke(Entry entry)
    {
        double result;
        bool isValid = Double.TryParse(entry.Text, out result);
        entry.TextColor = isValid ? Colors.Green : Colors.Red;
    }
}