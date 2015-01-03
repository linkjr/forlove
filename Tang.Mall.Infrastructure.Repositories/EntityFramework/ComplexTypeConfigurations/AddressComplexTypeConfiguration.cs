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
    /// 表示对 <c>Address</c> 的复杂类型配置。
    /// </summary>
    public class AddressComplexTypeConfiguration : ComplexTypeConfiguration<Address>
    {
        /// <summary>
        /// 初始化 <c>AddressComplexTypeConfiguration</c> 类的新实例。
        /// </summary>
        public AddressComplexTypeConfiguration()
        {
            base.Property(m => m.Country)
                .HasColumnName("Country")
                .HasMaxLength(50);

            base.Property(m => m.Province)
                .HasColumnName("Province")
                .HasMaxLength(50);

            base.Property(m => m.City)
                .HasColumnName("City")
                .HasMaxLength(50);

            base.Property(m => m.District)
                .HasColumnName("District")
                .HasMaxLength(50);

            base.Property(m => m.Street)
                .HasColumnName("Street")
                .HasMaxLength(50);

        }
    }
}
