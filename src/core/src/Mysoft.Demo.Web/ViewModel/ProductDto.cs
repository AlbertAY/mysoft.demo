using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mysoft.Demo.Web.ViewModel
{
    /// <summary>
    /// 材料DTO
    /// </summary>
    public class ProductDto
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

        /// <summary>
        /// 产品名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string ProductName { set; get; }
        /// <summary>
        /// 单位
        /// </summary>
        [MaxLength(10)]
        public string Unit { set; get; }

        /// <summary>
        /// 价格
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public decimal CurrentPrice { set; get; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [MaxLength(800)]
        public string Pictures { set; get; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [MaxLength(80)]
        public string ProviderName { set; get; }

        /// <summary>
        /// 默认为null
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Remark { set; get; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { set; get; }




    }
}
