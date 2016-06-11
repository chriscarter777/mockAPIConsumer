using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MockAPIConsumer.Models;

namespace MockAPIConsumer.Content
{
    public class FailureData
    {
        public static List<Place> failureMsgs = new List<Place>
            {
                new Place { Id=0, Name="Error: API access failed.", Population=0 },
            };

        public static Place failureMsg = new Place { Id=0, Name="Error: API access failed.", Population=0 };
    }
}