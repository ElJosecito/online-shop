using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System.Collections.Generic;
using OnlineShop.Web.Models;
=======
using OnlineShop.Web.Models;
using System.Collections.Generic;
>>>>>>> 29b6fc17b0203c2669673afb10f4b95c329d334a

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
<<<<<<< HEAD
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
=======
                    SupplierID = 1,
                    CompanyName = "Uncanny",
                    ContactName = "Jose",
                    ContactTitle = "Lider",
                    Address = "SomePlace In Neverland",
                    City = "Neverland",
                    Region = "Este",
                    PostalCode = "22000",
                    Country = "EveryWhere",
                    Phone = "809-123-1234",
                    Fax = "Uncanny@gmail.com"
                }
>>>>>>> 29b6fc17b0203c2669673afb10f4b95c329d334a
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
