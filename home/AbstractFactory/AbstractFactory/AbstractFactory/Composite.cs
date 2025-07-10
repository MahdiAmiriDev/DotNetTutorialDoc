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
        protected int Salary;

        public string GetPosition ()=> Position;

        public Employee(string name, string position,int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }


        public abstract void Display();

        public abstract int GetSalary();

    }

    class Developer: Employee
    {
        public Developer(string name, string position,int salary) : base(name, position,salary)
        {
        }

        public override void Display()
        {
            WriteLine($"{Name}-{Position}");
        }

        public override int GetSalary()
        {
            return Salary;
        }
    }

     class ContentWriter: Employee
    {
        public ContentWriter(string name, string position, int salary) : base(name, position, salary)
        {
        }

        public override void Display()
        {
            WriteLine($"{Name}-{Position}");
        }

        public override int GetSalary()
        {
            return Salary;
        }
    }

     class Manager : Employee
    {
        private List<Employee> _team = new();

        public Manager(string name, string position,int salary) : base(name, position, salary)
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

        public int GetTotalSalary()
        {
            return _team.Sum(e => e.GetSalary()) + Salary;
        }

        public override int GetSalary()
        {
            return Salary;
        }
    }


    class ManagerBuilder
    {
        private List<Manager> _managers = new();

        private ManagerBuilder _instance;

        public ManagerBuilder()
        {
            
        }

        public ManagerBuilder AddManager(Manager manager)
        {
            _managers.Add(manager);
            return this;
        }

        public ManagerBuilder AddTeamMember(string position , Employee employee)
        {
            var manager = _managers.Find(m => m.GetPosition() == position);

            manager.AddEmployee(employee);

            return this;
        }

        public static ManagerBuilder GetInstance() => new ManagerBuilder();

        public List<Manager> Build() => _managers;

        public void Display()
        {
            foreach (var item in _managers)
            {
                item.Display();
            }

        }

        public int GetTotalSalary()
        {
            return _managers.Sum(m => m.GetTotalSalary());
        }
    }
}


