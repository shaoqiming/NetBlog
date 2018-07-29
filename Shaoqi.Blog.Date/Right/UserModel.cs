
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class User : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 用户名称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 是否激活
        /// </summary>
        public bool? IsActive { get; set; }
        
        }
}
