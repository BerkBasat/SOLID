using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Product
    {
        public virtual double GetDiscount(double amount)
        {
            return amount - 5;
        }
    }
}
