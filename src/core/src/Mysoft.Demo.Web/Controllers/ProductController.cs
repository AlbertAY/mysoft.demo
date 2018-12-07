using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mysoft.Demo.Web.Models;
using Mysoft.Demo.Web.Models.DBConfig;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mysoft.Demo.Web.Controllers
{
    /// <summary>
    /// 材料接口
    /// </summary>
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private DemoContext _context;

        public ProductController(DemoContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> Get()
        {

            IEnumerable<Product> data = _context.Products.AsEnumerable();
            return data;

        }

        /// <summary>
        /// ID获取指定业务对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Product Get(Guid id)
        {

            Product data = _context.Products.FirstOrDefault(it => it.ProductGUID == id);
            return data;

        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 上传
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
