
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class UserDetailDa: BlogRepository<UserDetail>
    {
        public UserDetailDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
