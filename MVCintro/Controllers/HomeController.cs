using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;
namespace MVCintro.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "Spinazie"};

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goedemorgen" : "Goedenamiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.ZoekResultaat = "Groente niet gevonden";
            }
            else
            {
                ViewBag.ZoekResultaat = $"de gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst met naam: {groenten[Array.IndexOf(groenten, zoekGroente) + 1]}";
            }
            
            return View();
        }
        public ViewResult Studenten()
        {
            List<Student> studenten = new List<Student>
            {
                new Student {Id=23, Naam="Jefke", AfstudeerGraad= Graad.Voldoening},
                new Student {Id=23, Naam="Michiel", AfstudeerGraad=Graad.Onderscheiding}
            };
            ViewBag.Studenten = studenten;
            return View();
        }

    }
}