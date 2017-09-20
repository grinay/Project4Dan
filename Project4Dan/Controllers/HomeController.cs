using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project4Dan.Models;

namespace Project4Dan.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        //Method for Search action
        [HttpPost]
        public ActionResult Search(string title)
        {
            //Try to found topics which contain partial match
            var allTopics = db.Topics.Where(a => a.Title.Contains(title)).ToList();
            //If nothing found then say it
            if (allTopics.Count <= 0)
            {
                ViewBag.SearchResult = "Nothing found";
            }

            return View("Topics", allTopics);
        }

        //Method that return all topics in DB
        public ActionResult Topics()
        {
            return View("Topics",db.Topics.ToList());
        }
    }
}