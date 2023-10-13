using Assignment2_SheheryarIzhar.DataManager;
using Assignment2_SheheryarIzhar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2_SheheryarIzhar.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult StudentList(int PageNumber = 1)
        {
            StudentManager studentManager = new StudentManager();
            //var students = studentManager.GetAllStudent();

            ViewBag.totalPages = Math.Ceiling(studentManager.GetAllStudent().Count() / 5.0);

            //var students = studentManager.GetAllStudent().Skip((PageNumber -1) * 5).Take(5);

            StudentManager stm = new StudentManager();
            var data = stm.GetAllStudent();

            return View(data);
        }*/
        public IActionResult StudentList()
        {
            StudentManager stm = new StudentManager();
            var data = stm.GetAllStudent();

            return View(data);
        }
        public IActionResult AddStudent(Student student)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.AddStudent(student);
            return RedirectToAction("StudentList", "Home");
        }
        public IActionResult EditStudent(Student student)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.EditStudent(student);
            return RedirectToAction("StudentList", "Home");
        }
    }
}
