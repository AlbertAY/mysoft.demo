using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mysoft.Demo.Web.Models
{
    /// <summary>
    /// 材料类型
    /// </summary>
    public class ProductType
    {
        /// <summary>
        /// 材料类型guid
        /// </summary>
        [Key]
        public Guid ProductTypeGUID { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { set; get; }
        /// <summary>
        /// 分类材料
        /// </summary>
        public List<Product> Products { set; get; }
    }
}
