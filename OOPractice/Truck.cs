using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Truck
    {
        public Truck(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string ShowMessage()
        {
            return "Big Truck: speed up 10 km/h";
        }
    }
}
