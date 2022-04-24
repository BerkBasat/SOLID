using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public interface IEmployeeSearch
    {
        //IEnumerable bir koleksiyon içerisinde dönerek bellek üzerinde muhafaza edilen veriler üzerinden gerekli sorgulama işlemini yapar.
        IEnumerable<Employee> GetEmployeesByPosition(Position position);
    }
}
