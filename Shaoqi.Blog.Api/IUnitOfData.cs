using System;

namespace Shaoqi.Blog.Api
{
    public interface IUnitOfData:IDisposable
    {
        int Submit();

    }
}
