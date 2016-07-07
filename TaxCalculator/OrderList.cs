using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class OrderList
    {
        //if we want we can create orderlist interface and declare all methods there
        //Create order//Single static class
        //add productentry and also cal tax
        
        public List<ProductListEntry> productentries = new List<ProductListEntry>();

        private List<ProductListEntry> lproduct { get; set; }
        private List<TaxTypes> lTax { get; set; }

        
        //we Can add multiple taxs, even some which doestn exists.... 

        private OrderList CreateOrder(List<ProductListEntry> productentries, List<TaxTypes> ltax)
        {
            OrderList lnew = new OrderList();
            lnew.lTax = ltax;
            lnew.lproduct = productentries;
            return lnew;
        }

        public void addProductEntries(Product product, int quantity) {
            ProductListEntry entry1 = ProductListEntry.add(product,quantity);
            productentries.Add(entry1);
        }

        public OrderList GetOrder(List<ProductListEntry> productentries, List<TaxTypes> ltax)
        {
            return CreateOrder(productentries, ltax);
        }

        public List<TaxCalculatorMethods.totalSum> TaxCalculatedList(OrderList order)
        {
            List<TaxCalculatorMethods.totalSum> lnewSum = new List<TaxCalculatorMethods.totalSum>();
            foreach (ProductListEntry tmp in order.lproduct)
            {
                TaxCalculatorMethods lnewqq = new TaxCalculatorMethods();
              //  TaxCalculatorMethods.totalSum lnew = lnewqq.costPerProductWithTax(tmp);
                lnewSum.Add(lnewqq.costPerProductWithTax(tmp));

            }
            return lnewSum;
        }
    }
}
