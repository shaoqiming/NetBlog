
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class RoleAndUSerDa: BlogRepository<RoleAndUSer>
    {
        public RoleAndUSerDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
