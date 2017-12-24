using Shaoqi.Blog.DA;
using Shaoqi.Blog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.BF
{
    public class USerBF : BlogBaseBF
    {
        public void AddUser(User user)
        {
            UserDA da = new UserDA(UnitOfData);
            if (user == null)
            {
                user = new User() { FID = "1", NickName = "ss" };
            }
            da.Add(user);
        }
    }
}
