using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    public class TaxTypes
    {
        public string name { get; set; }
        public double percent { get; set; }
        public decimal price { get; set; }
        //in some states some tax is not applicable... We can add applicable or not  
        public static TaxTypes add(string name, double percent) {
            TaxTypes lnewtax = new TaxTypes(name, percent);
            return lnewtax;
        }
        private TaxTypes(string name,double percent) {
            this.name=name;
            this.percent=percent;
        }


    }
}
