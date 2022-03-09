using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_1.Models
{
    public class Busqueda
    {
        public string site_id { get; set; }
        public string country_default_time_zone { get; set; }
        public string query { get; set; }
        public Paging paging { get; set; }
        public Results[] results { get; set; }
        public Sort sort { get; set; }
        public Available_sorts[] available_sorts { get; set; }
        public Filters[] filters { get; set; }
        public Available_filters[] available_Filters { get; set; }
        public class Paging
        {
            public string total { get; set; }
            public string primary_results { get; set; }
            public string offset { get; set; }
            public string limit { get; set; }

            public Paging()
            {

            }
        }

        public class Results
        {
            public string id { get; set; }
            public string site_id { get; set; }
            public string title { get; set; }
            public string price { get; set; }
            public Seller seller { get; set; }
            public string permalink { get; set; }

            public Results()
            {

            }
        }

        public class Seller
        {
            public string id { get; set; }
            public Seller()
            {

            }
        }

        public class Sort
        {
            public string id { get; set; }
            public string name { get; set; }
            public Sort()
            {

            }
        }

        public class Available_sorts
        {
            public string id { get; set; }
            public string name { get; set; }
            public Available_sorts()
            {

            }
        }

        public class Filters
        {
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Values[] values { get; set; }
            public Filters()
            {

            }
        }

        public class Values
        {
            public string id { get; set; }
            public string name { get; set; }
            public Path_from_root[] path_from_root { get; set; }
            public Values()
            {

            }
        }

        public class Path_from_root
        {
            public string id { get; set; }
            public string name { get; set; }

            public Path_from_root()
            {

            }
        }

        public class Available_filters
        {
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Values[] values { get; set; }
            public Available_filters()
            {

            }
        }
        
    }
}
