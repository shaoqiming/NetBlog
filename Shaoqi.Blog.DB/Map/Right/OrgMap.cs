
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shaoqi.Blog.Data.Right;

namespace Shaoqi.Blog.Map.Right
{
    public class OrgMap
    {
        public  OrgMap(EntityTypeBuilder<Org> entityMap, string schema = "dbo")
        {
            entityMap.ToTable(schema + "Right_Org");
         entityMap.HasKey(a => a.id);
            entityMap.Property(a => a.id).HasColumnName("id").IsRequired().HasMaxLength(50);
            entityMap.Property(a => a.OrgName).HasColumnName("OrgName");
            entityMap.Property(a => a.OrgCode).HasColumnName("OrgCode");
            entityMap.Property(a => a.OrgAdress).HasColumnName("OrgAdress");
            entityMap.Property(a => a.OrgPhone).HasColumnName("OrgPhone");
            entityMap.Property(a => a.IsParent).HasColumnName("IsParent");
            entityMap.Property(a => a.OrgDescrible).HasColumnName("OrgDescrible");
            entityMap.Property(a => a.ParentId).HasColumnName("ParentId");
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
