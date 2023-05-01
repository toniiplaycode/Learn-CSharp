using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExternal
{
    class Employee
    {
        public static int nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            this.Id = nextId++;
            this.Name = name;
            this.Age = age;
        }
        
        public void PrintEmployee()
        {
            Console.WriteLine($"ID: {this.Id}, Name: {this.Name}, Age: {this.Age}"); 
        }
    }
}

