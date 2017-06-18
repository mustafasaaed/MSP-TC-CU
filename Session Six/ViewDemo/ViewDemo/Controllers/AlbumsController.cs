using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class AlbumsController : Controller
    {
        public ActionResult Search(string q)
        {
            var albums = GetAlbumsFromDataBase();
            return View(albums);
        }

        private List<Album> GetAlbumsFromDataBase()
        {
            return new List<Album>
            {
                new Album { Title = "21" }
            };
        }

        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Album album)
        {
            if (!ModelState.IsValid)
            {
                return View(album);
            }
            return null;
        }

        public ActionResult New()
        {
            return View();
        }
    }
}
