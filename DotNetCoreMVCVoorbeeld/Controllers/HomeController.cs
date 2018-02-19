using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace DotNetCoreMVCVoorbeeld.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "SpiNAZI" };
        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : " Goeie nammiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {

            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente)) { }
            ViewBag.Zoekresultaat = $"De gezochte groente is" +
                                    $" {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            return View();
        }

        public ViewResult Student() {
            List<Student> studenten = new List<Student>
            {
                new Student{Id=1, Naam="Robbe Senesael", AfstudeerGraad=Graad.Voldoening},
                 new Student{Id=2, Naam="Arno Willems", AfstudeerGraad=Graad.Onderscheiding}
            };

            ViewBag.Studenten = studenten;
            return View();
        }
    }
}