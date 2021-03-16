using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentsController : ApiController
    {
        //api/students
        public IEnumerable<Student> Get() 
        {
            return StudentsDbMOCK.students;
        }

        //api/students/2
        public Student Get(int id)
        {
            //StudentsDbMOCK.students.Where(stu=> stu.Name.Contains("avi")); //return a list
            return StudentsDbMOCK.students.SingleOrDefault(stu => stu.ID == id); //return the first
        }
    }
}
