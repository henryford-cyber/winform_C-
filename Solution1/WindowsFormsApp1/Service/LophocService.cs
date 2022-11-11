using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
    public class LophocService
    {
        public static List<Lophoc> danhsachlophoc()
        {
            var data = new List<Lophoc>();
            data.Add(new Lophoc
            {
                MaLophoc = 1,
                TenLophoc = "CNTT 1"
            });
            data.Add(new Lophoc
            {
                MaLophoc = 2,
                TenLophoc = "CNTT 2"
            });
            data.Add(new Lophoc
            {
                MaLophoc = 3,
                TenLophoc = "CNTT 3"
            }); 
            return data;
        }
    }
}
