using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test/ReturnContent
        public ActionResult ReturnContent()
        {
            return Content("Hello Heros");
        }
         


        //Test/ReturnJson
        public ActionResult ReturnJson()
        {
            return Json(
                new { name = "Reko", LastName = "MSP" }, 
                JsonRequestBehavior.AllowGet);
        }

        //Test/ReturnNot
        public ActionResult ReturnNot()
        {
            //return new HttpStatusCodeResult(500);
            return HttpNotFound("Sorry !!!");
        }

        // Test/ReturnFile 
        public ActionResult ReturnFile()
        {
            return File(Server.MapPath(
                "~/Content/Site.css"), "text/css");
        }

        //Test/Search?name=Something
        public ActionResult Search(string name)
        {
            return Content(name);
        }


        // Test/Modify
        [ActionName("Modify")]
        public ActionResult Edit()
        {
            return Content("Modify Action");
        }
    }
}