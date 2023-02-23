using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;

namespace EntityFramework.Db
{  
       public class DemoDbContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Address> Address { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                var path = "Server=localhost\\SQLEXPRESS;Database=ENTITY;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true";
                optionsBuilder.UseSqlServer(path);
                optionsBuilder.UseSqlServer(path);
                base.OnConfiguring(optionsBuilder);

                base.OnConfiguring(optionsBuilder);
            }
        }
    
}
