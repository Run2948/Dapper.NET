using Quick.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quick.Web.Controllers
{
    public class ProductController : Controller
    {
        protected readonly ProductBLL _bllProduct;

        public ProductController()
        {
            _bllProduct = new ProductBLL();
        }

        // GET: Product
        public ActionResult Index()
        {
            var list = _bllProduct.GetList();
            return View(list);
        }
    }
}