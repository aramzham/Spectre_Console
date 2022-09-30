using Spectre.Console;

AnsiConsole.Markup("[underline red]Hello[/] World!");

AnsiConsole.WriteLine();

AnsiConsole.Write(new Markup("[bold yellow]Hello[/] [red]World![/]"));

AnsiConsole.WriteLine();

var table = new Table();
table.AddColumn(new TableColumn(new Markup("[yellow]#[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]Country[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]MP[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]W[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]D[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]L[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]G[/]")));
table.AddColumn(new TableColumn(new Markup("[blue]PTS[/]")));
table.AddRow(new TableRow(new Markup[]{new("[green]1[/]"), new("[green]Scotland[/]"), new("[green]6[/]"), new("[green]4[/]"), new("[green]1[/]"), new("[green]1[/]"), new("[green]11:5[/]"), new("[green]13[/]")}));
table.AddRow(new TableRow(new Markup[]{new("2"), new("Ukraine") , new("6"), new("3"), new("2"), new("1"), new("10:4"), new("11")}));
table.AddRow(new TableRow(new Markup[]{new("3"), new("Ireland") , new("6"), new("2"), new("1"), new("3"), new("8:7"), new("7")}));
table.AddRow(new TableRow(new Markup[]{new("[red]4[/]"), new("[red]Armenia[/]") , new("[red]6[/]"), new("[red]1[/]"), new("[red]0[/]"), new("[red]5[/]"), new("[red]4:17[/]"), new("[red]3[/]")}));
AnsiConsole.Write(table);

AnsiConsole.WriteLine();

// convenience methods
AnsiConsole.Markup("[underline green]Hello[/] ");
AnsiConsole.MarkupLine("[bold]World[/]");

// escaping format characters
AnsiConsole.Markup("[[Hello]] ");
AnsiConsole.MarkupLine("[red][[World]][/]");

AnsiConsole.MarkupLine("[red]{0}[/]", "Hello [World]".EscapeMarkup());

AnsiConsole.MarkupLine("[red]{0}[/]", Markup.Escape("Hello [World]"));

const string hello = "Hello [World]"; 
// values in interpolated strings will be escaped automatically
AnsiConsole.MarkupLineInterpolated($"[red]{hello}[/]");

// background color
AnsiConsole.Markup("[bold yellow on blue]Hello[/] ");
AnsiConsole.Markup("[default on blue]World[/]");
AnsiConsole.MarkupLine("[on blue] ![/]");

// emojis
AnsiConsole.MarkupLine("Flying in the :airplane:"); // find a list of emojis here: https://spectreconsole.net/appendix/emojis

// colors
AnsiConsole.Markup("[red]Foo[/] ");
AnsiConsole.Markup("[#ff0000]Bar[/] ");
AnsiConsole.MarkupLine("[rgb(255,0,0)]Baz[/] ");

// clickable link

AnsiConsole.MarkupLine("[link]https://aramzham.github.io/[/]");
AnsiConsole.MarkupLine("[link=https://aramzham.github.io/]Visit my portfolio website[/]");

// styles
AnsiConsole.MarkupLine("[bold]I'm a bold text[/]");
AnsiConsole.MarkupLine("[dim]I'm a dim text[/]");
AnsiConsole.MarkupLine("[italic]I'm an italic text[/]");
AnsiConsole.MarkupLine("[underline]I'm an underlined text[/]");
AnsiConsole.MarkupLine("[invert]I'm an inverted text[/]");
AnsiConsole.MarkupLine("[conceal]I'm a concealed text[/]");
AnsiConsole.MarkupLine("[slowblink]I'm a slowly blinking text[/]");
AnsiConsole.MarkupLine("[rapidblink]I'm a rapidly blinking text[/]");
AnsiConsole.MarkupLine("[strikethrough]I'm a stricken through text[/]");
AnsiConsole.MarkupLine("[link]I'm a link[/]");
