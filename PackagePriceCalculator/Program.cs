// See https://aka.ms/new-console-template for more information

using PackagePriceCalculator.Helpers;
using PackagePriceCalculator.Models;
using Spectre.Console;

var builder = new WidgetBuilder();

List<Package> Packages = new List<Package>();
var layout = builder.MakeLayout();

// Render the table to the console
//AnsiConsole.Write(layout);
AnsiConsole.Cursor.SetPosition(0,10);
AnsiConsole.Write(WidgetBuilder.table);
AnsiConsole.Cursor.SetPosition(0,0);
while (true)
{
    try
    {
        var newPackage = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a [green]package[/]?")
            .AddChoices(new [] {
                "Square", "Pipe",
            }));
        ChoosePackageType(newPackage);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    
}
void ChoosePackageType(string newPackage)
{
    var rule = new Rule($"[red]New {newPackage}[/]");
    rule.Justification = Justify.Left;
    AnsiConsole.Write(rule);
    
    Package? package = null;
    
    switch (newPackage)
    {
        case "Square":
            package = new Square();
            break;
        case "Pipe":
            package = new Pipe();
            break;
    }

    if (package != null)
    {
        Packages.Add(package);
        builder.UpdateTable(package);
    }
}