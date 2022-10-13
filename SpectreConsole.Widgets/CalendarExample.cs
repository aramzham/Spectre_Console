using System.Globalization;
using Spectre.Console;
using SpectreConsole.Common;
using Calendar = Spectre.Console.Calendar;

namespace SpectreConsole.Widgets;

public class CalendarExample : IExample
{
    public void Start()
    {
        var calendar = new Calendar(2022,10);
        AnsiConsole.Write(calendar);
        AnsiConsole.WriteLine();
        
        var calendar1 = new Calendar(2022,10);
        calendar1.Culture("ru-RU");
        AnsiConsole.Write(calendar1);
        AnsiConsole.WriteLine();
        
        var calendar2 = new Calendar(2022,10);
        calendar2.HideHeader();
        AnsiConsole.Write(calendar2);
        AnsiConsole.WriteLine();
        
        var calendar3 = new Calendar(2022, 10)
        {
            Culture = CultureInfo.GetCultureInfo("hy-AM")
        };
        calendar3.HeaderStyle(Style.Parse("blue bold"));
        calendar3.AddCalendarEvent(2022, 10, 13);
        calendar3.HighlightStyle(Style.Parse("yellow bold"));
        AnsiConsole.Write(calendar3);
        AnsiConsole.WriteLine();
    }
}