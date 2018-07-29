﻿using System;

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
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateUser { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }
        /// <summary>
        /// 删除人
        /// </summary>
        public string DeleteUser { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public string TIMESSTAMP { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
