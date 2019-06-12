
using Quick.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick.IServices
{
    public interface IProductServices
    {
        List<Product> GetList();
    }
}
