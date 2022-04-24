using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class StandardSubscriber:BaseSubscriber
    {
        public void AccessToLimitedTitles()
        {
            Console.WriteLine("Ücretsiz içeriklere erişim izni verilmiştir!");
        }
    }
}
