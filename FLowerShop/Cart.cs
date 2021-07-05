using System;
using System.Collections.Generic;
using System.Text;

namespace FLowerShop
{
    public class Cart : FlowerCatalog
    {
        public double total { get; set; }
        public int totalItem { get; set; }
        public decimal tax { get; set; }
        public const decimal taxPercentage = 0.0635M;
        public double subtotal { get; set; }
        private List<Flower> ShoppingCart = new List<Flower>();
        public Cart()
        {
            this.total = 0;
            this.totalItem = 0;
            this.tax = 0;

        }
        public decimal CalculateTax()
        {
            return tax * taxPercentage;

        }
        public void CalculateTotal()
        {

        }
        public bool AddNewItemToCart(Flower flower)
        {
            if (verifyItem(flower){
                ShoppingCart.Add(flower);
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
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verifyItem(Flower flower)
        {
            if (flowerList.Contains(flower){
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
