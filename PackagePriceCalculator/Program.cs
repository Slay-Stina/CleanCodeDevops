// See https://aka.ms/new-console-template for more information

using PackagePriceCalculator.Helpers;
using Spectre.Console;

var builder = new WidgetBuilder();
var running = true;
ConsoleKeyInfo keyInfo;

var table = builder.MakeTable();
var layout = builder.MakeLayout();

// Render the table to the console
AnsiConsole.Write(layout);
while (running)
{
    try
    {
        keyInfo = Console.ReadKey(true);
        ChoosePackageType(keyInfo.Key);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
void ChoosePackageType(ConsoleKey key)
{
    layout["Right"].Visible();
    switch (key)
    {
            
    }
    layout["Right"].Invisible();

}