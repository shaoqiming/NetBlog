using Shaoqi.Blog.BF;
using System;

namespace Shaoqi.Blog.Service
{
    public class UserService
    {
        public string Add()
        {
            USer1Bf bf = new USer1Bf();
            bf.AddUser(null);
            bf.Submit();
            return "";
        }
    }
}
