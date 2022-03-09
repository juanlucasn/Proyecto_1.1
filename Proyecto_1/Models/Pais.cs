using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyecto_1.Models
{
    public class Pais
    {
        public string id { get; set; }
        public string name { get; set; }
        public string locale { get; set; }
        public string currency_id { get; set; }
        public string decimal_separator { get; set; }
        public string thousands_separator { get; set; }
        public string time_zone { get; set; }
        public Geo_information geo_Information { get; set; }
        public States[] states { get; set; }

        public class Geo_information
        {   
            public Location location { get; set; }
            public Geo_information()
            {

            }
         }

        public class Location
        {
            public string latitude { get; set; }
            public string longitude { get; set; }

            public Location()
            {

            }
        }

        public class States
        {
            public string id { get; set; }
            public string name { get; set; }
            public States()
            {

            }
        }
    }
}
