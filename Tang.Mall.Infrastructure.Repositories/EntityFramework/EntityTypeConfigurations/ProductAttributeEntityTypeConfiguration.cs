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
    /// 表示对 <c>ProductAttribute</c> 领域模型的实体类型配置。
    /// </summary>
    public class ProductAttributeEntityTypeConfiguration : EntityTypeConfiguration<ProductAttribute>
    {
        /// <summary>
        /// 初始化 <c>ProductAttributeEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public ProductAttributeEntityTypeConfiguration()
        {
            base.Property(m => m.AttributeName)
                .HasMaxLength(20);

            base.Property(m => m.AttributeValue)
                .HasMaxLength(50);
        }
    }
}
