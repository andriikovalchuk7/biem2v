using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Country
    {
        public string name { get; set; }
        public List<City> cities;
        public Country(string name)
        {
            this.name = name;
            cities = new List<City>();
        }
    }
}
