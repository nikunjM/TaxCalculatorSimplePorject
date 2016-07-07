using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxCalculatorMethods
    {
        public List<TaxTypes> ltax=new List<TaxTypes>();
        public void addtaxtypes( params TaxTypes[] types) {
            for (int i = 0; i < types.Length; i++)
            {
                ltax.Add(types[i]);
            }
        }

        //Check produc type based on type
        private Boolean isExemted(ProductListEntry lpro) {
            if (lpro._product._productType == ProductType.BOOK || lpro._product._productType == ProductType.MEDICAL || lpro._product._productType == ProductType.FOOD) 
            {
                return true;
            }
           return false;
        }
        private Boolean isimported(ProductListEntry lpro)
        {
            if (lpro._product._isImported == ProductProduction.IMPORTED)
            {
                return true;
            }
            return false;
        }
        public totalSum costPerProductWithTax(ProductListEntry lpro)
        {
            bool isExemp= isExemted(lpro);
            bool isimp = isimported(lpro);
            totalSum total = new totalSum();
            total.productname = lpro._product._name;
            total.quantity = lpro._quantity;
            decimal totalTax=0;
            decimal salestax = 10 / 100;
            decimal import = 5 / 100;
            decimal OriganlPrice = lpro._price;
            if (!isExemp){
                totalTax += 10;
                total.salesTax= lpro._price*salestax;
            }
            if (isimp) {
                totalTax += 5;
                total.importTax = lpro._price * import;
            }
            total.totalValueWithTax = lpro._price + lpro._price * (totalTax / 100);
            total.totalTax = total.totalValueWithTax - OriganlPrice;
            return total;
        }

        public class totalSum
        {
            public decimal totalTax;
            public string productname;
            public decimal salesTax;
            public decimal totalValueWithTax;
            public decimal importTax;
            public int quantity;
        }
        

        //public  abstract SalesTaxcal; 
        //public abstract importTaxcal;
        



            

    }
}
