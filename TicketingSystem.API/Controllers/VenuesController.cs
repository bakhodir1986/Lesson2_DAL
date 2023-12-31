using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.API.Controllers
{
    public class VenuesController : Controller
    {
        // GET: VenuesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VenuesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VenuesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VenuesController/Create
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

        // GET: VenuesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VenuesController/Edit/5
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

        // GET: VenuesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VenuesController/Delete/5
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
