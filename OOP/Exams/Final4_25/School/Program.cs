namespace School
{
    public class Person
    {
        public string Name;
        public int ID;

        public Person(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public virtual void DisplayInfo() { }
    }
    public class Student : Person
    {
        public double GPA;
        public string Level;

        public Student(string name, int id, double gpa, string level) 
            : base(name, id)
        {
            GPA = gpa;
            Level = level;
        }

        public override void DisplayInfo() 
        {
            Console.WriteLine($"""
                Role : Student 
                Name: {base.Name}
                ID: {base.ID}
                GPA: {GPA}
                Level: {Level}
                """);
        }
    }
    public class Teacher : Person
    {
        public double Salary;
        public string Subject;

        public Teacher(string name, int id, double salary, string sub)
            : base(name, id)
        {
            Salary = salary;
            Subject = sub;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"""
                Role : Teacher 
                Name: {base.Name}
                ID: {base.ID}
                Salary: {Salary}
                Subject: {Subject}
                """);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Student("Mohammed Ali", 3620, 3.33, "Third"),
                new Teacher("Alaa Hany", 6365, 9600, "Math")
            };
            
            foreach (Person person in persons)
            {
                person.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
