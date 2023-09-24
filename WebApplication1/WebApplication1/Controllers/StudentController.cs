using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{ 
    public class StudentController : Controller

{
    public IActionResult Index()
    {
        Student i = new Student
        {
            StuId = 5731,
            StuName = "Revathi",
            Branch = "EEE",
            Email = "revathi12@gmail.com",
            Phoneno = 934456789,
        };
        ViewBag.Message = i;
        return View();
    }

}
}

