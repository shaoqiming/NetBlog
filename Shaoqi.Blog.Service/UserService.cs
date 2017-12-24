using Shaoqi.Blog.BF;
using System;

namespace Shaoqi.Blog.Service
{
    public class UserService
    {
        public string Add()
        {
            USerBF bf = new USerBF();
            bf.AddUser(null);
            bf.Submit();
            return "";
        }
    }
}
