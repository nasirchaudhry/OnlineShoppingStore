using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Concrete;
using OnlineShoppingStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //private readonly IProductRepaository repository = new IProductRepaository();
        
        private readonly IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo) 
        {
            repository = repo;
        }
                
            //var products = from m in db.Products
            //             select m;
            //if (searchBy == "Category")
            //{
            //    return View(db.Products.Where(x => x.Category == search || search == null).ToList());
            //}
            //else
            //{
            //    return View(db.Products.Where(x => x.Name.StartsWith(search)).ToList());
            //}

        public ViewResult List(string category, int page = 1) 
        {
            ProductsListViewModel model = new ProductsListViewModel 
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take (PageSize),
                PagingInfo = new PagingInfo 
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? 
                            repository.Products.Count() : 
                            repository.Products.Where(p => p.Category == category).Count()
                },
                CurrentCategory = category
            };
            

            return View(model);
        }        
    }
}