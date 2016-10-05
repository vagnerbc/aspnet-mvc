using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ErrorPageController : Controller
    {
        //
        // GET: /ErrorPage/
        public ActionResult NotFound()
        {
            return View();
        }
	}
}