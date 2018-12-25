using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mysoft.Demo.Web.Models.DBConfig
{
    /// <summary>
    /// 数据库对象管理
    /// </summary>
    public class DemoContext : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        { }
        /// <summary>
        /// 材料列表
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// 材料分类表
        /// </summary>
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
