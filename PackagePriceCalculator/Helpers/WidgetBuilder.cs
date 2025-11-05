namespace PackagePriceCalculator.Helpers;

using Models;
using Spectre.Console;

public class WidgetBuilder
{
    public static readonly Table Table = MakeTable();
    
    public Layout MakeLayout()
    {
        var layout = new Layout("Root")
            .SplitRows(new Layout("Top"),
                new Layout("Bottom",
                    new  Panel(Table.Expand())
                        .Header("[blue]Created packages[/]")
                        .Expand()));
        return layout;
    }

    private static Table MakeTable()
    {
        var table = new Table();
        // Add some columns
        table.AddColumns(
            "Type",
            "Width (cm)",
            "Height (cm)",
            "Volume (cm²)",
            "Weight (kg)",
            "Price (kr)");
        return table;
    }

    public static void UpdateTable(Package newPackage)
    {
        Table.AddRow(
            newPackage.GetType().Name,
            newPackage.Width.ToString(),
            newPackage.Height.ToString(),
            newPackage.Volume.ToString(),
            newPackage.Weight.ToString(),
            newPackage.Price.ToString());
    }
}