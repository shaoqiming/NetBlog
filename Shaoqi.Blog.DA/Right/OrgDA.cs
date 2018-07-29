
using System;
using Shaoqi.Blog.Api;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.DA.Right
{
    public class OrgDa: BlogRepository<Org>
    {
        public OrgDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
