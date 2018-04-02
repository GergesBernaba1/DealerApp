using DealerPlusApp.Data;
using DealerPlusApp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealerPlusApp.Web.Controllers
{
    public class EmployeeController : Controller
    {
        //

        IEmployeeService _employeeService;
        // testing kareeem mostafa pull
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: /Employee/
        public ActionResult Index()
        {
            IEnumerable<Employee> employees=  _employeeService.GetAll();
            return View();
        }

        //
        // GET: /Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
