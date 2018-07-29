
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.Map.Right
{
    public class UserDetailMap
    {
        public  UserDetailMap(EntityTypeBuilder<UserDetail> entityMap, string schema = "dbo")
        {
            entityMap.ToTable(schema + "Right_UserDetail");
         entityMap.HasKey(a => a.UserId);
            entityMap.Property(a => a.UserId).HasColumnName("UserId").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.TrueName).HasColumnName("TrueName");
            entityMap.Property(a => a.Gender).HasColumnName("Gender");
            entityMap.Property(a => a.IDCard).HasColumnName("IDCard");
            entityMap.Property(a => a.Age).HasColumnName("Age");
            entityMap.Property(a => a.Tel).HasColumnName("Tel");
            entityMap.Property(a => a.Phone).HasColumnName("Phone");
            entityMap.Property(a => a.Email).HasColumnName("Email");
            entityMap.Property(a => a.Adress).HasColumnName("Adress");
            entityMap.Property(a => a.QQ).HasColumnName("QQ");
            entityMap.Property(a => a.Avatar).HasColumnName("Avatar");
            entityMap.Property(a => a.IsPublic).HasColumnName("IsPublic");
            entityMap.Property(a => a.IsDelete).HasColumnName("IsDelete");
            entityMap.Property(a => a.UseValue1).HasColumnName("UseValue1");
            entityMap.Property(a => a.CreateTime).HasColumnName("CreateTime");
            entityMap.Property(a => a.CreateUser).HasColumnName("CreateUser");
            entityMap.Property(a => a.UpdateTime).HasColumnName("UpdateTime");
            entityMap.Property(a => a.UpdateUser).HasColumnName("UpdateUser");
            entityMap.Property(a => a.DeleteTime).HasColumnName("DeleteTime");
            entityMap.Property(a => a.DeleteUser).HasColumnName("DeleteUser");
            entityMap.Property(a => a.TIMESSTAMP).HasColumnName("TIMESSTAMP");
            entityMap.Property(a => a.UseValue2).HasColumnName("UseValue2");
         
        }
}
}
