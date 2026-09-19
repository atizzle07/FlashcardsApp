namespace ConsoleUI.Models;

public class Card
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public string? Question { get; set; } = string.Empty;
    public string? Answer { get; set; } = string.Empty;
}