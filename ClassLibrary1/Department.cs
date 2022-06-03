using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        private Employee[] _employees;

        public Employee[] Employees
        {
            get { return _employees; }

        }
        public void AddEmployee(Employee employee1)
        {
            if (_employees.Length<EmployeeLimit)
            {  
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee1;
            }
            
        }

            
    }
}
