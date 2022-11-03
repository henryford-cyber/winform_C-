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
        public static List<Lophoc> GetFakeData()
        {
            var data = new List<Lophoc>();
            data.Add(new Lophoc
            {
                MaLophoc = 1,
                TenLophoc = "CNTT A K18"
            });
            data.Add(new Lophoc
            {
                MaLophoc = 2,
                TenLophoc = "CNTT b K18"
            });
            data.Add(new Lophoc
            {
                MaLophoc = 3,
                TenLophoc = "CNTT A K19"
            });
            data.Add(new Lophoc
            {
                MaLophoc = 1,
                TenLophoc = "NNT K18"
            });
            return data;
        }
    }
}
