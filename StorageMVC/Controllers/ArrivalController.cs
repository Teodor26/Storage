using Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageMVC.Controllers
{
    public class ArrivalController : Controller
    {
        private IArrivalApiService _arrivaApiService = new ArrivalApiService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(int? id)
        {
            return RedirectToAction("Index");
        }
    }
}