using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;


namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentId=1, StudentName="John", StudentFirstName="John", StudentLasttName="Smith", Age = 18, Gender="Male", Score = 1 },
                    new Student(){ StudentId=2, StudentName="Steve", StudentFirstName="Steve", StudentLasttName="Smith",Age = 21, Gender="Male", Score = 2  },
                    new Student(){ StudentId=3, StudentName="Bill", StudentFirstName="Bill", StudentLasttName="Smith",Age = 25, Gender="Male", Score = 1  },
                    new Student(){ StudentId=4, StudentName="Ram", StudentFirstName="Ram", StudentLasttName="Smith",Age = 20, Gender="Male", Score = 3  },
                    new Student(){ StudentId=5, StudentName="Ron", StudentFirstName="Ron", StudentLasttName="Smith",Age = 31, Gender="Male", Score = 4  },
                    new Student(){ StudentId=6, StudentName="Chris", StudentFirstName="Chris", StudentLasttName="Smith",Age = 17, Gender="Male", Score = 1  },
                    new Student(){ StudentId=7, StudentName="Robin", StudentFirstName="Robin", StudentLasttName="Smith",Age = 19, Gender="Female", Score = 5  },
                    new Student(){ StudentId=7, StudentName="Mickey Mouse", StudentFirstName="Mickey", StudentLasttName="Mouse",Age = 23, Gender="Male", Score = 5  },
                    new Student(){ StudentId=7, StudentName="Minnie Mouse", StudentFirstName="Minnie", StudentLasttName="Mouse",Age = 23, Gender="Female", Score = 5  },
                    new Student(){ StudentId=7, StudentName="Winnie Pooh", StudentFirstName="Winnie", StudentLasttName="Pooh",Age = 19, Gender="Female", Score = 5  }
                };

        // GET: Student
        public ActionResult Index()
        {

            return View(studentList);
        }


        public class Rootobject
        {
            public Employee employee { get; set; }
        }

        public class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public bool married { get; set; }
        }


        //[HttpPost]
        //public ActionResult Edit(Student std)
        //{
        //    var id = std.StudentId;
        //    var name = std.StudentName;
        //    var age = std.Age;
        //    var standardName = std.standard.StandardName;


        //    //update database here..

        //    return View(std);
        //}


        public ActionResult Edit(int Id)
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //write code to update student

            return RedirectToAction("Index");
        }


    }
}