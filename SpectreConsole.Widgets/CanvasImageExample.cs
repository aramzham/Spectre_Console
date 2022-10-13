using SixLabors.ImageSharp.Processing;
using Spectre.Console;
using SpectreConsole.Common;

namespace SpectreConsole.Widgets;

public class CanvasImageExample : IExample
{
    public void Start()
    {
        AnsiConsole.WriteLine();
        
        // Load an image
        var image = new CanvasImage("cake.png");

// Set the max width of the image.
// If no max width is set, the image will take
// up as much space as there is available.
        image.MaxWidth(32);
        
        // Set a sampler that will be used when scaling the image.
        image.BilinearResampler();

// Mutate the image using ImageSharp
        image.Mutate(ctx => ctx.Grayscale().Rotate(-45).EntropyCrop());

// Render the image to the console
        AnsiConsole.Write(image);
        
        AnsiConsole.WriteLine();
    }
}