using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.Data
{
    public class User : BaseModel
    {
        public string NickName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
