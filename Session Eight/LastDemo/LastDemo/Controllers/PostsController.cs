using LastDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastDemo.Controllers
{
    public class PostsController : Controller
    {

        private ApplicationDbContext _db = new ApplicationDbContext();

        public ActionResult AllPosts()
        {
            var posts = _db.DbPosts.ToList();
            return View(posts);
        }

        public ActionResult Post(int id)
        {
            return View(_db.DbPosts.Find(id));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.DbPosts.Add(post);
                _db.SaveChanges();
                return RedirectToAction("AllPosts"); 
            }
            return View();
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var post = _db.DbPosts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            var post = _db.DbPosts.Find(id);
            _db.DbPosts.Remove(post);
            _db.SaveChanges();
            return RedirectToAction("AllPosts");
        }
    }
}