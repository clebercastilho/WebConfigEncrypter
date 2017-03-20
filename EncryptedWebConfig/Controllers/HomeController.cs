using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EncryptedWebConfig.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var conn = System.Configuration.ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            ViewBag.ConnectionStringDecrypted = conn;

            return View();
        }
    }
}