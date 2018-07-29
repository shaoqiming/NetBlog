
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class UserAndRoleDa: BlogRepository<UserAndRole>
    {
        public UserAndRoleDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
