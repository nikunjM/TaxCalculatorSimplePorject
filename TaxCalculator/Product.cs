using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class Product
    {
        private String name;
        public String _name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private ProductType type { get; set; }
        public ProductType _productType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        private ProductProduction isImported { get; set; }
        public ProductProduction _isImported
        {
            get
            {
                return isImported;
            }
            set
            {
                isImported = value;
            }
        }
        
        private decimal price;

        public decimal _price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        private Product(String name, decimal price, ProductType type,ProductProduction isImported)
        {
            this.name = name;
            this.price = price;
            this.type = type;
            this.isImported = isImported;
        }

        public static Product Add(String pName, decimal price, ProductType type, ProductProduction isImported)
        {
            if (price < 0) {
                throw new System.ArgumentException("Parameter cannot be less then zero", "Price");
            }
            Product lnewproduct = new Product(pName, price,type,isImported);
            return lnewproduct;
        }
    }
    //may be we can create new class
    //this will give which catogory they belong to 
    public enum ProductProduction
    {
        NOTIMPORTED,
        IMPORTED
    }
    
}
