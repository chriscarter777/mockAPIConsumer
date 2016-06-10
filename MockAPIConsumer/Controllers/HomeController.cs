using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MockAPIConsumer.Models;
using MockAPIConsumer.Content;
using System.Runtime.Serialization;
using System.IO;
using Ninject;
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

        private Uri resource = new Uri("http://places.cscarter.net/api/web");

        public ViewResult Index()
        {
            //var client = new WebClient();
            //var response = client.DownloadString(resource);
            
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Place));
            //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(response)))
            //{
                //var places = (Place)serializer.ReadObject(ms);
            //}
            return View("Index", Data.places);
        }

        public ViewResult GetJson()
        {
            string lookImJson = "some JSON object";
            return View("JsonResponse", lookImJson);
        }

        public ViewResult GetXml()
        {
            string lookImXml = "some XML object";
            return View("XmlResponse", lookImXml);
        }

        public ViewResult Dashboard()
        {
            return View();
        }

        public ViewResult Edit(int id)
        {
            //get the record
            //add the record to the View return below
            return View("Edit", Data.places[id]);
        }

        [HttpPost]
        public ViewResult Edit(Place place)
        {
            //put the record
            Data.places[place.Id] = place;
            return View("Index", Data.places);
        }

        public ViewResult Delete(int id)
        {
            //get the record
            //delete the record
            Data.places.RemoveAt(id);
            return View("Index", Data.places);
        }

        public ViewResult Add()
        {
            int newId = Data.places.Count;
            return View("Add", new Place() { Id = newId, Name="put name here", Population=-1 });
        }

        [HttpPost]
        public ViewResult Add(Place place)
        {
            //post the record
            Data.places.Add(place);
            return View("Index", Data.places);
        }
    }
}