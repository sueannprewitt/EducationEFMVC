using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationEFMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int? MajorId { get; set; }
        public Major Major { get; set; }

        public void Copy(Student student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            SAT = student.SAT;
            GPA = student.GPA;
            PhoneNumber = student.PhoneNumber;
            Email = student.Email;
        }


    }
}