using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;

namespace FLowerShop
{
    public class FlowerCatalog
    {
        public List<Flower> flowerList = new List<Flower>();
        public void loadDataFromXml()
        {
            XElement xmlFile = XElement.Load(@"http://www-db.deis.unibo.it/courses/TW/DOCS/w3schools/xml/plant_catalog.xml");
            var listOfFlower = from node in xmlFile.Descendants("PLANT")
                               select node into flower
                               select new Flower(flower.Element("COMMON").Value, flower.Element("BOTANICAL").Value, ConvertToInt(flower.Element("ZONE").Value), flower.Element("LIGHT").Value, ConvertToDecimal(flower.Element("PRICE").Value));
            Console.WriteLine(listOfFlower.Count());
            foreach(var flower in listOfFlower)
            {
                Console.WriteLine(flower.ToString());
            }
        }
        public int ConvertToInt(String zone)
        {
            try
            {
                int parseInt = Int32.Parse(zone);
                return parseInt;
            }
            catch(System.FormatException e)
            {
                return 0;
            }
        
        }

        private decimal ConvertToDecimal(string price)
        {
            String trimPrice = price.Trim('$');

            return decimal.Parse(trimPrice, NumberStyles.Currency);
        }
    }
}
