using Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace StorageMVC.Controllers
{
    public class CommodityController : Controller
    {

        public ICommodityApiSrvice _commodityApiSrvice = new CommodityApiService();
        // GET: Commodity

            public async Task<ActionResult> List()
        {
            var commodity = await _commodityApiSrvice.Getlist();
            return View(commodity);
        }
        
    }
}