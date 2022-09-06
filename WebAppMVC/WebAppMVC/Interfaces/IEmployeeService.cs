
namespace WebAppMVC.Interfaces
{
    using WebAppMVC.Models;
    public interface IEmployeeService
    {
        /// <summary>
        /// Method returns list of Employees.
        /// </summary>
        /// <returns>List of employees.</returns>
        public IEnumerable<Employee> Get();

        /// <summary>
        /// Method returns employee by given id.
        /// </summary>
        /// <param name="id">Given id.</param>
        /// <returns>Found employee.</returns>
        public Employee GetById(int id);

        /// <summary>
        /// Method adds given employee to the list.
        /// </summary>
        /// <param name="employee">Given employee.</param>
        /// <returns>Id of added employee; otherwise, -1.</returns>
        public int Post(Employee employee);

        /// <summary>
        /// Method adds given employee if list don't contains it, or modify existing item.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Index of modifyed item, or -1 if given employee was added.</returns>
        public int Put(Employee employee);

        /// <summary>
        /// Method removes employee by given id from list.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if element was removed; otherwise, false.</returns>
        public bool Delete(int id);
    }
}
