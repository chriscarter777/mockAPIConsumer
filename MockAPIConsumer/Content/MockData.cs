using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPIConsumer.Models;

namespace MockAPIConsumer.Content
{
    public class MockData
    {
        public static List<Place> places = new List<Place>
            {
                new Place { Id=0, Name="Milwaukie", Population=666 },
                new Place { Id=1, Name="St. Paul", Population=111 }
            };


    }
}