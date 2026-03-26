using TCGMaster.Infrastructure.Data;

namespace TCGMaster.Application.Services;

public class SoftDeleteService
{
    private readonly AppDbContext _context;

    public SoftDeleteService(AppDbContext context)
    {
        _context = context;
    }
}