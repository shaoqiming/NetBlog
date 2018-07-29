
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class UserAndRole : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }
        
        }
}
