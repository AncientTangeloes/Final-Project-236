using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using FinalProject_HarryByrd.Models;
using System.Diagnostics.Metrics;

namespace InstrumentList.Controllers
{
    public class HomeController : Controller
    {
        private InstrumentContext context { get; set; }

        public HomeController(InstrumentContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var instruments = context.Instruments.Include(m => m.Category).OrderBy(m => m.Name).ToList();
            return View(instruments);
        }
    }
}