using EntityFrameworkCoreEducation.ContextBase;
using EntityFrameworkCoreEducation.ContextBase.Entities;
using EntityFrameworkCoreEducation.SimpleContext;
using EntityFrameworkCoreEducation.SimpleContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreEducation
{
    public class EfCoreEducation
    {
        static void Main()
        {
            //WithDbSimpleDbContext();
            //WithMultipleDbContext();
            WithPooledFactory();
        }

        public static void WithDbSimpleDbContext()
        {
            using (var db = new DbSimpleContext())
            {
                //Disable Lazy Loading Here
                //db.ChangeTracker.LazyLoadingEnabled = false;
                db.Students.Add(new Student(0, "TTT", new DateTime(1997, 7, 11), "Le van luong"));
                db.SaveChanges();
            }
        }

        public static void WithMultipleDbContext()
        {
            var contextOptions = new DbContextOptionsBuilder<FirstDbContext>()
                .UseSqlServer(@"Server=ADMIN;Database=Education;User ID=TRANTIN;Password=genius;TrustServerCertificate=True")
                .Options;

            using (var db = new FirstDbContext(contextOptions))
            {
                db.Dogs.Add(new Dog(0,"Gau 1"));
                db.Cat.Add(new Cat(0, "Meo 1"));
                db.SaveChanges();
            }

            var contextOptions2 = new DbContextOptionsBuilder<SecondDbContext>()
                .UseSqlServer(@"Server=ADMIN;Database=Education2;User ID=TRANTIN;Password=genius;TrustServerCertificate=True")
                .Options;

            using (var db = new SecondDbContext(contextOptions2))
            {
                db.Dogs.Add(new Dog(0, "Gau 2"));
                db.Fish.Add(new Fish(0, "ca 1"));
                db.SaveChanges();
            }
        }

        public static void WithPooledFactory()
        {
            var options = new DbContextOptionsBuilder<FirstDbContext>()
                .UseSqlServer(@"Server=ADMIN;Database=Education2;User ID=TRANTIN;Password=genius;TrustServerCertificate=True")
                .Options;

            var factory = new PooledDbContextFactory<FirstDbContext>(options);

            using (var context = factory.CreateDbContext())
            {
                foreach(var d in context.Dogs.ToList())
                {
                    Console.WriteLine(d.Name);
                }
            }
        }
    }
}
