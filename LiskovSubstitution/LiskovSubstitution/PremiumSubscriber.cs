using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class PremiumSubscriber:BaseSubscriber
    {
        public override void GiveAccessToFamilyMembers()
        {
            base.GiveAccessToFamilyMembers();
        }

        public override void AccessToLimitedTitles()
        {
            base.AccessToLimitedTitles();
        }

        public override void AccessToPremiumContent()
        {
            base.AccessToPremiumContent();
        }
    }
}
