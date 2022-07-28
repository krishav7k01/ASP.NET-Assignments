using Microsoft.AspNetCore.Mvc;
using Day3.Models;
using Day3.Repositries;
using log4net;
using Day3.Filters;


namespace WebApplication30.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        IEmployeeRepo _repository;

        public HomeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        public IActionResult Index()
        {
            _logger.LogInformation("Index Is Proccesed");
            List<Employee> stList = _repository.GetAllEmployee();
            return View(stList);
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Create()
        {
            _logger.LogInformation("Create Get Is Proccesed");
            return View();
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _logger.LogInformation("Create Post Proccesed");
            _repository.AddEmployee(obj);
            return RedirectToAction("Index");
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        public IActionResult Details(int id)
        {
            _logger.LogInformation("Details Is Proccesed");
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            _logger.LogInformation("Edit Get Is Proccesed");
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _logger.LogInformation("Edit Post Is Proccesed");
            _repository.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Delete Get Is Proccesed");
            Employee obj = _repository.GetEmployeeById(id);
            return View(obj);
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            _logger.LogInformation("Delete Post Is Proccesed");
            _repository.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetEmpByDepNo()
        {
           return View();
        }

        [HttpPost]
        
        public IActionResult GetEmpByDepNo(int Depno)
        {
            List<Employee> li = _repository.GetByNo(Depno);
            return View(li);
            
        }

        [HttpGet]
        public IActionResult GetEmpByJob()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult GetEmpByJob(String Job)
        {
            List<Employee> li = _repository.GetByJob(Job);
            return View(li);

        }



    }
}