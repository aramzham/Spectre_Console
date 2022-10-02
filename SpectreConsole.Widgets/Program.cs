// table

using Spectre.Console;

var table = new Table();

table.AddColumn("Foo");
table.AddColumn(new TableColumn("Bar").Centered());

table.AddRow("Baz", "[green]Qux[/]");
table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));
table.AddRow("Didier", "[red]Drogba[/]");

// borders
// table.Border(TableBorder.None);
table.Border(TableBorder.AsciiDoubleHead);
// table.Border(TableBorder.Square);
// table.Border(TableBorder.Rounded);

// expand/collapse
table.Expand();
// table.Collapse();

table.HideHeaders();

table.Width(50);

// alignment
// table.Alignment(Justify.Right);
// table.RightAligned();
table.Centered();
// table.LeftAligned();

// padding
// table.Columns[0].PadLeft(3);
// table.Columns[0].PadRight(5);
// table.Columns[0].Padding(4, 0);

// Or chained together
table.Columns[0].PadLeft(3).PadRight(5);

table.Columns[1].NoWrap();

table.Columns[0].Width(15);

AnsiConsole.Write(table);