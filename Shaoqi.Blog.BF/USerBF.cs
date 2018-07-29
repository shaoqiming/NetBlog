using Shaoqi.Blog.DA;
using Shaoqi.Blog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.BF
{
    public class USer1Bf : BlogBaseBF
    {
        public void AddUser(User user)
        {
            UserDa da = new UserDa(UnitOfData);
            if (user == null)
            {
                user = new User() { FID = "1", NickName = "ss" };
            }
            da.Add(user);
        }
    }
}
