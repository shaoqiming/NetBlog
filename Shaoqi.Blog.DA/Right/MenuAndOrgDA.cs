
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class MenuAndOrgDa : BlogRepository<MenuAndOrg>
    {
        public MenuAndOrgDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
