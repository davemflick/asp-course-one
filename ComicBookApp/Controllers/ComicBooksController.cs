using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ComicBookApp.Data;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookApp.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                id = 1;
            }
           
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            if(comicBook == null)
            {
                id = 1;
                comicBook = _comicBookRepository.GetComicBook((int)id);
            }
            return View(comicBook);
        }

    }
}
