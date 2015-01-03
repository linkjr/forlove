using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示规格属性领域实体的类。
    /// </summary>
    public class SpecificationProperty : Entity
    {
        /// <summary>
        /// 获取或设置规格属性的值。
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// 获取或设置规格属性的图片Url地址。
        /// </summary>
        public string ImgUrl { get; private set; }

        /// <summary>
        /// 获取或设置规格类别ID。
        /// </summary>
        public Guid SpecificationTypeID { get; private set; }

        /// <summary>
        /// 获取或设置对应的规格类别。
        /// </summary>
        public virtual SpecificationType SpecificationType { get; private set; }
    }
}
