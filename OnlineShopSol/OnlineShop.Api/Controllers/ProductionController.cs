using Microsoft.AspNetCore.Mvc;
using OnlineShop.BL.Contract;
using OnlineShop.BL.Services;
using OnlineShop.DAL.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionController : ControllerBase

    {
        private readonly IProductionService productionService;
        public ProductionController(IProductionService production)
        {
            this.productionService = productionService;
        }

        // GET: api/<ProductionController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.productionService.GetAll();

            return Ok(result);
        }

        // GET api/<ProductionController>/5
        [HttpGet("{id}")]
        public IActionResult GetEntity(int id)
        {
            var result = this.productionService.GetById(id);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // POST api/<ProductionsController>
        [HttpPost("SaveProduction")]
        public IActionResult Post([FromBody] ProductionSaveDto ProductionSaveDto)
        {
            var result = this.productionService.SaveProduction(productionSaveDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        // PUT api/<ProductionController>/5
        [HttpPost("UpdateProduction")]
        public IActionResult Put([FromBody] ProductionSaveDto ProductionUpdateDto)
        {
            var result = this.productionService.Updateproduction(productionUpdateDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }


        // DELETE api/<ProductionController>/5
        [HttpPut("DeleteSuppliers")]
        public IActionResult RemoveProduction([FromBody] ProductionRemoveDto productionRemoveDto)
        {
            var result = this.productionService.DeleteProduction(productionRemoveDto);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

    }
}