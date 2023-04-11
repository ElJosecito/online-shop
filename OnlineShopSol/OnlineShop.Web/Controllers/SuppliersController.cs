using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.Web.Models;
using OnlineShop.Web.Models.Response;
using System.Collections.Generic;


namespace OnlineShop.Web.Controllers
{
    public class SuppliersController : Controller
    {
        HttpClientHandler handler = new HttpClientHandler();
        private readonly ILogger<SuppliersController> logger;
        private readonly IConfiguration configuration;

        public SuppliersController(ILogger<SuppliersController> logger, IConfiguration configuration)
        {
            this.logger = logger;
            this.configuration = configuration;
        }


        // GET: SuppliersController
        public async Task<ActionResult> Index()
        {
            SuppliersListResponse suppliersList = new SuppliersListResponse();

            try
            {
                using (var HttpClient = new HttpClient(this.handler))
                {
                    var response = await HttpClient.GetAsync("https://localhost:7222/api/Suppliers");

                    if (response.IsSuccessStatusCode)
                    {
                        string apiResult = await response.Content.ReadAsStringAsync();

                       
                            suppliersList = JsonConvert.DeserializeObject<SuppliersListResponse>(apiResult);
                        
                    }
                    else
                    {

                    }
                }

                return View(suppliersList.data);
            }
            catch(Exception ex) 
            {
                this.logger.LogError("Error al obtener los suplidores.", ex.ToString());
            }

           return View();
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

        
    }
}
