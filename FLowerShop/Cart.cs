using System;
using System.Collections.Generic;
using System.Text;

namespace FLowerShop
{
    public class Cart : FlowerCatalog
    {
        public decimal total { get; set; }
        public int totalItem { get; set; }
        public decimal tax { get; set; }
        public const decimal taxPercentage = 0.0635M;
        public decimal subtotal { get; set; }
        private List<Flower> ShoppingCart = new List<Flower>();
        private FlowerCatalog catalog;
        public Cart(FlowerCatalog catalog)
        {
            this.catalog = catalog;
            this.total = 0;
            this.totalItem = 0;
            this.tax = 0;

        }
        public void CalculateSubtotal()
        {
            ShoppingCart.ForEach(item => this.subtotal += item.price);

        }
        public void checkOut()
        {
            CalculateSubtotal();
            CalculateTax();
            this.total = this.subtotal + this.tax;
        }
        public void  CalculateTax()
        {
            this.tax =  subtotal * taxPercentage;

        }
        public void CalculateTotal()
        {

        }
        public bool AddNewItemToCart(Flower flower)
        {
            if (verifyItem(flower))
            {
                ShoppingCart.Add(flower);
                totalItem += 1;
                return true;
            }
            else
            {
                return false;
            }
          
        }
        public bool removeItemFromCart(Flower flower)
        {
            if(verifyItem(flower))
            {
                ShoppingCart.Remove(flower);
                totalItem -= 1;

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verifyItem(Flower flower)
        {
            if (catalog.flowerList.Contains(flower))
            {
                return true;
            }
            else {
                return false;
            }
        }
        public void printCart()
        {
            // to test cart
            Console.WriteLine($"Subtotal: {subtotal}\n" +
                $"Tax: {tax}\n" +
                $"Total: {total}\n");
        }



    }
}
