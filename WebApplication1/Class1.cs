using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public double StudentCredits { get; set; }
        public string Phone { get; set; }
        public Student()
        {

        }
        public Student(int id,
                        string name,
                        double credits,
                        string phone)
        {
            StudentID = id;
            StudentName = name;
            StudentCredits = credits;
            Phone = phone;
        }
    }
}