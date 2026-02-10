namespace MediaManager.Core.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

// eventually, i want to have user auth + tracking user updates for any media changes/additions
    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}