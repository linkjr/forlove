using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models
{
    /// <summary>
    /// 表示规格类别领域实体的类。
    /// </summary>
    public class SpecificationType : AggregateRoot
    {
        /// <summary>
        /// 获取或设置规格类别名称。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 获取或设置规格属性呈现方式。
        /// </summary>
        public SpecificationDisplayOptions Options { get; private set; }

        /// <summary>
        /// 获取或设置创建日期。
        /// </summary>
        public DateTime CreateDate { get; private set; }

        /// <summary>
        /// 获取或设置规格属性值集合。
        /// </summary>
        public virtual IList<SpecificationProperty> Properties { get; private set; }
    }

    /// <summary>
    /// 指定 <c>SpecificationProperty</c> 的呈现方式。
    /// </summary>
    public enum SpecificationDisplayOptions
    {
        /// <summary>
        /// 表示以文本方式呈现。
        /// </summary>
        [Description("文本")]
        Text = 1,
        /// <summary>
        /// 表示以图片方式呈现。
        /// </summary>
        [Description("图片")]
        Image
    }
}
