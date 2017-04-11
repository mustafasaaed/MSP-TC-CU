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
    }
}
