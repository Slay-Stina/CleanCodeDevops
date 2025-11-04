namespace PackagePriceCalculator.Helpers;

using Spectre.Console;

public class WidgetBuilder
{
    public Layout MakeLayout()
    {
        var layout = new Layout("Root")
            .SplitRows
            (
                new Layout("Top")
                    .SplitColumns
                    (
                        new Layout
                        ("Left",
                    new Panel(new Markup("Hello [blue]World![/]"))
                                .Header("Choose package type")
                                .Expand()
                        ),
                        new Layout("Right").Invisible()
                    ),
                
                new Layout("Bottom",
                    new  Panel(
                    MakeTable().Expand())
                        .Header("[blue]Created packages[/]")
                        .Expand()
                )
            );
        return layout;
    }

    public Table MakeTable()
    {
        var table = new Table();
        // Add some columns
        table.AddColumns(
            "Type",
            "Price",
            "Width",
            "Height",
            "Volume",
            "Weight");

        return table;
    }
}