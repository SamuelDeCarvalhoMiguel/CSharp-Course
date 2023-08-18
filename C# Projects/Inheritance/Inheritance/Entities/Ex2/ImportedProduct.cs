using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Entities.Ex2
{
    internal class ImportedProduct : Product
    {

        public double CustomFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customFee)
            : base (name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Custom fee: $ {CustomFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
