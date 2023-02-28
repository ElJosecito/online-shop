using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OnlineShop.Web.Models;

namespace OnlineShop.Web.Controllers
{
    public class CategoriesController1 : Controller
    {
        // GET: CategoriesController1
        public ActionResult Index()
        {
            List<CategoriesModel> categories = new List<CategoriesModel>()
            {

                new CategoriesModel()
                {

                 CategoryId = 1, CategoryName = "Playstation 5",
                    Description = "Tres Controles"
                },
                new CategoriesModel() {

                  CategoryId = 2, CategoryName = "Xbox 360",
                    Description = "Cuatro juegos"

                },
                new CategoriesModel() {

                  CategoryId = 3, CategoryName = "Playstation 4 ",
                    Description = "Todos sus componentes"

                },
            };

            return View(categories);
        }
        // GET: CategoriesController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController1/Create
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

        // GET: CategoriesController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController1/Edit/5
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

        // GET: CategoriesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController1/Delete/5
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
