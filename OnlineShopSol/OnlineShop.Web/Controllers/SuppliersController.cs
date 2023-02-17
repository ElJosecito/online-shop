using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineShop.Web.Models;

namespace OnlineShop.Web.Controllers
{
    public class SuppliersController : Controller
    {
        // GET: SuppliersController
        public ActionResult Index()
        {
            List<SuppliersModel> suppliers = new List<SuppliersModel>() 
            {
                new SuppliersModel()
                {
                    SupplierId = 1,
                    CompanyName = "Uncanny",
                    ContactName = "Jose Miguel",
                    ContactTitle = "Lider",
                    Address = "221B Baker Street",
                    City = "SomePlace",
                    Country = "AnyWhere",
                    Region = "East",
                    PostalCode = "22000",
                    Phone = "+123345556",
                    Fax = "ReallyKul@uncanny.com",
                    CreationDate = DateTime.Now
                },
            };

            return View(suppliers);
        }

        // GET: SuppliersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuppliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuppliersController/Create
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

        // GET: SuppliersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuppliersController/Edit/5
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

        // GET: SuppliersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuppliersController/Delete/5
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
