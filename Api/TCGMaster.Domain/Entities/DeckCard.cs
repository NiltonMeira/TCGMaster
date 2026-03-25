namespace TCGMaster.Domain.Entities;

public class DeckCard
{
    public Guid Id { get; set; }

    public Guid DeckId { get; set; }

    public required string ScryfallId { get; set; }

    public required string OriginalName { get; set; }

    public required string OriginalImageUrl { get; set; }

    public string? CustomTitle { get; set; }

    public string? CustomImageUrl { get; set; }

    public int Quantity { get; set; }

    public Deck Deck { get; set; } = null!;
}