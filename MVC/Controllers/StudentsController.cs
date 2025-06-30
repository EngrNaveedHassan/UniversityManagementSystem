using BLL.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IService<Student> _studentService;

        public StudentsController(IService<Student> studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            Task<List<Student>> students = _studentService.Read();

            return View();
        }
    }
}
