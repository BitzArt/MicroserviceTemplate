using CompanyName.ProjectName.Contexts;

namespace CompanyName.ProjectName.Repositories
{
    public class RepositoryBase
    {
        protected AppDbContext _db = null!;

        public RepositoryBase(AppDbContext db)
        {
            _db = db;
        }
    }
}
