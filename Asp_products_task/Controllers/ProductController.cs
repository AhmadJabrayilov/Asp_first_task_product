using Asp_products_task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp_products_task.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string search)
        {


            List<Product> products = new List<Product>()
            {

                new Product
                {
                    Id = 1,
                    Name = "Test 1",
                    Description = "Test 1 description",
                    Image = "product1.jpg",
                    Price = 100
                    
                },
                new Product
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Test 2 description",
                    Image = "product2.jfif",
                    Price = 105

                },
                new Product
                {
                    Id = 3,
                    Name = "Test 3",
                    Description = "Test 3 description",
                    Image = "product3.jfif",
                    Price = 102

                }

            };

            if(!string.IsNullOrWhiteSpace(search))
            {
              products =  products.FindAll(p => p.Name.ToLower().Contains(search.ToLower()));
                if (products.Count == 0)
                    return NotFound();
            }

            return View(products);
        }
    }
}
