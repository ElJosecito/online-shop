using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Models;
using System.Collections.Generic;

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
                    SupplierID = 1,
                    CompanyName = "Uncanny",
                    ContactName = "Elian",
                    ContactTitle = "Lider",
                    Address = "SomePlace In Neverland",
                    City = "Neverland",
                    Region = "Este",
                    PostalCode = "22000",
                    Country = "EveryWhere",
                    Phone = "809-123-1234",
                    Fax = "Uncanny@gmail.com"
                }
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
