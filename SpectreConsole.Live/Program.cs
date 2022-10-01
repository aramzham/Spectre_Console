using Spectre.Console;

// live
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


// progress
await AnsiConsole.Progress()
    .AutoRefresh(true) // Turn on auto refresh
    .AutoClear(false)   // Do not remove the task list when done
    .HideCompleted(false)   // Hide tasks as they are completed
    .Columns(new ProgressColumn[] 
    {
        new TaskDescriptionColumn(),    // Task description
        new ProgressBarColumn(),        // Progress bar
        new PercentageColumn(),         // Percentage
        new RemainingTimeColumn(),      // Remaining time
        new SpinnerColumn(),            // Spinner
    })
    .StartAsync(async ctx =>
    {
        // Define tasks
        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
        var task2 = ctx.AddTask("[green]Folding space[/]");

        while (!ctx.IsFinished)
        {
            // Simulate some work
            await Task.Delay(250);

            // Increment
            task1.Increment(1.5);
            task2.Increment(0.5);
        }
    });


// status
await AnsiConsole.Status()
    .Spinner(Spinner.Known.Dots)
    .SpinnerStyle(Style.Parse("blue bold"))
    .StartAsync("Thinking...", async ctx => 
    {
        // Simulate some work
        AnsiConsole.MarkupLine("Doing some work...");
        await Task.Delay(1000);
        
        // Update the status and spinner
        ctx.Status("Thinking some more");
        ctx.Spinner(Spinner.Known.Star);
        ctx.SpinnerStyle(Style.Parse("green"));

        // Simulate some work
        AnsiConsole.MarkupLine("Doing some more work...");
        await Task.Delay(2000);
    });