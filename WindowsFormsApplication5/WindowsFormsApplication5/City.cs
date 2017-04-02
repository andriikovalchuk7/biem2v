using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class City
    {
        public string name { get; set; }
        public string major { get; set; }
        public int population { get; set; }
        public int area { get; set; }
        public City(string name, string major = "", int population = 0, int area = 0)
        {
            this.name = name;
            this.major = major;
            this.population = population;
            this.area = area;
        }
    }
}
