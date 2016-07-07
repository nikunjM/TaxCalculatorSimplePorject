using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class ProductListEntry
    {
        private int quantity;
        private Product product;
        public decimal price;
        public int _quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }

        public Product _product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }
        public decimal _price 
        { 
            get
            {
                return price;
            }
            set
            {
                price= value;
            }
        }

        private ProductListEntry(Product product, int quantity,decimal price) {
            this.product = product;
            this.quantity = quantity;//based on quatity mulitply the price
            this.price = price;
        }
        
        public static ProductListEntry add(Product product, int quantity) {
            decimal lprice = multiplyPrice(product, quantity);
            ProductListEntry lnewProductList = new ProductListEntry(product, quantity, lprice);
            return lnewProductList;
        }

        private static decimal multiplyPrice(Product product, int quantity)
        {
            return   product._price * quantity;
        } 
    }
}
