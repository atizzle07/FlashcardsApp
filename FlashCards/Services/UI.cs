using Spectre.Console;

namespace FlashCards.Services;

public static class UI
{
    public static void WelcomeMessage()
    {
        AnsiConsole.MarkupLine("[bold orange3]Welcome to the Flashcard Application![/]\n");
        AnsiConsole.MarkupLine("[bold orange3]In this application you will manage and study stacks of flash cards.[/]");
        AnsiConsole.MarkupLine("[bold orange3]To Continue, please press Enter... [/]");
        Console.ReadKey();
    }

    public static MainMenuOption GetMainMenuChoice()
    {
        Console.Clear();
        var userInput = AnsiConsole.Prompt(
            new SelectionPrompt<MainMenuOption>()
                .Title("Please select a menu Option:")
                .AddChoices(Enum.GetValues<MainMenuOption>()));
        return userInput;
    }

    public static ManageStackMenuOption GetManageStackMenuOption()
    {
        Console.Clear();
        var userInput = AnsiConsole.Prompt(
            new SelectionPrompt<ManageStackMenuOption>()
                .Title("Please select an Option:")
                .AddChoices(Enum.GetValues<ManageStackMenuOption>()));
        return userInput;
    }

    public static ManageCardsMenuOption GetManageCardsMenuOption()
    {
        Console.Clear();
        var userInput = AnsiConsole.Prompt(
            new SelectionPrompt<ManageCardsMenuOption>()
                .Title("Please select an Option:")
                .AddChoices(Enum.GetValues<ManageCardsMenuOption>()));
        return userInput;
    }

    public enum MainMenuOption
    {
        ManageStacks,
        ManageCards,
        BeginStudySession,
        ViewStudySessions,
        Exit
    }
    public enum ManageStackMenuOption
    {
        StackPreferences,
        ManageCards,
        ReturnToMenu
    }
    public enum ManageCardsMenuOption
    {
        ViewStack,
        AddStack,
        ModifyStack,
        DeleteStack,
        ChangeCurrentStack,
        ReturnToMenu
    }
}