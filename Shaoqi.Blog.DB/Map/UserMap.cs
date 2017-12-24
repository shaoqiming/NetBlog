using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shaoqi.Blog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.DB.Map
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityMap, string schema = "dbo")
        {
            entityMap.ToTable(schema + ".User");
            entityMap.HasKey(a => a.FID);
            entityMap.Property(a => a.FID).HasColumnName("FID").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.NickName).HasColumnName("NickName");
            entityMap.Property(a => a.Password).HasColumnName("Password");
            entityMap.Property(a => a.UpdateTime).HasColumnName("UpdateTime");
            entityMap.Property(a => a.UpdateUser).HasColumnName("UpdateUser");
            entityMap.Property(a => a.CreateTime).HasColumnName("CreateTime");
            entityMap.Property(a => a.CreateUser).HasColumnName("CreateUser");
            entityMap.Property(a => a.DeleteTime).HasColumnName("DeleteTime");
            entityMap.Property(a => a.DeleteUser).HasColumnName("DeleteUser");
            entityMap.Property(a => a.UseValue1).HasColumnName("UseValue1");
            entityMap.Property(a => a.UseValue2).HasColumnName("UseValue2");
        }
    }
}
