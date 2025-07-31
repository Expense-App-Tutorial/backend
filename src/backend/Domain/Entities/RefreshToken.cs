using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Domain.Entities;

public class RefreshToken
{
    public Guid UserId { get; set; }

    [Key]
    public string Token { get; set; } = null!;
    public required Guid JwtId { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? RevokedAt { get; set; } = null;
    public bool IsUsed { get; set; }
    public bool IsRevoked { get; set; }

    // Navigation Properties
    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;
}
