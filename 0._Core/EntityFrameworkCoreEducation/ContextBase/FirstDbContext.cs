using EntityFrameworkCoreEducation.ContextBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreEducation.ContextBase
{
    public  class FirstDbContext : ApplicationDbContextBase
    {
        public DbSet<Cat> Cat { get; set; }
        public FirstDbContext(DbContextOptions<FirstDbContext> contextOptions) : base(contextOptions)
        {
        }
    }
}
