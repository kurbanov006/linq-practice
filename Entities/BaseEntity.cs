namespace Practice.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime DeletedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    public long Version { get; set; }
}