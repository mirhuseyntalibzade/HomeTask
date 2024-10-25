using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    internal class StringModels
    {
        string[] cities;
        public StringModels()
        {
            cities = new string[0];
        }

        public void AddCity(string cityName) 
        {
            Array.Resize(ref cities, cities.Length + 1);
            cities[cities.Length - 1] = cityName;
        }

        public int this[string cityName]
        {
            get {
                return Array.IndexOf(cities, cityName);
            }
        }
    }
}
