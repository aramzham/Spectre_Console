using Spectre.Console;

var table = new Table().Centered();

await AnsiConsole.Live(table)
    .AutoClear(true)   // Remove when done
    .Overflow(VerticalOverflow.Ellipsis) // Show ellipsis when overflowing
    .Cropping(VerticalOverflowCropping.Top) // Crop overflow at top
    .StartAsync(async (ctx) =>
{
    table.AddColumn(new TableColumn(new Markup("[yellow]#[/]")));
    ctx.Refresh();
    await Task.Delay(1000);
    
    table.AddColumn(new TableColumn(new Markup("[blue]Country[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]MP[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]W[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]D[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]L[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]G[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddColumn(new TableColumn(new Markup("[blue]PTS[/]")));
    ctx.Refresh();
    await Task.Delay(100);
    
    table.AddRow(new TableRow(new Markup[]{new("[green]1[/]"), new("[green]Scotland[/]"), new("[green]6[/]"), new("[green]4[/]"), new("[green]1[/]"), new("[green]1[/]"), new("[green]11:5[/]"), new("[green]13[/]")}));
    ctx.Refresh();
    await Task.Delay(1000);
    
    table.AddRow(new TableRow(new Markup[]{new("2"), new("Ukraine") , new("6"), new("3"), new("2"), new("1"), new("10:4"), new("11")}));
    ctx.Refresh();
    await Task.Delay(1000);
    
    table.AddRow(new TableRow(new Markup[]{new("3"), new("Ireland") , new("6"), new("2"), new("1"), new("3"), new("8:7"), new("7")}));
    ctx.Refresh();
    await Task.Delay(1000);
    
    table.AddRow(new TableRow(new Markup[]{new("[red]4[/]"), new("[red]Armenia[/]") , new("[red]6[/]"), new("[red]1[/]"), new("[red]0[/]"), new("[red]5[/]"), new("[red]4:17[/]"), new("[red]3[/]")}));
    ctx.Refresh();
});