using TCGMaster.Domain.Entities;

namespace TCGMaster.Application.Interfaces;

public interface IDeckRepository
{
    Task<Deck> CreateAsync(Deck deck);

    Task<Deck?> GetByIdAsync(Guid id);

    Task<List<Deck>> GetAllAsync();
}