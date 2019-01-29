using Storage.BussinessLogic.Services;
using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Storage.Controllers
{
    public class PurchasesController : ApiController
    {

        private IPurchaseService _purchaseService;


        public PurchasesController()
        {
            _purchaseService = new PurchaseService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var purchase = _purchaseService.GetList();

            return Ok(purchase);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]Purchase purchase)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Delete(int id)
        {

            var purchase = _purchaseService.GetList();

            return Ok(purchase);

        }
    }
}
