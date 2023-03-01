using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Web.Models;

namespace OnlineShop.Web.Controllers
{
    public class ProductionProductsController1 : Controller
    {
        // GET: ProductionProductsController1
        public ActionResult Index()
        {
            List<ProductionProductsModel> Production = new List<ProductionProductsModel>()
            {

                new ProductionProductsModel()
                {

                 ID = 1, Name = "MSI Zenbook 2",
                   supplierid = 1,
                   categoryid = 1,
                   unitprice = 100
                   

                },

                new ProductionProductsModel()
                {

                   ID = 2, Name = "MSI Katana 500",
                   supplierid = 2,
                   categoryid = 2,
                   unitprice = 200

                   },
            };

            return View(Production);
        }
                 
       
        // GET: ProductionProductsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductionProductsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductionProductsController1/Create
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

        // GET: ProductionProductsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductionProductsController1/Edit/5
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

        // GET: ProductionProductsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductionProductsController1/Delete/5
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
