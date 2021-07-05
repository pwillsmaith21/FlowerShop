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
        protected List<Flower> flowerList = new List<Flower>();
        public void loadDataFromXml()
        {
            XElement xmlFile = XElement.Load(@"http://www-db.deis.unibo.it/courses/TW/DOCS/w3schools/xml/plant_catalog.xml");
            var listOfFlower = from node in xmlFile.Descendants("PLANT")
                               select node into flower
                               select new Flower(flower.Element("COMMON").Value, flower.Element("BOTANICAL").Value, ConvertToInt(flower.Element("ZONE").Value), flower.Element("LIGHT").Value, ConvertToDecimal(flower.Element("PRICE").Value));
            flowerList = listOfFlower.ToList();

        }
        public Flower Retrieveflower()
        {
            throw new NotImplementedException();
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
        public void printListofItem()
        {
            for ( int i = 0; i < flowerList.Count(); i++)
            {
                Console.WriteLine("FLower Location:" + i + 1 + flowerList.ElementAt(i));
            }
            //flowerList.ForEach(flower => Console.WriteLine(flower.ToString()));
        }
        public Flower RetrieveFLower(int location)
        {
            location += 1;
            if( location > 0 && location< flowerList.Count)
            {
                return flowerList.ElementAt(1);

            }
            else
            {
                return new Flower("null", "null", 0, "null",0.0M);
            }
            
        }

        private decimal ConvertToDecimal(string price)
        {
            String trimPrice = price.Trim('$');

            return decimal.Parse(trimPrice, NumberStyles.Currency);
        }
    }
}
