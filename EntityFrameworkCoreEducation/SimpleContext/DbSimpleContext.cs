using EntityFrameworkCoreEducation.ContextBase;
using EntityFrameworkCoreEducation.SimpleContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreEducation.SimpleContext
{
    public sealed class DbSimpleContext : DbContext
    {
        //public DbSimpleContext() : base()
        //{
        //    //Disabling Lazy Loading
        //    this.ChangeTracker.LazyLoadingEnabled = false;
        //}

        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies(); Ef core proxy
            optionsBuilder.UseSqlServer("Server=ADMIN;Database=Education;User ID=TRANTIN;Password=genius;TrustServerCertificate=True");
        }
    }
}
