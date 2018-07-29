
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class MenuAndRole : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public string RoleId { get; set; }
        
        }
}
