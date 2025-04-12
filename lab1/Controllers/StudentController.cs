using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
        public class StudentController : Controller
            {
        public IActionResult listAll()
        {
            List<Student> ListStudents = new List<Student>()
            {
                new Student{ Id = 1, Name = "Đức Đạt", Age = 19, Gender=true, ImgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBlWVQ0DdIcviaXW6DyFPJt5IxX0HE83zGBEyGoDZinhHvIkss&s", Des="Mô tả thông tin sinh viên"},
                new Student{ Id = 2, Name = "Thùy Trâm", Age= 25, Gender=false, ImgUrl="https://clipart-library.com/img/1421105.png", Des="Mô tả thông tin sinh viên"},
                new Student{ Id = 3, Name = "Nhã Phương", Age= 23, Gender=false, ImgUrl="https://clipart-library.com/img/1421105.png", Des="Mô tả thông tin sinh viên"},
                new Student{ Id = 4, Name = "Thanh Viễn", Age= 20, Gender=true, ImgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBlWVQ0DdIcviaXW6DyFPJt5IxX0HE83zGBEyGoDZinhHvIkss&s", Des = "Mô tả thông tin sinh viên" },
                new Student{ Id = 5, Name = "Hoàng Việt", Age= 19, Gender=true, ImgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxBlWVQ0DdIcviaXW6DyFPJt5IxX0HE83zGBEyGoDZinhHvIkss&s", Des="Mô tả thông tin sinh viên"}
            };
            return View(ListStudents);  
        }
        public string ListOnlyOne()
        {
            return "Liệt kê một sinh viên có ID cụ thể";
        }

        public string EditStudent()
        {
            return "Chỉnh sửa thông tin một sinh viên có ID cụ thể";
        }


        public string AddStudent()
        {
            return "Thêm thông tin một sinh viên";
        }

        public string DelStudent()
        {
            return "Xóa thông tin một sinh viên";
        }

        public IActionResult ListonlyStudent([FromQuery]int? id)
        {

            if (!id.HasValue)
            {
                return BadRequest("Student ID is not provided");
            }

            return Content($"Thong tin sinh vien {id}");
        }

        public IActionResult Editstudent()
        {
            return LocalRedirect("~/Home/Index");
        }
    }
}

