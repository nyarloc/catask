using Catask.DAL.Entities;
using System.Data.Entity;

namespace Catask.DAL.EF
{
    public class CataskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        static CataskContext()
        {
            Database.SetInitializer<CataskContext>(new CataskDbInitializer());
        }

        public CataskContext(string connectionString) : base(connectionString) { }
    }
}
