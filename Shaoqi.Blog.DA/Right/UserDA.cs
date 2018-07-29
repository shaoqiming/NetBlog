
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class UserDa: BlogRepository<User>
    {
        public UserDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
