namespace CompanyName.ProjectName.Models;

public abstract class BaseEntityCreated : BaseEntity
{
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public int CreatedById { get; set; }

    public virtual void Created(int userId)
    {
        CreatedOn = DateTime.UtcNow;
        CreatedById = userId;
    }
}
