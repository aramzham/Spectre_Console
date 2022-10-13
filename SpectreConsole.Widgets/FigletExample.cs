using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class FigletExample : IExample
{
    public void Start()
    {
        AnsiConsole.Write(new FigletText("Արծիվ, սլացիր Տաճկա Հայաստան").LeftAligned().Color(Color.Cyan3));
        AnsiConsole.WriteLine();

        var font = FigletFont.Load("starwars.flf");

        AnsiConsole.Write(new FigletText(font, "hello").RightAligned().Color(Color.Red3_1));
    }
}