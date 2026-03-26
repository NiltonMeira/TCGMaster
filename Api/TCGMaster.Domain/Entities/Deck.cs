using TCG.Domain.Interfaces.Entities;

namespace TCGMaster.Domain.Entities;

public class Deck : ISoftDeletable
{
    public Guid Id {get; set;}

    public required string Name {get; set;}

    public List<DeckCard> Cards { get; set; } = new();
    public bool ISoftDeled {get; set;}
    public DateTime? DeletedAt {get; set;}
}