using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.API.Controllers
{
    public class PricesController : Controller
    {
        // GET: PricesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PricesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PricesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PricesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PricesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PricesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PricesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PricesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
