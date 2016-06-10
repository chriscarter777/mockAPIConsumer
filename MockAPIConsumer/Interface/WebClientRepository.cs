using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPIConsumer.Models;

namespace MockAPIConsumer.Interface
{
    public class WebClientRepository : IApiRepository
    {
        public IEnumerable<Place> GetAllJson()
        {

        }
        public IEnumerable<Place> GetAllXml()
        {

        }
        public Place GetJson(int id)
        {

        }
        public Place GetXML(int id)
        {

        }
        public void PostJson(Place place)
        {

        }
        public void PostXml(Place place)
        {

        }
        public void Delete(int id)
        {

        }
        public void PutJson(Place place)
        {

        }
        public void PutXml(Place place)
        {

        }
    }
}