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
    /// 表示对 <c>ProductSaleSpecification</c> 领域模型的实体类型配置。
    /// </summary>
    public class ProductSaleSpecificationEntityTypeConfiguration : EntityTypeConfiguration<ProductSaleSpecification>
    {
        /// <summary>
        /// 初始化 <c>ProductSaleSpecificationEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public ProductSaleSpecificationEntityTypeConfiguration()
        {
            base.Property(m => m.SpecificationTypeName)
                .HasMaxLength(10)
                .IsRequired();
            base.Property(m => m.SpecificationPropertyValue)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
