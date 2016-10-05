using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class K19Controller : Controller
    {
        //
        // GET: /K19/

        public ActionResult Index()
        {
            var randon = new Random();
            ViewBag.NumeroDaSorte = randon.Next();
            return View();
        }

    }
}
