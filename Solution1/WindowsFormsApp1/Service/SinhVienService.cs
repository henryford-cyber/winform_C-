using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
  public class SinhVienService
    {
        public static List<Sinhvien> GetAllSinhvienFromFile(string path)
        {
            //var lines=  File.ReadAllLines(path, Encoding.UTF8);
            //List<Sinhvien> ls = new List<Sinhvien>();
            //foreach(var line in lines)
            //{
            //var sv = Sinhvien.Parse(line);
            //ls.Add(sv);
            //}
            //return ls; 
            var json = File.ReadAllText(path);
            var rs = JsonConvert.DeserializeObject<List<Sinhvien>>(json);
            return rs;
        }

        public static List <Sinhvien> GetFakeAllSinhvien()
        {
            var ho = new string[] { "Phan", "Nguyễn", "Trần", "Ngô", "Phạm",};
            var ten = new string[] { "Nam", "Hiếu", "Tân", "Nghĩa", "Như" ,"Tài","Hoàng" };
            var data = new List<Sinhvien>();
            Random random = new Random();
            var listLopHoc = LophocService.GetFakeData();
            foreach(var lophoc in listLopHoc)
            {
                for(int i = 0; i < 10; i++)
                {
                    Sinhvien sv = new Sinhvien
                    {
                        MaLopHoc = lophoc.MaLophoc,
                        Id = lophoc.MaLophoc * 10 + i,
                        Ho = ho[random.Next(0, ho.Length)],
                        Ten = ten[random.Next(0, ten.Length)],
                        NgaySinh = new DateTime(random.Next(1990,2002), random.Next(1,12), random.Next(1,28)),
                        DiaChi = "Hương xuan hương trà Huế",
                        GioiTinh = (GIOITINH)random.Next(3),
                        MaSinhVien = $"IT{lophoc.MaLophoc * 10 + i}",
                    };
                    data.Add(sv);
                   
                } 
               
            }
            return data;
        }
        public static List<Sinhvien>GetFakeDanhsachSV(int malop)
        {
            var listSinhVien = GetAllSinhvienFromFile();
            var rs= listSinhVien.Where(e => e.MaLopHoc == malop).ToList();

            return rs;
        }
        public static List<Sinhvien> GetFakeDanhSachsinhvien(int malop ,string keyWord) 
        { 
                var listSinhVien = GetFakeAllSinhvien();
                var result = listSinhVien.Where(e => 
                e.MaLopHoc == malop && (
                e.HovaTen.IndexOf(keyWord,StringComparison.OrdinalIgnoreCase)>0 ||e.MaSinhVien.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase)>0)
                ).ToList();
            
            return result;
        }
    }
}
