
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class RoleAndUSer : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 权限id
        /// </summary>
        public string RightId { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }
        
        }
}
