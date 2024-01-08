using CloudProjectTest.Models;
using CloudProjectTest.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CloudProjectTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherTrentinoService _service;

        public HomeController() {
            this._service = new WeatherTrentinoService(); 
        }

        public async Task<IActionResult> Index() {
            List<City> list = await this._service.getCities();
            return View(list.Select(c => c.localita).Order().ToList());
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city) {
            return RedirectToAction("City", new { id = city });
        }

        public async Task<IActionResult> City(string id) {
            var data = await this._service.getCity(id.Replace("%20", " "));
            return View(data.previsione.First());
        }

    }
}
