using System;
using System.Collections.Generic;
using System.Text;

namespace FLowerShop
{
    public class Flower
    {
        public string commonName { get; }
        public string botanical { get; }
        public int zone { get; }
        public string light { get;}
        public decimal price { get; set; }
        public bool availabilty { get; set; }
        public int quantity { get; set; }
        public Flower(string commonName, string botanical, int zone, string light, decimal price)
        {
            this.commonName = commonName;
            this.botanical = botanical;
            this.zone = zone;
            this.light = light;
            this.price = price;
            this.availabilty = true;
            this.quantity = 50;

        }
        public override string ToString()
        {
            
       return ( $"CommonName: {commonName}\n" +
                $"Botanical: {botanical}\n" +
                $"Zone: {zone}\n" +
                $"Light: {light}\n" +
                $"Price: {price}\n" +
                $"Available: {availabilty}\n" +
                $"Quantity: {quantity}\n");
        }





    }
}
