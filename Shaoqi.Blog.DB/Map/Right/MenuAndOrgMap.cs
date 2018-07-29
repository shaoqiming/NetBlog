
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.Map.Right
{
    public class MenuAndOrgMap
    {
        public MenuAndOrgMap(EntityTypeBuilder<MenuAndOrg> entityMap, string schema = "dbo")
        {
            entityMap.ToTable(schema + "Right_MenuAndOrg");
            entityMap.HasKey(a => a.FID);
            entityMap.Property(a => a.FID).HasColumnName("FID").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.OrgId).HasColumnName("OrgId");
            entityMap.Property(a => a.MenuId).HasColumnName("MenuId");
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
