namespace WebAppMVC.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
    }
}
