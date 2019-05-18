﻿using JqueryApp.Models;
using System.Linq;
using System.Web.Mvc;

namespace JqueryApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDBContext ctx = new EmployeeDBContext();
            return View(ctx.Employees.ToList());
        }

        public PartialViewResult _AddEmployee()
        {
            return PartialView("~/Views/Home/_AddEmployee.cshtml", new Employee());
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            using (EmployeeDBContext ctx = new EmployeeDBContext())
            {
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index"); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}