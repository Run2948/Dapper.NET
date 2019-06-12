using Quick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetList();
    }
}
