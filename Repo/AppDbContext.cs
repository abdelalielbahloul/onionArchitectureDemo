using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /**
             * mapping this with the entities we have for creating the tables users and profile in our context = database
             */
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
