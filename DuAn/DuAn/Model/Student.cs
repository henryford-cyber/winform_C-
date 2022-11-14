using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn.Model
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public SEX sex { get; set; }
        public enum SEX
        { 
            Male,Female,ThirdGender
        }
        public DateTime birthDay { get; set; }
        public String address { get; set; }

        public int class_id { get; set; }  

    }
}
