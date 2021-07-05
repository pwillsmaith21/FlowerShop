using System;
using System.Globalization;

namespace FLowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerCatalog catalog = new FlowerCatalog();
            catalog.loadDataFromXml();
            Console.ReadLine();
        }
    }
}
