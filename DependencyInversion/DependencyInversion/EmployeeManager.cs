using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class EmployeeManager : IEmployeeSearch
    {
        private List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByPosition(Position position)
        {
            return _employees.Where(x => x.Position == position);
        }
    }
}
