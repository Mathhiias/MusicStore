using MusicStore_F17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore_F17.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //mock up some album data and pass that to the view
            var genres = new List<Genre>();

            for(int i=0;i <= 10; i++)
            {
                genres.Add(new Genre { Name = "Genre " + i });
            }
            ViewBag.genres = genres;
            ViewBag.Message = "Please select a genre";
            return View();
        }

        // GET: Store/Browse
        public ActionResult Browse(string Genre)
        {
            // Send genre back to the View
            ViewBag.Genre = Genre;
            return View();
        }
    }
}