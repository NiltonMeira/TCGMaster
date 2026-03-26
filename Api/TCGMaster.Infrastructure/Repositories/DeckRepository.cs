using Microsoft.EntityFrameworkCore;
using TCGMaster.Application.Interfaces;
using TCGMaster.Domain.Entities;
using TCGMaster.Infrastructure.Data;

namespace TCGMaster.Infrastructure.Repositories;

public class DeckRepository : IDeckRepository
{
    private readonly AppDbContext _context;

    private DeckRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Deck> CreateAsync(Deck deck)
    {
        _context.Decks.Add(deck);
        await _context.SaveChangesAsync();
        return deck;
    }

    public async Task<Deck> GetByIdAsync(Guid id)
    {
         return await _context.Decks
            .Include(d => d.Cards)
            .FirstOrDefaultAsync(d => d.Id == id);
    }

    public async Task<List<Deck>> GetAllAsync()
    {
        return await _context.Decks.ToListAsync();
    }
}