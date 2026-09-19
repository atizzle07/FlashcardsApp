using ConsoleUI;
using Spectre.Console;

var exitApp = false;

UI.WelcomeMessage();
do
{
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
        case UI.MainMenuOption.Exit:
            AnsiConsole.MarkupLine(
                "[bold red]Exit Application. Press [black on white]Enter[/] to close the application...[/]");
            Console.ReadKey();
            exitApp = true;
            break;
        default:
            break;
    }
} while (!exitApp);
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

static void ManageCards()
{
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



