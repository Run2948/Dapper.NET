using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public DateTime CreateTime { get; set; }
    }

    [Serializable]
    public class ProductMapper : ClassMapper<Product>
    {
        public ProductMapper()
        {
            base.Table("Product");
            //Map(f => f.UserID).Ignore();//设置忽略
            Map(f => f.Id).Key(KeyType.Identity);//设置主键  (如果主键名称不包含字母“ID”，请设置)           
            AutoMap();
        }
    }
}
