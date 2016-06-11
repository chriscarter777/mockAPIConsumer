using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPIConsumer.Content;
using MockAPIConsumer.Models;

namespace MockAPIConsumer.Interface
{
    public class MockRepository : IApiRepository
    {
        public IEnumerable<Place> GetAll()
        {
            return MockData.places;
        }
        public string GetAllRaw()
        {
            return MockData.places.ToString();
        }
        public Place Get(int id)
        {
            return MockData.places[id];
        }
        public void Post(Place place)
        {
            MockData.places.Add(place);
        }
        public void Delete(int id)
        {
            MockData.places.RemoveAt(id);
        }
        public void Put(Place place)
        {
            int id = place.Id;
            MockData.places[id] = place;
        }
    }
}