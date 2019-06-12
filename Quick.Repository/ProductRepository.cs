
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Model;
using Quick.Repository.Base;
using Quick.IRepository;

namespace Quick.Repository
{
    public class ProductRepository: SqlRepository<Product>, IProductRepository
    {

    }
}
