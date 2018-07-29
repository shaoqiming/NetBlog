
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class MenuAndOrg : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 组织Id
        /// </summary>
        public string OrgId { get; set; }
        /// <summary>
        /// 菜单Id
        /// </summary>
        public string MenuId { get; set; }
        
        }
}
