using Spectre.Console;

namespace SpectreConsole.Widgets;

public sealed class Fruit : IBarChartItem
{
    public string Label { get; set; }
    public double Value { get; set; }
    public Color? Color { get; set; }

    public Fruit(string label, double value, Color? color = null)
    {
        Label = label;
        Value = value;
        Color = color;
    }
}