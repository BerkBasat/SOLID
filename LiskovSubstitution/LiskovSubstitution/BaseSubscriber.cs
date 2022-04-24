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
            Console.WriteLine("Access granted to family members");
        }

        public virtual void AccessToLimitedTitles()
        {
            Console.WriteLine("Access to limited titles granted");
        }

        public virtual void AccessToUnlimitedContent()
        {
            Console.WriteLine("Access to unlimited content");
        }
    }
}
