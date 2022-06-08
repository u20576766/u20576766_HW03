using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u20576766_HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase Files, string FileType )
        {

            if (Files != null && Files.ContentLength > 0 && FileType == "Documents")
            {
                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Documents"), fileName);

                Files.SaveAs(path);
            }
            else if (Files != null && Files.ContentLength > 0 && FileType == "Images")
            {
                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Images"), fileName);

                Files.SaveAs(path);
            }
            else if (Files != null && Files.ContentLength > 0 && FileType == "Videos")
            {
                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Videos"), fileName);

                Files.SaveAs(path);
            }

            return RedirectToAction("Index");
        }



        public ActionResult Files()
        {

            return View();
        }

        public ActionResult Images()
        {

            return View();
        }

        public ActionResult Videos()
        {

            return View();
        }
        public ActionResult AboutMe()
        {

            return View();
        }
    }
}