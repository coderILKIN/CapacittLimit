using System;
using System.Collections.Generic;
using System.Text;

namespace practise3
{
    class Employee : IPerson
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set ; }
        public byte Age { get ; set ; }
        public double Salary { get; set; }
        public Employee(string name,byte age,double salary)
        {
            Id = ++_id;
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string ShowInfo()
        {
            return $"Id: {Id} Name: {Name} Age:{Age}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
