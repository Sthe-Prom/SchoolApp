using SchoolApp.Models.Interfaces;
// using System.Data.Entity.Design;
// using System.Data.Entity.Core.EntityClient;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design;

namespace SchoolApp.Models
{
    public class AppDbContext : DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
     
            //Propeties - [T A B L E S]
            public DbSet<Account> Account { get; set; }
            public DbSet<Address> Address { get; set; }          
            public DbSet<Appeal> Appeal { get; set; }
            public DbSet<AppealReason> AppealReason { get; set; }
            public DbSet<Status> Status { get; set; }
            public DbSet<AppealStatus> AppealStatus { get; set; }
            public DbSet<Application> Application { get; set; }
            public DbSet<School> School { get; set; }

            // protected override void OnModelCreating( DbModelBuilder modelBuilder )
            // {

            //     modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //     modelBuilder.Entity<Appeal>()
            //     .HasRequired( f => f.Status )
            //     .WithRequiredDependent()
            //     .WillCascadeOnDelete( false );

            //     modelBuilder.Entity<AppealStatus>()
            //     .HasRequired( f => f.Status )
            //     .WithRequiredDependent()
            //     .WillCascadeOnDelete( false );

            // }
                   
    }
}
