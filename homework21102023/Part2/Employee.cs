using System.Collections.Generic;

namespace Part2
{
    class Employee
    {
        public string name { get; set;  }
        public Employee directSupervisor { get; set; }
        public List<Employee> subordinates { get; set; }

        public Employee(string Name)
        {
            name = Name;
            subordinates = new List<Employee>();
        }
    }
}