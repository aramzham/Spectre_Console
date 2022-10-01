using Spectre.Console;

try
{
    int a = 1, b = 0;
    var invalidOperation = a / b;
}
catch (DivideByZeroException ex)
{
    AnsiConsole.WriteException(ex);
}

try
{
    throw new Exception("some exception message");
}
catch (Exception ex)
{
    AnsiConsole.WriteException(ex, 
        ExceptionFormats.ShortenPaths | ExceptionFormats.ShortenTypes |
        ExceptionFormats.ShortenMethods | ExceptionFormats.ShowLinks);
}

try
{
    const string? a = (string)null;
    var b = a.Length;
}
catch (NullReferenceException ex)
{
    AnsiConsole.WriteException(ex, new ExceptionSettings
    {
        Format = ExceptionFormats.ShortenEverything | ExceptionFormats.ShowLinks,
        Style = new ExceptionStyle
        {
            Exception = new Style().Foreground(Color.Grey),
            Message = new Style().Foreground(Color.White),
            NonEmphasized = new Style().Foreground(Color.Cornsilk1),
            Parenthesis = new Style().Foreground(Color.Cornsilk1),
            Method = new Style().Foreground(Color.Red),
            ParameterName = new Style().Foreground(Color.Cornsilk1),
            ParameterType = new Style().Foreground(Color.Red),
            Path = new Style().Foreground(Color.Red),
            LineNumber = new Style().Foreground(Color.Cornsilk1),
        }
    });
}