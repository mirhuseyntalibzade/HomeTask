using Indexer.Models;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringModels cities = new StringModels();

            cities.AddCity("Berlin");
            Console.WriteLine(cities["Berlin"]);
        }
    }
}
