using Shaoqi.Blog.Api;
using Shaoqi.Blog.DB;
using System;

namespace Shaoqi.Blog.BF
{
    public class BlogBaseBF:IDisposable
    {
        private IUnitOfData fUnitOfData;

        public BlogBaseBF SetUnitOfData(string connstring)
        {
            fUnitOfData = new BlogDbContext(connstring);
            ((BlogDbContext)fUnitOfData).Database.EnsureCreated();
            return this;
        }

        public BlogBaseBF SetUnitOfData(IUnitOfData unitOfData)
        {
            if (unitOfData != null)
            {
                this.fUnitOfData = unitOfData;
            }
            return this;
        }

        public IUnitOfData UnitOfData
        {
            get {
                if (fUnitOfData == null)
                {
                    fUnitOfData = new BlogDbContext();
                }
                return fUnitOfData;
            }
        }

        public int Submit()
        {
            return UnitOfData.submit();
        }

        public void Dispose()
        {
            if (UnitOfData != null)
            {
                UnitOfData.Dispose();
            }
        }
    }
}
