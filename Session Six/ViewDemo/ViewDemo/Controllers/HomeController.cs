using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("NotIndex");
        }



        public ActionResult List()
    {
        var albums = new List<Album>();
        for (int i = 0; i < 10; i++)
        {
            albums.Add(new Album { Title = "Title " + i });
        }



        return View(albums);
    }

    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";
        return View();
    }

    public ActionResult Contact()
    {
        return View();
    }
}
}