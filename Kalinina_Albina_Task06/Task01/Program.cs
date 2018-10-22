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
            Employee e = new Employee(0, "","", "", "", DateTime.Now);
            var workExperience = e.WorkExperience;
            var position = e.Position;
            e.Position = "Ingineer";
            var name = e.FirstName;
            e.FirstName = "Ivan";
            var lastname = e.LastName;
            e.LastName = "Ivanov";
            var patronumic = e.Patronymic;
            e.Patronymic = "Ivanovich";
            var dob = e.DateOfBirth;

        }
    }
}
