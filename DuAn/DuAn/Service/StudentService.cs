using DuAn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DuAn.Model.Student;
using static DuAn.Model.Class;
namespace DuAn.Service
{
    public class StudentService
    {
        public static List<Student> ListStudents()
        {
            var name = new string[] { "Nam", "Hiếu", "Tân", "Nghĩa", "Tuấn", "Tài", "Hoàng", "Hải" };
            var address = new string[] { "Huế", "Đà Nẵng", "Quảng Nam", "Quảng Trị", "Tp.HCM", "Hà Nội" };
            var data = new List<Student>();
            var gender = new string[] { "Nam", "Nữ", "Khác" };
            Random random = new Random();
            var listclass = ClassService.ListClass();
            foreach (var lophoc in listclass)
            {
                for (int i = 0; i < 5; i++)
                {
                    Student sv = new Student
                    {
                        id=lophoc.classId * 1 +i,
                        name = name[random.Next(name.Length)], 
                        sex = gender[random.Next(gender.Length)],
                        birthDay= new DateTime(random.Next(2000, 2002), random.Next(1, 12), random.Next(1, 28)),
                        address = address[random.Next(address.Length)],
                        class_id=lophoc.classId,
                    };
                    data.Add(sv);

                }

            }
            return data;
        }
    }   
}
