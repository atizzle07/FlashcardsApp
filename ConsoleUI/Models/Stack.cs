namespace ConsoleUI.Models;

public class Stack
{
    public int Id { get; set; }
    public string  Name { get; set; } = "";
    public List<Card> Cards {get; set;} = new();
}