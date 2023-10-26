using System.Collections.Generic;
using System.Xml.Linq;

namespace Part2
{
    class Employee
    {
        public string name { get; }
        public Employee directSupervisor { get; set; }
        public List<Employee> subordinates { get; }

        public Employee(string Name)
        {
            name = Name;
            subordinates = new List<Employee>();
        }
    }
}