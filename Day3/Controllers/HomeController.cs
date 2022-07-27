using Microsoft.AspNetCore.Mvc;
using Day3.Models;
using Day3.Repositries;


namespace WebApplication30.Controllers
{
    public class HomeController : Controller
    {
        IEmployeeRepo _repository;

        public HomeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<Employee> stList = _repository.GetAllEmployee();
            return View(stList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _repository.AddEmployee(obj);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _repository.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _repository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}