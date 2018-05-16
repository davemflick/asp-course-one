using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookApp.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            var comicBook = new Models.ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Models.Artist[]
                {
                    new Models.Artist() {Name = "Dan Slott", Role = "Script"},
                    new Models.Artist() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Models.Artist() {Name = "Victor Olazaba", Role = "Inks"},
                    new Models.Artist() {Name = "Edgar Delgado", Role = "Colors"},
                    new Models.Artist() {Name = "Chris Eliopoulos", Role = "Letters"}
                }
            };

            return View(comicBook);
        }

    }
}
