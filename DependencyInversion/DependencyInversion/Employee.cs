using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
    }
}
