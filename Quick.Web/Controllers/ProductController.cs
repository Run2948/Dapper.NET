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
        //protected readonly IProductServices productServices;

        //public ProductController(IProductServices productServices)
        //{
        //    _productServices = productServices;
        //}

        public IProductServices _productServices { get; set; }

        // GET: Product
        public ActionResult Index()
        {
            var list = _productServices.GetList();
            return View(list);
        }

    }
}