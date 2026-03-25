namespace TCGMaster.Domain.Entities;

public class Deck
{
    public Guid Id {get; set;}

    public required string Name {get; set;}

    public required List<DeckCard> Cards {get; set;}
}