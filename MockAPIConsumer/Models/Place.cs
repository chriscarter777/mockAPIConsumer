using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MockAPIConsumer.Models
{
    [DataContract]
    public class Place
    {
        [DataMember]
        [Editable(false)]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Population { get; set; }
    }
}