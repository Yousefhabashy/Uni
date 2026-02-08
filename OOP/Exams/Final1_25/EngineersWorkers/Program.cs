using System.Security.Cryptography;
using System.Xml.Linq;

namespace EngineersWorkers
{
    public class Employee 
    {
        private string _id;
        private string _name;
        private int _workingHours;
        public Employee(string id, string name, int workingHours)
        {
            _id = id;
            _name = name;
            _workingHours = workingHours;
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int WorkingHours
        {
            get { return _workingHours; }
            set { _workingHours = value; }
        }

        public virtual void displayInfo()
        {
        }
    }
    public class Engineer : Employee
    {
        private string _departmentID;
        private double _salary;

        public Engineer(string id, string name, int workingHours, string department, double salary) 
            :base(id, name, workingHours)
        {
            _departmentID = department;
            _salary = salary;
        }
        public override void displayInfo()
        {
            Console.WriteLine($"""
                Role: Engineer
                Name: {Name}
                ID: {ID}
                Department: {_departmentID}
                Working Hours: {WorkingHours}
                Salary: {_salary}
                """);
        }
    }

    public class Worker : Employee 
    {
        private string _shiftID;
        private double _salary;

        public Worker(string id, string name, int workingHours, string shift, double salary)
            : base(id, name, workingHours)
        {
            _shiftID = shift;
            _salary = salary;
        }
        public override void displayInfo()
        {
            Console.WriteLine($"""
                Role: Worker
                Name: {Name}
                ID: {ID}
                Department: {_shiftID}
                Working Hours: {WorkingHours} h
                Salary: {_salary} $
                """);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Engineer("E001", "MR Robot", 40, "D101", 85000),
                new Engineer("E002", "Klaus Mikealson", 45, "D102", 92000),
                new Engineer("E003", "Batman", 40, "D101", 88000),
                new Worker("W001", "Dexter Morgan", 40, "S1", 45000),
                new Worker("W002", "Damon Salvatore", 38, "S2", 42000),
                new Worker("W003", "Frank Castle", 40, "S1", 46000),
                new Worker("W004", "Rick Grimes", 36, "S3", 40000)
            };
            foreach (Employee employee in employees)
            {
                employee.displayInfo();
                Console.WriteLine();
            }
        }
    }
}
