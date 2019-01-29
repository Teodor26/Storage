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
    public class ArrivalsController : ApiController
    {

        private IArrivalService _arrivalService;


        public ArrivalsController()
        {
            _arrivalService = new ArrivalService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var arrival = _arrivalService.GetList();

            return Ok(arrival);
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody]Arrival arrival)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);            
               
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Delete(int id)
        {

            var arrival = _arrivalService.GetList();

            return Ok(arrival);

        }


    }
}
