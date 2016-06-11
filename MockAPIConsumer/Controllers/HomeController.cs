using System.Collections.Generic;
using System.Web.Mvc;
using MockAPIConsumer.Models;
using MockAPIConsumer.Interface;

namespace MockAPIConsumer.Controllers
{
    public class HomeController : Controller
    {
        private IApiRepository repo;
        public HomeController(IApiRepository myApiConsumer)
        {
            this.repo = myApiConsumer;
        }



        public ViewResult Index()
        {
            IEnumerable<Place> places = repo.GetAll();
            return View("Index", places);
        }

        public ViewResult Dashboard()
        {
            IEnumerable<Place> places = repo.GetAll();
            foreach(Place place in places)
            {
                ViewBag.Graph1 += "<rect x=\"" + ((place.Id * 100) + 50) + "\" y=\"" + (350 - (place.Population / 10000)) + "\" width=\"50\" height=\"" + (place.Population / 10000) + "\" style=\"fill:#127CC1; stroke-width:1; stroke:rgb(0, 0, 150)\" />";
                ViewBag.Graph1 += "<text fill=\"#663300\" font-size=\"16\" font-family=\"Verdana\" x=\"" + ((place.Id * 100) + 50) + "\" y=\"380\"> " + place.Name + "</text>";
            }
            return View(places);
        }

        public ViewResult Raw()
        {
            ViewBag.Response = repo.GetAllRaw();
            return View("Raw");
        }


        public ViewResult GetOne(int id = 1)
        {
            Place place = repo.Get(id);
            return View("GetOne", place);
        }



        public ViewResult Add(int id)
        {
            return View("Add", new Place() { Id = id });
        }

        [HttpPost]
        public ViewResult Add(Place place)
        {
            repo.Post(place);
            return View("Index", repo.GetAll());
        }



        public ViewResult Delete(int id)
        {
            repo.Delete(id);
            return View("Index", repo.GetAll());
        }


        public ViewResult Edit(int id)
        {
            return View("Edit", repo.Get(id));
        }

        [HttpPost]
        public ViewResult Edit(Place place)
        {
            repo.Put(place);
            return View("Index", repo.GetAll());
        }

    }
}