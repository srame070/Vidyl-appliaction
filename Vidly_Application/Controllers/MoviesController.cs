using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_Application.Models;

namespace Vidly_Application.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
           var Movie = new Movie() { ID = 1 , Name="Shrek!"};
          return View(Movie);
           //return Content("Hello world!");
          
        }
        public ActionResult Edit(int ID)
        {
            
            return Content("ID="+ ID);

        }
        public ActionResult Index(int? pageIndex, string SortBy) //Making the pageindex parameter nullable, string is anyways a reference parameter
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";
            return Content(String.Format("pageIndex={0}&SortBy{1}",pageIndex,SortBy));

           

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")] //inline attribute routing
        //
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }
    }
}