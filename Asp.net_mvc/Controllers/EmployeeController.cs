using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.net_mvc.Models;

namespace Asp.net_mvc.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult Details()
        {

            
            EmployeeContext1Entities context = new EmployeeContext1Entities();


            //  Employee employee = context.Employees.Single(x => x.employeeId == 1);
            Employee employee = new Employee()
            {
                employeeId = 4,
                name = "ram",
                city = "ktm",
                gender = "male"

            };

            context.Employees.Add(employee);
            context.SaveChanges();

          // Employee employee1 = context.Employees.Single(x => x.employeeId == 3);
            List<Employee> employees = context.Employees.ToList();
            return View(employees);
        }
    }
}