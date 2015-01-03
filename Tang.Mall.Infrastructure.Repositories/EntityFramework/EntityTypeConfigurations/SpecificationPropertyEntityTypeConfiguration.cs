using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tang.Mall.Domain.Models;

namespace Tang.Mall.Infrastructure.Repositories.EntityFramework.EntityTypeConfigurations
{
    /// <summary>
    /// 表示对 <c>SpecificationProperty</c> 领域模型的实体类型配置。
    /// </summary>
    public class SpecificationPropertyEntityTypeConfiguration : EntityTypeConfiguration<SpecificationProperty>
    {
        /// <summary>
        /// 初始化 <c>SpecificationPropertyEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public SpecificationPropertyEntityTypeConfiguration()
        {
            base.Property(m => m.Value)
                .HasMaxLength(20)
                .IsRequired();
            base.Property(m => m.ImgUrl)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);
        }
    }
}
