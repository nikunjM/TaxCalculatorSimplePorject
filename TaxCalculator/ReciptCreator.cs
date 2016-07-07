using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class ReciptCreator
    {

        public void createRecipt(List<OrderList> lorders, StringBuilder lstring)
        {
            int i = 1;
            OrderList lnewOrder = new OrderList();
            foreach (OrderList tmp in lorders)
            {
                start(lstring, i);
                printProductSection(lnewOrder.TaxCalculatedList(tmp), lstring);
                end(lstring);
                i++;
            }
        }
        private void start(StringBuilder lstring, int i)
        {
            lstring.AppendFormat("--------------OUTPUT " + i + " -----------");
            lstring.AppendLine();

        }
        private void end(StringBuilder lstring)
        {
            lstring.AppendFormat("--------------END-----------");
            lstring.AppendLine();
        }
        private void printProductSection(List<TaxCalculatorMethods.totalSum> lproducts, StringBuilder lstring)
        {
            decimal totalval = 0;
            decimal totaltax = 0;
            foreach (TaxCalculatorMethods.totalSum tmp in lproducts)
            {
                lstring.AppendFormat(""     + tmp.quantity);
                lstring.AppendFormat(" "    + tmp.productname);
                lstring.AppendFormat(" :"   + Math.Round(tmp.totalValueWithTax,2));
                lstring.AppendLine();
                totalval += tmp.totalValueWithTax;
                totaltax += tmp.totalTax;
            }
            lstring.AppendFormat("Sales  Tax: " + Math.Round(totaltax,2));
            lstring.AppendLine();
            lstring.AppendFormat(" Total Val: " + Math.Round(totalval, 2));
            lstring.AppendLine();

        }
    }
}
