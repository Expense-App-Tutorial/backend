using backend.Domain.Shared;

namespace backend.Domain.Entities;

public class Wallet : BaseEntity
{
    public Guid UserId { get; set; }

    public required string Name { get; set; }
    public required string Icon { get; set; }
    public required string Description { get; set; }

    // Navigation Properties
    public User User { get; set; } = null!;

    public ICollection<Transaction> Transactions { get; set; } = [];
}
