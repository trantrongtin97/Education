using EntityFrameworkCoreEducation.ContextBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreEducation.ContextBase
{
    public abstract class ApplicationDbContextBase : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        protected ApplicationDbContextBase(DbContextOptions contextOptions) : base(contextOptions)
        { 
        }
    }
}
