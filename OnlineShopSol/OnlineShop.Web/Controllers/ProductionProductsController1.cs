using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineShop.Web.Models;
using System.Text;

namespace OnlineShop.Web.Controllers
{
    namespace OnlineShop.Web.Controllers
    {
        public class SuppliersController : Controller
        {
            HttpClientHandler handler = new HttpClientHandler();
            private readonly ILogger<SuppliersController> logger;
            private readonly IConfiguration configuration;
            private readonly string urlBase;

            public SuppliersController(ILogger<SuppliersController> logger, IConfiguration configuration)
            {
                this.logger = logger;
                this.configuration = configuration;
                this.urlBase = this.configuration["apiCofing:apiBase"];

            }


            // GET: SuppliersController
            public async Task<ActionResult> Index()
            {
                SuppliersListResponse suppliersList = new SuppliersListResponse();

                try
                {
                    using (var HttpClient = new HttpClient(this.handler))
                    {
                        var response = await HttpClient.GetAsync($"{this.urlBase}/Suppliers");

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
                catch (Exception ex)
                {
                    this.logger.LogError("Error al obtener los suplidores.", ex.ToString());
                }

                return View();
            }

            // GET: SuppliersController/Details/5
            public async Task<ActionResult> Details(int id)
            {

                SupplierDetailResponse detailResponse = new SupplierDetailResponse();

                try
                {
                    using (var HttpClient = new HttpClient(this.handler))
                    {
                        var response = await HttpClient.GetAsync($"{this.urlBase}/Suppliers/{id}");

                        if (response.IsSuccessStatusCode)
                        {
                            string apiResult = await response.Content.ReadAsStringAsync();


                            detailResponse = JsonConvert.DeserializeObject<SupplierDetailResponse>(apiResult);

                        }
                        else
                        {

                        }
                    }

                    return View(detailResponse.data);

                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error al obtener el suplidor.", ex.ToString());
                }

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
            public async Task<ActionResult> Create(SupplierCreateRequest createRequest)
            {
                CommandResponse commandResponse = new CommandResponse();

                try
                {
                    createRequest.Creation_Date = DateTime.Now;
                    createRequest.Creation_User = 1;

                    using (var HttpClient = new HttpClient(this.handler))
                    {
                        StringContent request = new StringContent(JsonConvert.SerializeObject(createRequest), Encoding.UTF8, "application/json");

                        var response = await HttpClient.PostAsync($"{this.urlBase}/Suppliers/SaveSuppliers", request);

                        string apiResult = await response.Content.ReadAsStringAsync();

                        commandResponse = JsonConvert.DeserializeObject<CommandResponse>(apiResult);

                        if (response.IsSuccessStatusCode)
                        {

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = commandResponse.message;
                            return View();
                        }

                    }


                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error al guardar el suplidor.", ex.ToString());

                    return View();
                }
            }

            // GET: SuppliersController/Edit/5
            public async Task<ActionResult> Edit(int id)
            {
                SupplierDetailResponse detailResponse = new SupplierDetailResponse();

                try
                {
                    using (var HttpClient = new HttpClient(this.handler))
                    {
                        var response = await HttpClient.GetAsync($"{this.urlBase}/Suppliers/{id}");

                        if (response.IsSuccessStatusCode)
                        {
                            string apiResult = await response.Content.ReadAsStringAsync();

                            detailResponse = JsonConvert.DeserializeObject<SupplierDetailResponse>(apiResult);

                        }
                        else
                        {

                        }
                    }

                    return View(detailResponse.data);

                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error al obtener el suplidor.", ex.ToString());
                }

                return View();
            }

            // POST: SuppliersController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Edit(SupplierUpdateRequest supplierUpdate)
            {
                CommandResponse commandResponse = new CommandResponse();

                try
                {
                    supplierUpdate.Modify_Date = DateTime.Now;
                    supplierUpdate.Modify_User = 1;

                    using (var HttpClient = new HttpClient(this.handler))
                    {
                        StringContent request = new StringContent(JsonConvert.SerializeObject(supplierUpdate), Encoding.UTF8, "application/json");

                        var response = await HttpClient.PostAsync($"{this.urlBase}/Suppliers/UpdateSuppliers", request);

                        string apiResult = await response.Content.ReadAsStringAsync();

                        commandResponse = JsonConvert.DeserializeObject<CommandResponse>(apiResult);

                        if (response.IsSuccessStatusCode)
                        {

                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            ViewBag.Message = commandResponse.message;
                            return View();
                        }

                    }
                }
                catch (Exception ex)
                {
                    this.logger.LogError("Error al editar el suplidor.", ex.ToString());
                    return View();
                }
            }


        }
    }