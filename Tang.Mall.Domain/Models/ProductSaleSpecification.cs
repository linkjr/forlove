using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示商品销售规格领域实体的类。
    /// </summary>
    public class ProductSaleSpecification : Entity
    {
        /// <summary>
        /// 获取或设置商品销售规格类别ID。
        /// </summary>
        public Guid SpecificationTypeID { get; private set; }

        /// <summary>
        /// 获取或设置商品销售规格类别名称。
        /// </summary>
        public string SpecificationTypeName { get; private set; }

        /// <summary>
        /// 获取或设置商品销售规格属性ID。
        /// </summary>
        public Guid SpecificationPropertyID { get; private set; }

        /// <summary>
        /// 获取或设置商品销售规格属性值。
        /// </summary>
        public string SpecificationPropertyValue { get; private set; }

        /// <summary>
        /// 获取或设置商品销售ID。
        /// </summary>
        public Guid ProductSaleID { get; private set; }
    }
}
