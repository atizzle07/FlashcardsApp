using ConsoleUI.Models;
using Spectre.Console;
using Spectre.Console.Rendering;

namespace ConsoleUI;

public class UI
{
    public static void WelcomeMessage()
    {
        var header = new FigletText("Flashcards")
        {
            Justification = Justify.Center
        };
        header.Color(Color.Blue);
        AnsiConsole.Write(header);
        
        AnsiConsole.MarkupLine("[bold orange3]Welcome to the Flashcard Application![/]\n");
        AnsiConsole.MarkupLine("[bold orange3]In this application you will manage and study stacks of flash cards.[/]");
        AnsiConsole.MarkupLine("[bold orange3]To Continue, please press Enter... [/]");
        Console.ReadKey();
    }

    public static void DrawMenu(Stack? stack)
    {
        // This class shows a menu across each UI draw with the current selected stack and other pertinent information
        int cardCount = stack.Cards.Count();
        
        Console.Clear();
        var panel = new Panel($"Name: {stack.Name}\nCards: {cardCount}")
            .Padding(0,5)
            .Header("Selected Stack")
            .HeavyBorder()
            .Expand();
        
        AnsiConsole.Write(panel);
        Console.WriteLine();
        Console.WriteLine();
    }
    
    public static MainMenuOption GetMainMenuChoice()
    {
        var userInput = AnsiConsole.Prompt(
            new SelectionPrompt<MainMenuOption>()
                .Title("Please select a menu Option:")
                .AddChoices(Enum.GetValues<MainMenuOption>()));
        return userInput;
    }

    public static ManageStackMenuOption GetManageStackMenuOption()
    {
        var userInput = AnsiConsole.Prompt(
            new SelectionPrompt<ManageStackMenuOption>()
                .Title("Please select an Option:")
                .AddChoices(Enum.GetValues<ManageStackMenuOption>()));
        return userInput;
    }

    public static ManageCardsMenuOption GetManageCardsMenuOption()
    {
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