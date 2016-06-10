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
        IEnumerable<Place> GetAllJson();
        IEnumerable<Place> GetAllXml();
        Place GetJson(int id);
        Place GetXML(int id);
        void PostJson(Place place);
        void PostXml(Place place);
        void Delete(int id);
        void PutJson(Place place);
        void PutXml(Place place);
    }
}
