using System.ComponentModel.DataAnnotations.Schema;
using backend.Domain.Enums;
using backend.Domain.Shared;

namespace backend.Domain.Entities;

public class UserLogin : BaseEntity
{
    public Guid UserId { get; set; }

    public required LoginProvider LoginProvider { get; set; }
    public required string ProviderKey { get; set; }
    public required string ProviderDisplayName { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    public string Salt { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;

    // Navigation Properties
    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;
}
