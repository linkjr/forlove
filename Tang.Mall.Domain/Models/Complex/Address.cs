using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tang.Mall.Domain.Models.Complex
{
    /// <summary>
    /// 表示地址信息的类。
    /// </summary>
    public class Address
    {
        /// <summary>
        /// 获取一个 <c>Address</c> 的值，该值表示一个空地址。
        /// </summary>
        public static readonly Address Empty = new Address(null, null, null, null, null);

        #region ctro

        /// <summary>
        /// 初始化 <c>Address</c> 类的新实例。
        /// </summary>
        public Address() { }

        /// <summary>
        /// 初始化 <c>Address</c> 类的新实例。
        /// </summary>
        /// <param name="country">国家。</param>
        /// <param name="province">省份/州。</param>
        /// <param name="city">市区。</param>
        /// <param name="district">区/县。</param>
        /// <param name="street">详细街道地址。</param>
        public Address(string country, string province, string city, string district, string street)
        {
            this.Country = country;
            this.Province = province;
            this.City = city;
            this.District = district;
            this.Street = district;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 获取或设置国家。
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// 获取或设置省份。
        /// </summary>
        public string Province { get; private set; }

        /// <summary>
        /// 获取或设置市区。
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// 获取或设置区/县。
        /// </summary>
        public string District { get; private set; }

        /// <summary>
        /// 获取或设置街道地址。
        /// </summary>
        public string Street { get; private set; }

        #endregion
    }
}
