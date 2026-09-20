using FlashCards.Services;
using Spectre.Console;

bool exitApp = false;
UI.MainMenuOption userInput;

UI.WelcomeMessage();
do
{
    userInput = UI.GetMainMenuChoice();

    switch (userInput)
    {
        case UI.MainMenuOption.Manage_Stacks:
            ManageStacks();
            Console.ReadKey();
            break;
        case UI.MainMenuOption.Manage_Cards:
            ManageCards();
            Console.ReadKey();
            break;
        case UI.MainMenuOption.Begin_Study_Session:
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
        case UI.ManageStackMenuOption.Stack_Preferences:
            break;
        case UI.ManageStackMenuOption.Manage_Cards:
            break;
        case UI.ManageStackMenuOption.Return_to_Menu:
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
        case UI.ManageCardsMenuOption.View_Stack:
            break;
        case UI.ManageCardsMenuOption.Add_Stack:
            break;
        case UI.ManageCardsMenuOption.Modify_Stack:
            break;
        case UI.ManageCardsMenuOption.Delete_Stack:
            break;
        case UI.ManageCardsMenuOption.Change_Current_Stack:
            break;
        case UI.ManageCardsMenuOption.Return_to_Menu:
            break;
        default:
            break;
    }
//using var conn = DataConnection.GetConnection();
//conn.Open();
}

static void BeginStudySession()
{
    AnsiConsole.MarkupLine(
        "[bold orange3]Study Session feature not complete. Press [black on white]Enter[/] to return to menu[/]");
}