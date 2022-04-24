using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class PremiumSubscriber:BaseSubscriber
    {
        public void GiveAccessToFamilyMembers()
        {
            Console.WriteLine("Hesap paylaşımı tamamlandı!");
        }

        public void AccessToPremiumContent()
        {
            Console.WriteLine("Ücretli içeriklere erişim izni verilmiştir!");
        }
    }
}
