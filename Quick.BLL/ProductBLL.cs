using Quick.DAL;
using Quick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.BLL
{
    public class ProductBLL
    {
        protected readonly ProductDAL _dalProduct;
        public ProductBLL()
        {
            _dalProduct = new ProductDAL();
        }

        public List<Product> GetList()
        {
            return _dalProduct.GetList();
        }
    }
}
