namespace TCGAPI.Domain.Entities;

public class DeckCard
{
    public Guid Id { get; set; }

    public Guid DeckId { get; set; }

    public string ScryfallId { get; set; }

    public string OriginalName { get; set; }

    public string OriginalImageUrl { get; set; }

    public string? CustomTitle { get; set; }

    public string? CustomImageUrl { get; set; }

    public int Quantity { get; set; }

    public Deck Deck { get; set; }
}