﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class Computer:Product
    {
        public override double GetDiscount(double amount)
        {
            return base.GetDiscount(amount) - 40;
        }
    }
}
