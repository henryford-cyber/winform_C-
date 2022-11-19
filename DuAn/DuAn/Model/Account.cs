using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public int phonenumber { get; set; }
        public string address { get; set; }
        public string username { get; set; }    
        public string password { get; set; }
        public string images { get; set; }
        public string type { get; set; }
    }
}
