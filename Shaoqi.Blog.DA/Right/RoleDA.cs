
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class RoleDa: BlogRepository<Role>
    {
        public RoleDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
