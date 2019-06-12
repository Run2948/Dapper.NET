
using Quick.Model;
using Quick.IRepository;
using Quick.IServices;
using Quick.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Services
{
    public class ProductServices: IProductServices
    {
        protected readonly IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetList()
        {
            return _productRepository.GetList();
        }
    }
}
