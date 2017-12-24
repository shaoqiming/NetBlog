using Microsoft.EntityFrameworkCore;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.DA
{
    public class BlogRepository<T>: Repository<T> where T:class
    {
        public BlogRepository(IUnitOfData dbContext)
           : base(dbContext as DbContext)
        {
        }
    }
}
