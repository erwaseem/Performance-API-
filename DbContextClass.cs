using API.DAL.DataEntity;
using API.DAL.DataEntity.Proc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace API.DAL
{
    public class DbContextClass:DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Users> Users { get; set; }
     
        public DbSet<Employee> Employee { get; set; }
        public DbSet<master_PerformanceQuestion> master_PerformanceQuestion { get; set; }
        public DbSet<MasterPerformanceRating> MasterPerformanceRating { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure fullNameDTO as a non-entity type
            modelBuilder.Entity<fullNameDTO>().HasNoKey().ToView(null); 
             modelBuilder.Entity<ServiceProviderDetailsDTO>().HasNoKey().ToView(null);
            // Other configurations for your entities

            base.OnModelCreating(modelBuilder);
        }

    }

}

