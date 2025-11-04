// See https://aka.ms/new-console-template for more information

using PackagePriceCalculator.Helpers;
using Spectre.Console;

var builder = new WidgetBuilder();
var running = true;

var table = builder.MakeTable();
var layout = builder.MakeLayout();

// Render the table to the console
AnsiConsole.Write(layout);
while (running)
{
}