using ConsoleUI.Models;

namespace FlashCards.Models;

public class CardStackDTO()
{
    public string?  Name { get; set; }
    public List<CardDto>? Cards {get; set;}
}