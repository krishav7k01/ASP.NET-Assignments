using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeManager manager = new EmployeeManager();
        public IActionResult Index()
        {
            
            return View(manager.GetAllEmployee());
        }
        public IActionResult EmployeeDetails(int id)
        {
            
            return View(manager.GetSingleEmployee(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                manager.AddEmployee(obj);
                return RedirectToAction("Index");
                //return View("Index", manager.GetAllEmployee());
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(manager.GetSingleEmployee(id));
        }

        [HttpPost]
        public IActionResult Edit(Employee newEmp)
        {
            manager.UpdateEmployee(newEmp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(manager.GetSingleEmployee(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            manager.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}
