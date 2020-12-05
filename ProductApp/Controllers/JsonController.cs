
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            string Jsonp = System.IO.File.ReadAllText(@"C:\Users\PC\source\repos\ProductApp\ProductApp\products.json");
            Product getback = JsonConvert.DeserializeObject<Product>(Jsonp);
            return View(getback);
        }
    }
}
