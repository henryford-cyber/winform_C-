using DuAn.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn.Service
{
    public class ClassService
    {
        public static List<Model.Class> ListClass() {
            var list = new List<Model.Class>();
            list.Add(new Model.Class
            {
                classId= 1,
                className="QTKD-A-K18",
                homeroomTeacher="Nguyen Van B",
                totalStudent=10
            });
            list.Add(new Model.Class
            {
                classId = 2,
                className = "VNH-K18",
                homeroomTeacher = "Nguyen Thi A",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 3,
                className = "NNT-A-K18",
                homeroomTeacher = "Vo Van C",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 4,
                className = "NNA-A-K18",
                homeroomTeacher = "Nguyen H",
                totalStudent = 10

            });
            list.Add(new Model.Class
            {
                classId = 5,
                className = "QTKS-A-K19",
                homeroomTeacher = "Phan A",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 6,
                className = "CNTT-A-K18",
                homeroomTeacher = "Nguyen V",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 7,
                className = "CNTT-B-K18",
                homeroomTeacher = "Pham T",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 8,
                className = "CNOT-K19",
                homeroomTeacher = "Hoang B",
                totalStudent = 42
            });
            list.Add(new Model.Class
            {
                classId = 9,
                className = "CNOT-K18",
                homeroomTeacher = "Nguyen Van Tuan",
                totalStudent = 10
            });
            list.Add(new Model.Class
            {
                classId = 10,
                className = "DL&LH-K18",
                homeroomTeacher = "Hoang Thi T",
                totalStudent = 10
            });
            return list; 
        
        }
    }
}
