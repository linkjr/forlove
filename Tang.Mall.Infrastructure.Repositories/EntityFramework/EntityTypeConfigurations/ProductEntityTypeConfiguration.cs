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
    /// 表示对 <c>Product</c> 领域模型的实体类型配置。
    /// </summary>
    public class ProductEntityTypeConfiguration : EntityTypeConfiguration<Product>
    {
        /// <summary>
        /// 初始化 <c>ProductEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public ProductEntityTypeConfiguration()
        {
            base.Property(m => m.ProductName)
                .HasMaxLength(50)
                .IsRequired();
            base.Property(m => m.SerialNumber)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            base.Property(m => m.CoverImg)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);
            base.Property(m => m.Remark)
                .HasMaxLength(2000);

            base.HasMany(m => m.ProductSales);
            base.HasMany(m => m.ProductAttributes);
        }
    }
}
