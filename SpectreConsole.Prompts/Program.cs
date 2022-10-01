using Spectre.Console;

string AskForName() => AnsiConsole.Ask<string>("What's your [green]name[/]?");

if (Confirmation())
    AnsiConsole.MarkupLine("[red]Confirmation is done[/]");
else
    return;

var name = AskForName();
var favoriteFruit = AskForFavoriteFruit();
var age = AskForAge();
var password = AskForPassword();
var color = AskOptionalQuestion();
var fruit = QuestionOnFruits();

AnsiConsole.MarkupLineInterpolated($"Your name is [italic]{name}[/]");
AnsiConsole.MarkupLineInterpolated($"Your favorite fruit is [italic]{favoriteFruit}[/]");
AnsiConsole.MarkupLineInterpolated($"Your age is [bold]{age}[/]");
// AnsiConsole.MarkupLineInterpolated($"Your password is [bold]{password}[/]");
if(!string.IsNullOrEmpty(color))
    AnsiConsole.MarkupLineInterpolated($"Your favorite color is [{color}]{color}[/]");
AnsiConsole.WriteLine($"I agree. {fruit} is tasty!");

bool Confirmation()
{
    if (AnsiConsole.Confirm("Run prompt example?")) 
        return true;

    AnsiConsole.MarkupLine("Ok... :(");
    return false;
}

string AskForFavoriteFruit()
{
    var favorites = AnsiConsole.Prompt(
        new MultiSelectionPrompt<string>()
            .PageSize(10)
            .Title("What are your [green]favorite fruits[/]?")
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
            .AddChoiceGroup("Berries", new[]
            {
                "Blackcurrant", "Blueberry", "Cloudberry",
                "Elderberry", "Honeyberry", "Mulberry"
            })
            .AddChoices("Apple", "Apricot", "Avocado", "Banana", "Cherry", "Cocunut", "Date", "Dragonfruit", "Durian", "Egg plant", "Fig", "Grape", "Guava", "Jackfruit", "Jambul", "Kiwano", "Kiwifruit", "Lime", "Lylo", "Lychee", "Melon", "Nectarine", "Orange", "Olive"));

    var fruit = favorites.Count == 1 ? favorites[0] : null;
    if (string.IsNullOrWhiteSpace(fruit))
    {
        fruit = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Ok, but if you could only choose [green]one[/]?")
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(favorites));
    }

    AnsiConsole.MarkupLine("Your selected: [yellow]{0}[/]", fruit);
    return fruit;
}

int AskForAge()
{
    return AnsiConsole.Prompt(
        new TextPrompt<int>("How [green]old[/] are you?")
            .PromptStyle("green")
            .ValidationErrorMessage("[red]That's not a valid age[/]")
            .Validate(age =>
            {
                return age switch
                {
                    <= 0 => ValidationResult.Error("[red]You must at least be 1 years old[/]"),
                    >= 123 => ValidationResult.Error("[red]You must be younger than the oldest person alive[/]"),
                    _ => ValidationResult.Success(),
                };
            }));
}

string AskForPassword()
{
    return AnsiConsole.Prompt(
        new TextPrompt<string>("Enter [green]password[/]?")
            .PromptStyle("red")
            .Secret()); // use masks '-' or null to completely hide the input
}

string AskOptionalQuestion()
{
    return AnsiConsole.Prompt(
        new TextPrompt<string>("[grey][[Optional]][/] What is your [green]favorite color[/]?")
            .AllowEmpty());
}

string QuestionOnFruits()
{
    return AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("What's your [green]favorite fruit[/]?")
            .PageSize(10)
            .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
            .AddChoices("Apple", "Apricot", "Avocado", "Banana", "Blackcurrant", "Blueberry", "Cherry", "Cloudberry", "Cocunut"));
}