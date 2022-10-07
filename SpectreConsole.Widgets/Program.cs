// Create the tree

using Spectre.Console;

var root = new Tree("Root");

// Add some nodes
var foo = root.AddNode("[yellow]Foo[/]");
var table = foo.AddNode(new Table()
    .RoundedBorder()
    .AddColumn("First")
    .AddColumn("Second")
    .AddRow("1", "2")
    .AddRow("3", "4")
    .AddRow("5", "6"));

table.AddNode("[blue]Baz[/]");
foo.AddNode("Qux");

var bar = root.AddNode("[yellow]Bar[/]");
bar.AddNode(new Calendar(2020, 12)
    .AddCalendarEvent(2020, 9, 27)
    .HideHeader());

root.AddNode("Label").Collapse();

// Render the tree
AnsiConsole.Write(root);

var rootTree1 = new Tree("Root").Style("white on red");
rootTree1.AddNode("branch");
AnsiConsole.Write(rootTree1);

// ASCII guide lines
var rootTree2 = new Tree("Root").Guide(TreeGuide.Ascii);
rootTree2.AddNode("branch");
AnsiConsole.Write(rootTree2);

// Default guide lines
var rootTree3 = new Tree("Root").Guide(TreeGuide.Line);
rootTree3.AddNode("branch");
AnsiConsole.Write(rootTree3);

// Double guide lines
var rootTree4 = new Tree("Root").Guide(TreeGuide.DoubleLine);
rootTree4.AddNode("branch");
AnsiConsole.Write(rootTree4);

// Bold guide lines
var rootTree5 = new Tree("Root").Guide(TreeGuide.BoldLine);
rootTree5.AddNode("branch");
AnsiConsole.Write(rootTree5);