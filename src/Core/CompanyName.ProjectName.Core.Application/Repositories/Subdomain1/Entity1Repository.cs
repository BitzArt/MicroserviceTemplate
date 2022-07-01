using BitzArt;
using CompanyName.ProjectName.Contexts;
using CompanyName.ProjectName.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyName.ProjectName.Repositories
{
    public class Entity1Repository : RepositoryBase, IEntity1Repository
    {
        public Entity1Repository(AppDbContext db) : base(db) { }

        public async Task<Entity1> GetAsync(int id)
        {
            var result = await _db.Set<Entity1>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (result is null) throw ApiException.NotFound($"Entity1 with id = '{id}' was not found");

            return result;
        }
    }
}
