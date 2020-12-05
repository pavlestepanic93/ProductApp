using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext _context;

        public ProductController(IProductRepository productRepository, AppDbContext context)
        {
            _productRepository = productRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            var product = _productRepository.GetAllProducts();
            return View(product);
        }

        public IActionResult Edit(int Id)
        {
            var prd = _productRepository.GetAllProducts().Where(pr => pr.ProizvodId == Id).FirstOrDefault();
            return View(prd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
