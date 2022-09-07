
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
                return _employees.FirstOrDefault(e => e.Id == id);
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
                return _employees.FirstOrDefault(e => e.Id == employee.Id).Id;
            }
            else
            {
                throw new ArgumentException("Element already exist.");
            }

        }

        public int Put(Employee employee)
        {
            var element = GetById(employee.Id);
            int index = -1;
            if (element == null)
            {
                _employees.Add(employee);
            }
            else
            {
                index = _employees.IndexOf(element);
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
