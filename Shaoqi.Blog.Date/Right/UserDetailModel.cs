
using System;

namespace Shaoqi.Blog.Data.Right
{
    public class UserDetail : BaseModel
    {
     /// <summary>
        /// 用户表id
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 真实名称
        /// </summary>
        public string TrueName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 座机
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// qq
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 是否公开
        /// </summary>
        public string IsPublic { get; set; }
        
        }
}
