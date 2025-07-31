using backend.Domain.Shared;

namespace backend.Domain.Entities;

public class User : BaseEntity
{
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required bool IsEmailConfirmed { get; set; } = false;
    public string ProfilePicture { get; set; } = string.Empty;

    // Navigation Properties
    public ICollection<Category> Categories { get; set; } = [];
    public ICollection<UserLogin> UserLogins { get; set; } = [];
    public ICollection<Wallet> Wallets { get; set; } = [];
}
