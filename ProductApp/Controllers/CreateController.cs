using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class CreateController : Controller
    {

        private readonly AppDbContext _context;

        public CreateController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Product pr)
        {
            _context.Add(pr);
            _context.SaveChanges();
            return View();
        }
    }
}
