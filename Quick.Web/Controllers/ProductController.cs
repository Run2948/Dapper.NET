using Quick.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quick.Web.Controllers
{
    public class ProductController : Controller
    {
        protected readonly IProductServices _iProductServices;

        public ProductController(IProductServices iProductServices)
        {
            _iProductServices = iProductServices;
        }

        // GET: Product
        public ActionResult Index()
        {
            var list = _iProductServices.GetList();
            return View(list);
        }
    }
}