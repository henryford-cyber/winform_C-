using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
    public class AccountService
    {
        public static List<Account> getAllAcount()
        {
            var data = new List<Account>();
            data.Add(new Account
            {
                id = 1,
                username= "admin",
                password="123"
            });
            data.Add(new Account
            {
                id = 2,
                username = "namphan123",
                password="123"
            });
             
            return data;
        }
    }
}
