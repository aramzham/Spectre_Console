using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class TextPathExample : IExample
{
    public void Start()
    {
        var path = new TextPath("C:/This/Path/Is/Too/Long/To/Fit/In/The/Area.txt");

        AnsiConsole.Write(path);
        
        // alignment
        var path1 = new TextPath("C:/This/Path/Is/Too/Long/To/Fit/In/The/Area.txt");
        path1.Alignment = Justify.Right;

        AnsiConsole.Write(path1);

        AnsiConsole.WriteLine();
        
        // styling
        var path2 = new TextPath("C:/This/Path/Is/Too/Long/To/Fit/In/The/Area.txt");

        path2.RightAligned();
        path2.RootStyle = new Style(foreground: Color.Red);
        path2.SeparatorStyle = new Style(foreground: Color.Green);
        path2.StemStyle = new Style(foreground: Color.Blue);
        path2.LeafStyle = new Style(foreground: Color.Yellow);
        
        AnsiConsole.Write(path2);

        AnsiConsole.WriteLine();
        
        // the same may be achieved via extension methods
        // var path = new TextPath("C:/This/Path/Is/Too/Long/To/Fit/In/The/Area.txt")
        //     .RootStyle(new Style(foreground: Color.Red))
        //     .SeparatorStyle(new Style(foreground: Color.Green))
        //     .StemStyle(new Style(foreground: Color.Blue))
        //     .LeafStyle(new Style(foreground: Color.Yellow));
        //
        // var path = new TextPath("C:/This/Path/Is/Too/Long/To/Fit/In/The/Area.txt")
        //     .RootColor(Color.Red)
        //     .SeparatorColor(Color.Green)
        //     .StemColor(Color.Blue)
        //     .LeafColor(Color.Yellow);
    }
}