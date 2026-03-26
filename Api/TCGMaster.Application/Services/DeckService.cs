using TCGMaster.Application.Interfaces;
using TCGMaster.Domain.Entities;

namespace TCGMaster.Application.Services;

public class DeckService
{
    private readonly IDeckRepository _deckRepository;

    public DeckService(IDeckRepository deckRepository)
    {
        _deckRepository = deckRepository;
    }

    public async Task<Deck> CreateDeckAsync(string name)
    {
        var deck = new Deck
        {
            Id = Guid.NewGuid(),
            Name = name
        };

        return await _deckRepository.CreateAsync(deck);
    }

    public async Task<List<Deck>> GetDecksAsync()
    {
        return await _deckRepository.GetAllAsync();
    }

    public async Task<Deck> GetDeckByIdAsync(Guid id)
    {
        var deck = await _deckRepository.GetByIdAsync(id);

        if(deck == null)
            throw new Exception("Was not possible to find the Deck");
        
        return deck;
    }
}