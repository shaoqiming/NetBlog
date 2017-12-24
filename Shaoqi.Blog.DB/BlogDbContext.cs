using Microsoft.EntityFrameworkCore;
using Shaoqi.Blog.Core;
using Shaoqi.Blog.Data;
using Shaoqi.Blog.DB.Map;
using System;

namespace Shaoqi.Blog.DB
{
    public class BlogDbContext : UnitOfData
    {
        public BlogDbContext(string connstring)
        {
            this.ConnString = connstring;
        }

        public BlogDbContext()
        {
            this.ConnString = @"Data Source=.;Initial Catalog=shaoqiBlog1217;User ID=sa;Password=sa";
            //Database.SetInitializer<AtawHISDBContext>(null);
        }

        public DbSet<User> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
        }

    }
}
