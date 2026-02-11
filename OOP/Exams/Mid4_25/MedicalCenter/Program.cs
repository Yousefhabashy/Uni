using System.Xml.Linq;

namespace MedicalCenter
{
    /* 
      A medical center staffed by doctors (radiology and analysis), technicians (radiology and analysis) and assistants.
    Each of them has its own personal and job information.
    Doctors receive a fixed salary, while other jobs receive a salary according to working hours. 
    Explain how the concepts of OOP can be used?
     */
    internal class Program
    {
        public class Employee
        {
            public string EmployeeName;
            public int EmployeeId;
            public string EmployeeJobTitle;

            public Employee(string name, int id, string jobTitle)
            {
                EmployeeName = name;
                EmployeeId = id;
                EmployeeJobTitle = jobTitle;
            }
            public virtual double calculateSalary()
            {
                return 0;
            }
            public void Display()
            {
                Console.WriteLine($"Name: {EmployeeName}");
                Console.WriteLine($"ID: {EmployeeId}");
                Console.WriteLine($"Job: {EmployeeJobTitle}");
                Console.WriteLine($"Salary: {calculateSalary()} $");
            }
        }
        public class Doctor : Employee
        {
            public double Salary;
            public Doctor(string name, int id, string jobTitle, double salary)
            :base(name,id,jobTitle)
            {
                Salary = salary;
            }

            public override double calculateSalary() {
                return Salary;
            }
        }

        public class Technician : Employee
        {
            public int WorkingHours;
            private double HourRate = 50;
            public Technician(string name, int id, string jobTitle, int hours)
            : base(name, id, jobTitle)
            {
                WorkingHours = hours;
            }

            public override double calculateSalary()
            {
                return HourRate * WorkingHours;
            }
        }

        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Ahmed Mamdouh", 306254, "Radiology Doctor", 13500);
            Technician tech = new Technician("Ali Mahmoud", 201, "Radiology Technician", 160);

            doctor.Display();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - ");
            Console.WriteLine();
            tech.Display();
        }
    }
}
