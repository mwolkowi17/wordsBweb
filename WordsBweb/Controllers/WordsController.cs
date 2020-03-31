using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordsBweb.Data;
using WordsBweb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordsAWeb.Controllers
{
    public class WordsController : Controller
    {

        private readonly WordsContext _context;
        public WordsController(WordsContext context)
        {
            _context = context;
        }

        public static string movieRoboczy;
        public Words movie = new Words();
        public static int Wynik = 0;
        public static int Ilosc = 0;

       /* public Words RandomRoboczy()
        {
            var rand = new Random();
            int testnum = rand.Next(4);
            int id = testnum + 1;
            movie = _context.WordsA.Find(id);
            movieRoboczy = movie.WordEng;
            Ilosc++;
            return movie;
        }*/

        // GET: /<controller>/
        public async Task<IActionResult> Index(string searchString)
        {
            // var rand = new Random();
            // int testnum = rand.Next(4);
            // int id = testnum + 1;
            // movie = await _context.WordsA.FindAsync(id);
            if (Ilosc < 3)
            {
                var rand = new Random();
                int testnum = rand.Next(4);
                int id = testnum + 1;
                movie = _context.WordsA.Find(id);
                movieRoboczy = movie.WordEng;
                Ilosc++;
                
                var formularz = searchString;
                if (Ilosc == 1)
                {
                    Wynik = 0;
                }
                return View(movie);
            }
            else
            {
                Ilosc = 0;
                ViewBag.Koniec = "Koniec";
                ViewBag.WyswietlWynik = "Twój wynik to: " + Wynik;
                return View("Views/Words/End.cshtml");
            }


        }
        public async Task<IActionResult> Edit()
        {
            //var rand = new Random();
            //int testnum = rand.Next(4);
            //int id = testnum+1;
            //var movie = await _context.WordsA.FindAsync(id);
            return View(movie);
        }

        public async Task<IActionResult> Search(string searchString)
        {
            string Wyswietl = searchString;

            if (searchString == movieRoboczy)
            {
                string Answer = "Dobrze";
                Wynik++;
                ViewBag.WyswietlB = Answer;
                ViewBag.WyswietlWynik = Wynik;
            }
            else
            {
                string AnswerWrong = "Źle";
                ViewBag.WyswietlB = AnswerWrong;
                ViewBag.WyswietlWynik = Wynik;
            }


            return View();
        }

        public async Task<IActionResult> End()
        {
            ViewBag.Koniec = "Koniec";
            ViewBag.WyswietlWynik = "Twój wynik to: " + Wynik;
            return View();
        }
    }
}
