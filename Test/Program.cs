using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = Product.Add("Book", 12.49m, ProductType.BOOK,ProductProduction.NOTIMPORTED);
            Product pro2 = Product.Add("Music cd", 14.99m, ProductType.ENTERTAINMENT, ProductProduction.NOTIMPORTED);
            Product pro3 = Product.Add("choclate bar", 0.85m, ProductType.FOOD, ProductProduction.NOTIMPORTED);


            Product pro4 = Product.Add("imported box of chocolates",10.00m, ProductType.FOOD,ProductProduction.IMPORTED);
            Product pro5 = Product.Add("imported bottle of perfume",47.50m, ProductType.ENTERTAINMENT,ProductProduction.IMPORTED);
            
            Product pro6 =  Product.Add("imported bottle of perfume",27.99m, ProductType.ENTERTAINMENT,ProductProduction.IMPORTED);
            Product pro7 =  Product.Add("bottle of perfume",18.99m, ProductType.ENTERTAINMENT,ProductProduction.NOTIMPORTED);
            Product pro8 =  Product.Add("HeadAched Pills",9.75m, ProductType.MEDICAL,ProductProduction.NOTIMPORTED);
            Product pro9 = Product.Add("imported box of chocolates",11.25m, ProductType.FOOD,ProductProduction.IMPORTED);
            

            TaxTypes salesTax = TaxTypes.add("Sales tax", 10.0);
            TaxTypes Import =  TaxTypes.add("import Duty", 5.0);
            TaxCalculatorMethods tax = new TaxCalculatorMethods();
            tax.addtaxtypes(Import, salesTax);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<TaxTypes> ltaxtype = tax.ltax;//Can we make it stactic .. ? 
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            OrderList lorder1 = new OrderList();
            lorder1.addProductEntries(pro1, 1);
            lorder1.addProductEntries(pro2, 1);
            lorder1.addProductEntries(pro3, 1);
            List<ProductListEntry> lprolist = lorder1.productentries;
            lorder1.GetOrder(lprolist, ltaxtype);


            OrderList lorder2 = new OrderList();
            lorder2.addProductEntries(pro4, 1);
            lorder2.addProductEntries(pro5, 1);
            List<ProductListEntry> lprolist2 = lorder2.productentries;
            lorder2.GetOrder(lprolist2, ltaxtype);

            OrderList lorder3 = new OrderList();
            lorder3.addProductEntries(pro6, 1);
            lorder3.addProductEntries(pro7, 1);
            lorder3.addProductEntries(pro8, 1);
            lorder3.addProductEntries(pro9, 1);
            List<ProductListEntry> lprolist3 = lorder3.productentries;
            lorder3.GetOrder(lprolist3, ltaxtype);


            List<OrderList> lorderlist = new List<OrderList>();
            lorderlist.Add(lorder1.GetOrder(lprolist, ltaxtype));
            lorderlist.Add(lorder2.GetOrder(lprolist2, ltaxtype));
            lorderlist.Add(lorder3.GetOrder(lprolist3, ltaxtype));


            StringBuilder lstring=new StringBuilder();
            ReciptCreator createRecipt = new ReciptCreator();
            createRecipt.createRecipt(lorderlist,lstring);
            String over = lstring.ToString();
        }
    }
}

/*
             * 
             * I am not sure this add should be static or not... IS this right way to do it or not
            ProductListEntry entry1 = new ProductListEntry();
            ProductListEntry entry2 = ProductListEntry.add(pro2, 1);
            ProductListEntry entry3 = ProductListEntry.add(pro3, 4);
            ProductListEntry entry4 = ProductListEntry.add(pro4, 2);
            ProductListEntry entry5 = ProductListEntry.add(pro5, 7);
            ProductListEntry entry6 = ProductListEntry.add(pro6, 1);
            */


/*
ProductListEntry entry1 = new ProductListEntry();
entry1.add(pro1,1);
entry1.add(pro2, 1);
entry1.add(pro3, 4);
entry1.add(pro4, 2);
entry1.add(pro5, 7);
entry1.add(pro6, 1);
*/
