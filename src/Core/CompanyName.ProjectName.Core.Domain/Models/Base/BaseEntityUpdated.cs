namespace CompanyName.ProjectName.Models;

public abstract class BaseEntityUpdated : BaseEntityCreated
{
    public DateTime UpdatedOn { get; set; }

    public int UpdatedById { get; set; }

    public override void Created(int userId)
    {
        base.Created(userId);
        Updated(userId);
    }

    public void Updated(int userId)
    {
        UpdatedOn = DateTime.UtcNow;
        UpdatedById = userId;
    }
}
