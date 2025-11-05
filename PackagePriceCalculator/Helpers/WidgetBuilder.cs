namespace PackagePriceCalculator.Helpers;

using Models;
using Spectre.Console;

public class WidgetBuilder
{
    public static Table table = MakeTable();
    
    public Layout MakeLayout()
    {
        var layout = new Layout("Root")
            .SplitRows
            (
                new Layout("Top"),
                
                new Layout("Bottom",
                    new  Panel(table.Expand())
                        .Header("[blue]Created packages[/]")
                        .Expand()
                )
            );
        
        return layout;
    }

    private static Table MakeTable()
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

    public void UpdateTable(Package package)
    {
        table.AddRow(
            nameof(package),
            package.Price.ToString(),
            package.Width.ToString(),
            package.Height.ToString(),
            package.Volume.ToString(),
            package.Weight.ToString());
    }
}