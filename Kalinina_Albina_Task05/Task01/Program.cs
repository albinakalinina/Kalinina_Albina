using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("", "", "", DateTime.Now);
            var name = u.FirstName;
            u.FirstName = "Ivan";
            var lastname = u.LastName;
            u.LastName = "Ivanov";
            var patronumic = u.Patronymic;
            u.Patronymic = "Ivanovich";
            var dob = u.DateOfBirth;
            
        }
    }
}
