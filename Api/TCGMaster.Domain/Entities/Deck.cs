namespace TCGMaster.Domain.Entities;

public class Deck
{
    public Guid Id {get; set;}

    public required string Name {get; set;}

    public List<DeckCard> Cards { get; set; } = new();
}