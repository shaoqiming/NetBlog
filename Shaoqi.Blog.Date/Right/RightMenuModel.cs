
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class RightMenu : BaseModel
    {
             public string FID { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string RightName { get; set; }
        /// <summary>
        /// 父级菜单名称
        /// </summary>
        public string RightParent { get; set; }
        /// <summary>
        /// 是否为父级
        /// </summary>
        public bool? isParent { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 父级FID
        /// </summary>
        public string ParentId { get; set; }
        
        }
}
