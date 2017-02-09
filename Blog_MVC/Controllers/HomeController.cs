using Blog_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    public class HomeController : Controller
    {
        BPContext db = new BPContext();

        public ActionResult Index()
        {
            ViewBag.AllBlogPosts = db.BlogPosts.ToList();
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Details(int Id)
        {
            var blogPost = db.BlogPosts.Find(Id);


            return View(blogPost);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            if (blogPost.Body.Length > 100)
            {
                blogPost.SampleText = blogPost.Body.Substring(0, 100) + "...";
            }

            else
            {
                blogPost.SampleText = blogPost.Body;
            }
            blogPost.Created = DateTime.Now;
            db.BlogPosts.Add(blogPost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}