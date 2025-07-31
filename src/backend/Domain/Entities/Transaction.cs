using System.ComponentModel.DataAnnotations.Schema;
using backend.Domain.Shared;

namespace backend.Domain.Entities;

public class Transaction : BaseEntity
{
    public Guid WalletId { get; set; }
    public Guid CategoryId { get; set; }

    public required string Name { get; set; }
    public required decimal Amount { get; set; }
    public required string Description { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(WalletId))]
    public Wallet Wallet { get; set; } = null!;

    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;
}
