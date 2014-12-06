using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShiftSchedule.UI.MVC.ViewModels;
using ShiftSchedule.DAL;
using ShiftSchedule.Domain.Services;
using ShiftSchedule.Domain.Entities;
using AutoMapper;

namespace ShiftSchedule.UI.MVC.Controllers
{
    public class EmployeeController : Controller
    {
         //initialize service object
       private readonly IEmployeeService _employeeService;

       public EmployeeController(IEmployeeService employeeService)
       {
           _employeeService = employeeService;
       }

        // GET: /Employee/
        public ActionResult Index()
        {
           // return View(db.EmployeeViewModels.ToList());
           // return View(_employeeService.GetAll());
            var employeeViewModel = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(_employeeService.GetAll());
            return View(employeeViewModel);
        }

        // GET: /Employee/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var userDetails = _employeeService.GetById(id.Value);
            var user = Mapper.Map<Employee, EmployeeViewModel>(userDetails);
            return View(user);
            
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EmployeeId,FirstName,LastName,Email,DateCreated,AdminRights")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                //db.EmployeeViewModels.Add(employeeviewmodel);
                //db.SaveChanges();
                _employeeService.Create(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //EmployeeViewModel employeeviewmodel = db.EmployeeViewModels.Find(id);
            var employee = _employeeService.GetById(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            var editEmployee = Mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(editEmployee);
        }

        // POST: /Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EmployeeId,FirstName,LastName,Email,DateCreated,AdminRights")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(employeeviewmodel).State = EntityState.Modified;
                //db.SaveChanges();
                _employeeService.Update(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var employee = _employeeService.GetById(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            var deleteEmployee = Mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(deleteEmployee);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            var employee = _employeeService.GetById(id);
            _employeeService.Delete(employee);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
