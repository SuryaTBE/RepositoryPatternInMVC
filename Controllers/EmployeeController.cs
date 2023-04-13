using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RepositoryPatternInMVC.Models;
using RepositoryPatternInMVC.Repository;

namespace RepositoryPatternInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _er;
        public EmployeeController(IEmployeeRepository er)
        {
            _er = er;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _er.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            EmployeeTbl employee=_er.GetById(id);
            return View(employee);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeTbl employee)
        {
            _er.Create(employee);
            _er.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeTbl emp=_er.GetById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeTbl employee)
        {
            _er.Edit(employee);
            _er.Save();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeTbl emp = _er.GetById(id);
            return View(emp);
        }
        public ActionResult DeleteConfirmed(int id)
        {
            _er.Delete(id);
            _er.Save();
            return RedirectToAction("Index");
        }
        
    }
}
