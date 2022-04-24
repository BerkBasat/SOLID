using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class StandardSubscriber:BaseSubscriber
    {
        public override void AccessToLimitedTitles()
        {
            base.AccessToLimitedTitles();
        }

        public override void AccessToPremiumContent()
        {
            throw new InvalidOperationException("Ücretli içerikler standart abonelere kapalıdır!");
        }

        public override void GiveAccessToFamilyMembers()
        {
            throw new InvalidOperationException("Standart aboneler hesap paylaşımı yapamaz!");
        }
    }
}
