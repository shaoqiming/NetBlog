
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class Role : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 组织id
        /// </summary>
        public string OrgId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色编码
        /// </summary>
        public string RoleCode { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        
        }
}
