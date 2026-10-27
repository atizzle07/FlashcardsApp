using ConsoleUI;
using ConsoleUI.Services;
using Spectre.Console;
using Stack = ConsoleUI.Models.Stack;

DataConnection dc = new();

try
{
    dc.CreateDatabase();
    int[] success = dc.CreateTables();
    Console.WriteLine(success);
}
catch (Exception e)
{
    Console.WriteLine($"An error occurred: {e}");
}

Console.WriteLine("Application Reached!");
Console.ReadKey();

var exitApp = false;
Stack activeStack = new Stack() //On app start, set the active stack to none
{ 
    Id = -1,
    Name = "None Selected"
};

UI.WelcomeMessage();

while (!exitApp)
{
    UI.DrawMenu(activeStack);
    var userInput = UI.GetMainMenuChoice();

    switch (userInput)
    {
        case UI.MainMenuOption.ManageStacks:
            ManageStacks();
            Console.ReadKey();
            break;
        case UI.MainMenuOption.ManageCards:
            ManageCards();
            Console.ReadKey();
            break;
        case UI.MainMenuOption.BeginStudySession:
            BeginStudySession();
            Console.ReadKey();
            break;
        case UI.MainMenuOption.ViewStudySessions:
            ViewStudySessions();
            break;
        case UI.MainMenuOption.Exit:
            AnsiConsole.MarkupLine(
                "[bold red]Exit Application. Press [black on white]Enter[/] to close the application...[/]");
            Console.ReadKey();
            exitApp = true;
            break;
        default:
            break;
    }
}


static void ManageStacks()
{
    AnsiConsole.MarkupLine("[bold orange3]You have reached the Manage Cards Menu. Select an Option: [/]");
    var choice = UI.GetManageStackMenuOption();
    switch (choice)
    {
        case UI.ManageStackMenuOption.StackPreferences:
            break;
        case UI.ManageStackMenuOption.ManageCards:
            break;
        case UI.ManageStackMenuOption.ReturnToMenu:
            break;
        default:
            break;
    }
}

void ManageCards()
{
    if (activeStack.Id < 0)
    {
        AnsiConsole.MarkupLine("[bold red]Error: No Stack selected.[/]");
        return;
    }
    AnsiConsole.MarkupLine("[bold orange3]You have reached the Manage Cards Menu. Select an Option: [/]");
    var choice = UI.GetManageCardsMenuOption();
    switch (choice)
    {
        case UI.ManageCardsMenuOption.ViewStack:
            break;
        case UI.ManageCardsMenuOption.AddStack:
            break;
        case UI.ManageCardsMenuOption.ModifyStack:
            break;
        case UI.ManageCardsMenuOption.DeleteStack:
            break;
        case UI.ManageCardsMenuOption.ChangeCurrentStack:
            break;
        case UI.ManageCardsMenuOption.ReturnToMenu:
            break;
        default:
            break;
    }
    //using var conn = DataConnection.GetConnection();
    //conn.Open();
}

static void BeginStudySession()
{
    AnsiConsole.MarkupLine("[bold orange3]Study Session feature not complete. Press [black on white]Enter[/] to return to menu[/]");
}


void ViewStudySessions()
{
    AnsiConsole.MarkupLine("[bold orange3]Study Session feature not complete. Press [black on white]Enter[/] to return to menu[/]");
}
