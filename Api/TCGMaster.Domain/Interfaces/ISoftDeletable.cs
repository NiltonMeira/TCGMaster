namespace TCG.Domain.Interfaces.Entities;

public interface ISoftDeletable
{
    bool ISoftDeled {get; set;}
    DateTime? DeletedAt {get; set;}
}