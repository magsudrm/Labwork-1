using System.Collections.Generic;
using System.Data;
using Labwork_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labwork_1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

            return View(Data.sliderList);
		}
		public IActionResult Slider()
		{
			return View();
		}
	}
}
