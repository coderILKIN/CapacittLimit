using practise3.custom;
using System;
using System.Collections.Generic;
using System.Text;

namespace practise3
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] Employees = new Employee[0];
        public Department(string name,int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
        }
        public void AddEmployee(Employee employee)
        {

            if (EmployeeLimit >= Employees.Length+1  )
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException("Limiti asilib");
            }
        }
        public Employee this[int index]
        {
            get
            {
                return Employees[index];
            }
            set
            {
                Employees[index] = value;
            }
        }

    }
}
