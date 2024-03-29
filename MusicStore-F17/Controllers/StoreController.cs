﻿using MusicStore_F17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore_F17.Controllers
{
    public class StoreController : Controller
    {
        //add db connection
        MusicStoreModel db = new MusicStoreModel();

        // GET: Store
        public ActionResult Index()
        {
            //mock up some album data and pass that to the view
            //var genres = new List<Genre>();

            //for(int i=0;i <= 10; i++)
            //{
            //    genres.Add(new Genre { Name = "Genre " + i });
            //}
            //ViewBag.genres = genres;

            //use the connection and Genre model to query the genre table
            var genres = from g in db.Genres
                         orderby g.Name ascending
                         select g;

            ViewBag.Message = "Please select a genre";
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            //use our Album model to display the related albums
            var selectedGenre = db.Genres.Include("Albums").Single(g => g.Name == genre);
            
            // Send genre back to the View
            ViewBag.Genre = genre;
            return View(selectedGenre);
        }
    }
}