﻿using Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StorageMVC.Controllers
{
    public class CommodityController : Controller
    {

        public ICommodityApiSrvice commodityApiSrvice = new CommodityApiSrvice();
        // GET: Commodity
        public ActionResult Index()
        {
            return View();
        }
    }
}