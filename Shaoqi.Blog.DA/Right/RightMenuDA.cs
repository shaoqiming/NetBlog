
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class RightMenuDa: BlogRepository<RightMenu>
    {
        public RightMenuDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
