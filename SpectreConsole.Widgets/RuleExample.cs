using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class RuleExample : IExample
{
    public void Start()
    {
        var rule = new Rule();
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
        
        var rule1 = new Rule("[red]Hello[/]");
        AnsiConsole.Write(rule1);
        AnsiConsole.WriteLine();
        
        var rule2 = new Rule("[red]Hello[/]")
        {
            Alignment = Justify.Left
        };
        AnsiConsole.Write(rule2);
        AnsiConsole.WriteLine();
        
        var rule3 = new Rule("[green]Hallo[/]");
        rule3.RightAligned();
        AnsiConsole.Write(rule3);
        AnsiConsole.WriteLine();
        
        var rule4 = new Rule("[red]Hello[/]")
        {
            Style = Style.Parse("red dim")
        };
        AnsiConsole.Write(rule4);
        AnsiConsole.WriteLine();
        
        var rule5 = new Rule("[red]Hello[/]");
        rule5.RuleStyle("red dim");
        AnsiConsole.Write(rule5);
        AnsiConsole.WriteLine();
    }
}