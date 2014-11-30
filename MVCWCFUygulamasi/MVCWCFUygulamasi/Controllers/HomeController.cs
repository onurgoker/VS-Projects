using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using MVCWCFUygulamasi.ServiceReference1;
using MVCWCFUygulamasi.Models;

namespace MVCWCFUygulamasi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ServiceAdventureWorksClient client = new ServiceAdventureWorksClient("BasicHttpBinding_IServiceAdventureWorks");
            string adresAdi = client.GetAddressDataByID(1);
            ViewBag.Adres = adresAdi;
            return View();
        }

    }
}
