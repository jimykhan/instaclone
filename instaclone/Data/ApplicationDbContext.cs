using System;
using instaclone.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace instaclone.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set;}
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Follwers> Follwers { get; set; }
        public DbSet<Follwings> Follwings { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Posts> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Like>().HasKey(key => new { key.PostId, key.ApplicationUserId });

            builder.Entity<Comments>().HasKey(key => new { key.PostId, key.ApplicationUserId });

            builder.Entity<Follwers>().HasKey(key => new { key.Id, key.ApplicationUserId });

            builder.Entity<Follwings>().HasKey(key => new { key.Id, key.ApplicationUserId });
        }
    }
}
