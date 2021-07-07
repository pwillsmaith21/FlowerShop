using System;
using System.Globalization;

namespace FLowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadLine();
        }
        public static void Start()
        {
            FlowerCatalog catalog = new FlowerCatalog();
            catalog.loadDataFromXml();
            Cart holidaFlower = new Cart(catalog);
            catalog.printListofItem();
            Flower flower = catalog.RetrieveFLower(20);
            holidaFlower.AddNewItemToCart(flower);
            holidaFlower.AddNewItemToCart(catalog.RetrieveFLower(12));
            holidaFlower.checkOut();
            holidaFlower.printCart();
        }
        public static void addFLowerToCart()
        {

            throw new NotImplementedException();
        }
        }
    }
