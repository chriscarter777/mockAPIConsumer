using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockAPIConsumer.Models;

namespace MockAPIConsumer.Interface
{
    public interface IApiRepository
    {
        IEnumerable<Place> GetAll();
        string GetAllRaw();
        Place Get(int id);
        void Post(Place place);
        void Delete(int id);
        void Put(Place place);
    }
}
