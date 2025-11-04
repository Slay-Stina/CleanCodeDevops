namespace PackagePriceCalculator.Helpers;

using Spectre.Console;

public class WidgetBuilder
{
    public Layout MakeLayout()
    {
        var layout = new Layout(
            new Panel(new Markup("Hello [blue]World![/]"))
                .Header("Choose package type:")
                .Padding(new Padding(3, 3))
                .Expand());
        return layout;
    }

    public Layout UpdateLayout(Layout layout)
    {
        layout.SplitColumns(
            new Layout("Left"),
            new Layout("Right"));
        return layout;
    }

    public Table MakeTable()
    {
        var table = new Table();
        table.Title = new TableTitle("Choose type");
        // Add some columns
        table.AddColumn("Foo");
        table.AddColumn(new TableColumn("Bar").Centered());

        // Add some rows
        table.AddRow("Baz", "[green]Qux[/]");
        table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));
        table.Expand = true;
        return table;
    }
}