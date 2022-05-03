using System;

namespace practise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("ILKIN", 21, 4000);
            Employee emp1 = new Employee("FERID", 21, 2000);
            Employee emp2 = new Employee("Arif", 21, 3000);
            Employee emp3 = new Employee("Sebuhi", 21, 4000);
           
            Department department = new Department("department",1);
            department.AddEmployee(emp);
            department.AddEmployee(emp1);
            department.AddEmployee(emp2);
            department.AddEmployee(emp2);

            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(department[0]);
        }
    }
}
