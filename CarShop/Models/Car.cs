using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Car
    {
        public int id { get; set; }
        public  string brand { get; set; }
        public string model { get; set; }
        public string user { get; set; }
        public int price { get; set; }
        public string details { get; set; }

        public Car()
        {
                
        }

    }
}
