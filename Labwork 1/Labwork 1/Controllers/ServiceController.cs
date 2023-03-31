using Labwork_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labwork_1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.serviceList);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
