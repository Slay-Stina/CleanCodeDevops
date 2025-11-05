// See https://aka.ms/new-console-template for more information

using PackagePriceCalculator.Helpers;
using PackagePriceCalculator.Models;
using Spectre.Console;

var builder = new WidgetBuilder();
builder.MakeLayout();

AnsiConsole.Cursor.SetPosition(0,11);
AnsiConsole.Write(WidgetBuilder.Table);
AnsiConsole.Cursor.SetPosition(0,0);

List<Package> Packages = new List<Package>();

while (true)
{
    try
    {
        var newPackage = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Select a [green]package[/]:")
            .AddChoices(new [] {
                "Square", "Pipe",
            }));
        ChoosePackageType(newPackage);
    }
    catch (Exception e)
    {
        AnsiConsole.WriteLine();
        var error = new Panel($"[red]{e.Message}[/]")
        {
            Header = new PanelHeader("Error"),
            BorderStyle = new Style(Color.Red),
            Padding = new Padding(1),
        };
        AnsiConsole.Write(error);
        Task.Delay(2000).Wait();
        AnsiConsole.Clear();

    }

    AnsiConsole.Cursor.SetPosition(0,11);
    AnsiConsole.Write(WidgetBuilder.Table);
    AnsiConsole.Cursor.SetPosition(0,0);
}
void ChoosePackageType(string newPackage)
{
    var rule = new Rule($"[red]New {newPackage}[/]")
    { Justification = Justify.Left };
    AnsiConsole.Write(rule);

    Package? package = newPackage switch
    {
        "Square" => new Square(),
        "Pipe" => new Pipe(),
        _ => null
    };

    if (package != null)
    {
        Packages.Add(package);
        WidgetBuilder.UpdateTable(package);
    }
    AnsiConsole.Clear();
}