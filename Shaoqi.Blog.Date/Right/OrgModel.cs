
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class Org : BaseModel
    {
             public string id { get; set; }
        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName { get; set; }
        /// <summary>
        /// 组织编码
        /// </summary>
        public string OrgCode { get; set; }
        /// <summary>
        /// 组织地址
        /// </summary>
        public string OrgAdress { get; set; }
        /// <summary>
        /// 组织联系方式
        /// </summary>
        public string OrgPhone { get; set; }
        /// <summary>
        /// 是否为父级
        /// </summary>
        public bool? IsParent { get; set; }
        /// <summary>
        /// 组织描述
        /// </summary>
        public string OrgDescrible { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public string ParentId { get; set; }
        
        }
}
