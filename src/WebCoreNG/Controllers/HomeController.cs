using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCoreNG.Dal;

namespace WebCoreNG.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
    }
}
