using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示商品属性领域实体的类。
    /// </summary>
    public class ProductAttribute : Entity
    {
        #region Entity Properties

        /// <summary>
        /// 获取或设置属性ID。
        /// </summary>
        public Guid AttributeID { get; private set; }

        /// <summary>
        /// 获取或设置属性名称。
        /// </summary>
        public string AttributeName { get; private set; }

        /// <summary>
        /// 获取或设置属性值ID。
        /// </summary>
        public Guid AttributeValueID { get; private set; }

        /// <summary>
        /// 获取或设置属性值。
        /// </summary>
        public string AttributeValue { get; private set; }

        /// <summary>
        /// 获取或设置商品ID。
        /// </summary>
        public Guid ProductID { get; private set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// 获取或设置对应的商品。
        /// </summary>
        public virtual Product Product { get; private set; }

        #endregion
    }
}
