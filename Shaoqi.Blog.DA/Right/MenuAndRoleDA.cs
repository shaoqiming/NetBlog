
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class MenuAndRoleDa: BlogRepository<MenuAndRole>
    {
        public MenuAndRoleDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
