using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TableStore.Models;

namespace TableStore.Controllers
{
    public class ProductController : Controller
    {
        //my instance of a list called _products;

        private List<Product> _products;
        //This is the constructor

        public ProductController()
        {
            //for now going to mock up my list of products

            _products = new List<Product>();
            _products.Add(new Product
            {
                ID = 1,
                Name = "Big Table",
                Description = "A big sized table",
                Image = "",
                Price = 500m

            });

            _products.Add(new Product
            {
                ID = 2,
                Name = "Medium Table",
                Description = "A medium sized table",
                Image = "",
                Price = 300m

            });

            _products.Add(new Product
            {
                ID = 3,
                Name = "Small Table",
                Description = "A small sized table",
                Image = "",
                Price = 200m

            });

        }


        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product p = _products.Single(x => x.ID == id.Value);
                return View(p);
            }
            return NotFound();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}