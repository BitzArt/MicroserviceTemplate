using CompanyName.ProjectName.Models;

namespace CompanyName.ProjectName.Repositories
{
    public interface IEntity1Repository
    {
        Task<Entity1> GetAsync(int id);
    }
}