using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class BaseSubscriber
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual void GiveAccessToFamilyMembers()
        {
            Console.WriteLine("Hesap paylaşımı tamamlandı!");
        }

        public virtual void AccessToLimitedTitles()
        {
            Console.WriteLine("Ücretsiz içeriklere erişim izni verilmiştir!");
        }

        public virtual void AccessToPremiumContent()
        {
            Console.WriteLine("Ücretli içeriklere erişim izni verilmiştir!");
        }
    }
}
