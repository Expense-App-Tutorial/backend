namespace backend.Domain.Shared;

public class BaseEntity
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public DateTimeOffset? UpdatedAt { get; set; } = null;
    public DateTimeOffset? DeletedAt { get; set; } = null;
    public bool IsDeleted { get; set; }

    public void Update()
    {
        UpdatedAt = DateTimeOffset.UtcNow;
    }

    public void Delete()
    {
        DeletedAt = DateTimeOffset.UtcNow;
        IsDeleted = true;
    }

    public void Restore()
    {
        UpdatedAt = DateTimeOffset.UtcNow;
        DeletedAt = null;
        IsDeleted = false;
    }
}
