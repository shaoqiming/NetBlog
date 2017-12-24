using System;

namespace Shaoqi.Blog.Data
{
    public class BaseModel
    {
        /// <summary>
        /// fid
        /// </summary>
        public string FID { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int ISDelete { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public string UseValue1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public string UseValue2 { get; set; }
        public DateTime? CreateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? DeleteTime { get; set; }
        public string DeleteUser { get; set; }
    }
}
