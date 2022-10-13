using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class BreakdownChartExample : IExample
{
    public void Start()
    {
        AnsiConsole.Write(new BreakdownChart()
            .Width(60)
            // Add item is in the order of label, value, then color.
            .AddItem("CSS", 5.38, Color.Violet)
            .AddItem("HTML", 22.01, Color.Red1)
            .AddItem("C#", 47.54, Color.Green)
            .AddItem("JavaScript", 23.76, Color.Yellow)
            .AddItem("SCSS", 1.3, Color.HotPink));
        AnsiConsole.WriteLine();

        // Render chart at full width of console.
        AnsiConsole.Write(new BreakdownChart()
            .FullSize()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
        // Show percentage signs after the values in the chart.
        AnsiConsole.Write(new BreakdownChart()
            .ShowPercentage()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
        // Hide the values next to the tag from displaying in the chart.
        AnsiConsole.Write(new BreakdownChart()
            .HideTagValues()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
        // Render chart at full width of console.
        AnsiConsole.Write(new BreakdownChart()
            .FullSize()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
        // Show percentage signs after the values in the chart.
        AnsiConsole.Write(new BreakdownChart()
            .ShowPercentage()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
// Hide tags displaying in the chart altogether.
        AnsiConsole.Write(new BreakdownChart()
            .HideTags()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
        AnsiConsole.WriteLine();
        
// Hide the values next to the tag from displaying in the chart.
        AnsiConsole.Write(new BreakdownChart()
            .HideTagValues()
            .AddItem("SCSS", 80, Color.Red)
            .AddItem("HTML", 28.3, Color.Blue)
            .AddItem("C#", 22.6, Color.Green)
            .AddItem("JavaScript", 6, Color.Yellow)
            .AddItem("Ruby", 6, Color.LightGreen)
            .AddItem("Shell", 0.1, Color.Aqua));
    }
}