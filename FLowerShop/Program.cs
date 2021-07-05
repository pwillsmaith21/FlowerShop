using System;
using System.Globalization;

namespace FLowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        public static void Start()
        {
            FlowerCatalog catalog = new FlowerCatalog();
            catalog.loadDataFromXml();
            Console.ReadLine();
            Cart holidaFlower = new Cart();
            catalog.printListofItem();
            Flower flower = catalog.RetrieveFLower(2);
            holidaFlower.AddNewItemToCart(flower);
        }
        public static void addFLowerToCart()
        {

            throw new NotImplementedException();
        }
        }
    }
