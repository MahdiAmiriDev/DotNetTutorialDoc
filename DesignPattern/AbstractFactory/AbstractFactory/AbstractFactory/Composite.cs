using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace AbstractFactory
{
    public abstract class Employee
    {
        protected string Name;
        protected string Position;

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }


        public abstract void Display();

    }

    class Developer: Employee
    {
        public Developer(string name, string position) : base(name, position)
        {
        }

        public override void Display()
        {
            WriteLine($"{Name}-{Position}");
        }
    }

     class ContentWriter: Employee
    {
        public ContentWriter(string name, string position) : base(name, position)
        {
        }

        public override void Display()
        {
            WriteLine($"{Name}-{Position}");
        }
    }

     class Manager : Employee
    {
        private List<Employee> _team = new();

        public Manager(string name, string position) : base(name, position)
        {
        }

        public override void Display()
        { 
            WriteLine($"{Name}-{Position}");

            foreach (var e in _team)
            {
                e.Display();
            }

        }

        public void AddEmployee(Employee e)
        {
            _team.Add(e);
        }

        public void Remove(Employee e)
        {
            _team.Remove(e);
        }
    }
}
