using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Apis.Drive.v2;

namespace UploadMVC.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

      public ActionResult Upload(HttpPostedFileBase file)
      {
        string path = Server.MapPath("~/Files/"+file.FileName);
        file.SaveAs(path);
        ViewBag.Path = path;
        return View();
      }


  }
}