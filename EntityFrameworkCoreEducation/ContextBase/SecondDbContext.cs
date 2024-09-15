using EntityFrameworkCoreEducation.ContextBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreEducation.ContextBase
{
    public sealed class SecondDbContext : ApplicationDbContextBase
    {
        public DbSet<Fish> Fish { get; set; }
        public SecondDbContext(DbContextOptions<SecondDbContext> contextOptions) : base(contextOptions)
        {
        }
        public SecondDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
        }
    }
}
