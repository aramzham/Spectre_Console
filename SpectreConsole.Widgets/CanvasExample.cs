using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class CanvasExample : IExample
{
    public void Start()
    {
        // Create a canvas
        var canvas = new Canvas(12, 6);

// Draw some shapes
        for(var i = 0; i < canvas.Width; i++)
        {
            // red
            DrawLine(i, 0, canvas.Height / 3, Color.Red3_1, canvas.SetPixel);
            
            // blue
            DrawLine(i, canvas.Height / 3, canvas.Height * 2 / 3, Color.Blue3_1, canvas.SetPixel);
            
            // orange
            DrawLine(i, canvas.Height *  2 / 3, canvas.Height, Color.Orange3, canvas.SetPixel);
        }

// Render the canvas
        AnsiConsole.Write(canvas);
    }

    private void DrawLine(int line, int fromLine, int toLine, Color color, Func<int, int, Color, Canvas> func)
    {
        for (int i = fromLine; i < toLine; i++)
        {
            func(line, i, color);
        }
    }
}