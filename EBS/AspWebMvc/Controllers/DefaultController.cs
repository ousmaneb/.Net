using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        //public ActionResult Index()
        //{
        //    return View();
        //}

      public string Index()
      {
        return "Hello World! ";
      }


      public ActionResult  ViewR()
      {
        return View();
      }

      public ActionResult Create()
      {
        return RedirectToAction("");
      }


    }
}