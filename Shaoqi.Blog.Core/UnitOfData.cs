using Microsoft.EntityFrameworkCore;
using Shaoqi.Blog.Api;
using System;
using System.Collections.Generic;

using System.Text;

namespace Shaoqi.Blog.Core
{
    public partial class UnitOfData : DbContext, IUnitOfData
    {
        protected string ConnString { get; set; }

        public int Submit()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.ConnString);
        }
        public void Dispose()
        {
            base.Dispose();
        }


    }
}
