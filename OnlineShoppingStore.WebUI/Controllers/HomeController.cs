using OnlineShoppingStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private EFDbContext db = new EFDbContext();

        // GET: Home
        public ActionResult Index(string searchBy, string search)
        {
            var products = from m in db.Products
                           select m;
            if (!String.IsNullOrEmpty(searchBy))
            {
                products = products.Where(s => s.Name.Contains(searchBy));
            }

            return View(products);
        }
    }
}