
namespace WebAppMVC.Services
{
    using System.Collections.Generic;
    using WebAppMVC.Interfaces;
    using WebAppMVC.Models;

    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee(0, "Andrew", 20));
            _employees.Add(new Employee(1, "Vasya", 21));
            _employees.Add(new Employee(2, "Dima", 22));
        }

        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        public Employee GetById(int id)
        {
            if (id >= 0)
            {
                return _employees.FirstOrDefault(e => e.id == id);
            }
            else
            {
                throw new ArgumentException("Id can't be negative.");
            }
        }

        public int Post(Employee employee)
        {
            if (!_employees.Contains(employee))
            {
                _employees.Add(employee);
                return _employees.FirstOrDefault(e => e.id == employee.id).id;
            }
            else
            {
                return -1;
            }

        }

        public int Put(Employee employee)
        {
            int index = _employees.IndexOf(employee);
            if (index == -1)
            {
                _employees.Add(employee);
            }
            else
            {
                _employees[index] = employee;
            }

            return index;
        }

        public bool Delete(int id)
        {
            return _employees.Remove(GetById(id));
        }
    }
}
