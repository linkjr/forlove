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
    /// 表示对 <c>SpecificationType</c> 领域模型的实体类型配置。
    /// </summary>
    public class SpecificationTypeEntityTypeConfiguration : EntityTypeConfiguration<SpecificationType>
    {
        /// <summary>
        /// 初始化 <c>SpecificationTypeEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public SpecificationTypeEntityTypeConfiguration()
        {
            base.Property(m => m.Name)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
