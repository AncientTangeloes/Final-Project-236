using Microsoft.AspNetCore.Mvc;
using FinalProject_HarryByrd.Models;

namespace FinalProject_HarryByrd.Controllers
{
    public class InstrumentController : Controller
    {
        private InstrumentContext context { get; set; }

        public InstrumentController(InstrumentContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(i => i.Name).ToList();
            return View("Edit", new Instrument());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(i => i.Name).ToList();
            var instrument = context.Instruments.Find(id);
            return View("Edit", instrument);
        }

        [HttpPost]
        public IActionResult Edit(Instrument instrument)
        {
            if (ModelState.IsValid)
            {
                if (instrument.InstrumentId == 0)
                {
                    context.Instruments.Add(instrument);
                }
                else
                {
                    context.Instruments.Update(instrument);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (instrument.InstrumentId == 0) ? "Add" : "Edit";
                ViewBag.Genres = context.Categories.OrderBy(i => i.Name).ToList();
                return View(instrument);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var instrument = context.Instruments.Find(id);
            return View(instrument);
        }

        [HttpPost]
        public IActionResult Delete(Instrument instrument)
        {
            context.Instruments.Remove(instrument);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
