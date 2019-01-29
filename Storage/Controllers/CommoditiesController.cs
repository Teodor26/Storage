using Storage.BussinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Storage.Models.DataModels;
using Storage.BusinessLogic.Services;

namespace Storage.Controllers
{
    public class CommoditiesController : ApiController
    {

        private readonly IProductService _commodityService;


        public CommoditiesController()
        {
            _commodityService = new ProductService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var commodity = _commodityService.GetAll();

            return Ok(commodity);
        }

        //[HttpPost]
        //public IHttpActionResult Add([FromBody]Commodity commodity)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    if (string.IsNullOrEmpty(commodity.Name))
        //        return BadRequest("Try again");
        //    return Ok();
        //}

        //[HttpGet]
        //public IHttpActionResult Delete(int id)
        //{

        //    var commodity = _commodityService.GetAll();

        //    return Ok(commodity);

        //}

        //[HttpGet]
        //public IHttpActionResult Edit(int id, Commodity commodity)
        //{

        //    if (!ModelState.IsReadOnly)
        //}

    }
}
