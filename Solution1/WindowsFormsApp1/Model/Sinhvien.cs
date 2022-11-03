using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Sinhvien
    {
        public int Id { get; set; }
        public string MaSinhVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string HovaTen
        {
            get {
                return $"{Ho} {Ten}";

                }        
        }
        public GIOITINH GioiTinh { get; set; }
        public string GIOITINHStr { 
            get
            {
                if (GioiTinh == GIOITINH.Nam)
                    return "Nam";
                else if (GioiTinh == GIOITINH.Nu)
                    return "Nữ";
                else  
                    return "Khác";
            }
        }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int MaLopHoc { get; set; }
        public override string ToString()
        {
            return $"{Id}#{MaSinhVien}#{Ho}#{Ten}#{GioiTinh}#{NgaySinh}#{DiaChi}#{MaLopHoc}";

        }
       
    }
    public enum GIOITINH 
    { 
        Nam, Nu ,Khac
    }
}
