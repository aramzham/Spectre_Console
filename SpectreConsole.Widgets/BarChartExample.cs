using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class BarChartExample : IExample
{
    public void Start()
    {
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItem("Apple", 12, Color.Yellow)
            .AddItem("Orange", 54, Color.Green)
            .AddItem("Banana", 33, Color.Red));
        
        // Create a list of fruits
        var items = new List<(string Label, double Value)>
        {
            ("Apple", 12),
            ("Orange", 54),
            ("Banana", 33),
        };

        // Render bar chart
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItems(items, (item) => new BarChartItem(
                item.Label, item.Value, Color.Yellow)));
        
        // Create a list of fruits
        var fruits = new List<Fruit>
        {
            new("Apple", 12, Color.Yellow),
            new("Orange", 54, Color.Red),
            new("Banana", 33, Color.Green),
        };

        // Render bar chart
        AnsiConsole.Write(new BarChart()
            .Width(60)
            .Label("[green bold underline]Number of fruits[/]")
            .CenterLabel()
            .AddItem(new Fruit("Mango", 3))
            .AddItems(fruits));
    }
}