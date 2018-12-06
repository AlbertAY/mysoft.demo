using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mysoft.Demo.Web.Models
{
    /// <summary>
    /// 产品表
    /// </summary>
    [Table("Products")]
    public class Product
    {
        /// <summary>
        /// 产品GUID
        /// </summary>
        [Key]
        public Guid ProductGUID { get; set; }
        /// <summary>
        /// 产品编码
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ProductCode { get; set; }

    }
}
