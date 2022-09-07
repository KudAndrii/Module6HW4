using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Interfaces;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) => _employeeService = employeeService;

        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _employeeService.Get();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var employee = _employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _employeeService.Post(employee);
            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee employee = _employeeService.GetById(id);
            return View("Create", employee);
        }

        // POST: EmployeeController/Edit
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            _employeeService.Put(employee);
            return RedirectToAction("Index");
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
