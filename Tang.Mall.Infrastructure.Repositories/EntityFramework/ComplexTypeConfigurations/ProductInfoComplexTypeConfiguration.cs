using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tang.Mall.Domain.Models.Complex;

namespace Tang.Mall.Infrastructure.Repositories.EntityFramework.ComplexTypeConfigurations
{
    /// <summary>
    /// 表示对 <c>ProductInfo</c> 的复杂类型配置。
    /// </summary>
    public class ProductInfoComplexTypeConfiguration : ComplexTypeConfiguration<ProductInfo>
    {
        /// <summary>
        /// 初始化 <c>ProductInfoComplexTypeConfiguration</c> 类的新实例。
        /// </summary>
        public ProductInfoComplexTypeConfiguration()
        {
            base.Property(m => m.ProductID)
                .HasColumnName("ProductID");

            base.Property(m => m.ProductName)
                .HasColumnName("ProductName")
                .HasMaxLength(50)
                .IsRequired();

            base.Property(m => m.UnitPrice)
                .HasColumnName("UnitPrice")
                .HasColumnType("Money");
        }
    }
}
