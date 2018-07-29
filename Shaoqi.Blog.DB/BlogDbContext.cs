using Microsoft.EntityFrameworkCore;
using Shaoqi.Blog.Core;
using System;
using Shaoqi.Blog.Data.Right;
using Shaoqi.Blog.Map.Right;


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

        public DbSet<User> User { get; set; }
        public DbSet<MenuAndOrg> MenuAndOrg { get; set; }
        public DbSet<MenuAndRole> MenuAndRole { get; set; }
        public DbSet<Org> Org { get; set; }
        public DbSet<RightMenu> RightMenu { get; set; }
        public DbSet<RoleAndUSer> RoleAndUSer { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserAndRole> UserAndRole { get; set; }
        public DbSet<UserDetail> UserDetail { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserMap(modelBuilder.Entity<User>());
            new MenuAndOrgMap(modelBuilder.Entity<MenuAndOrg>());
            new MenuAndRoleMap(modelBuilder.Entity<MenuAndRole>());
            new OrgMap(modelBuilder.Entity<Org>());
            new RightMenuMap(modelBuilder.Entity<RightMenu>());
            new RoleAndUSerMap(modelBuilder.Entity<RoleAndUSer>());
            new RoleMap(modelBuilder.Entity<Role>());
            new UserAndRoleMap(modelBuilder.Entity<UserAndRole>());
            new UserDetailMap(modelBuilder.Entity<UserDetail>());
        }

    }
}
