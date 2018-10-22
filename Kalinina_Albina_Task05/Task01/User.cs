using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class User
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("Name can't be empty!");
                }
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Last Name can't be empty!");
                }
                ;
            }
        }

        public string Patronymic { get; set; }

        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (DateTime.Now > value)
                {
                    _dateOfBirth = value;
                }
                else
                {
                    throw new Exception("Date of birth can't be future!");
                }

            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.Month < DateOfBirth.Month ||
                    DateTime.Now.Month == DateOfBirth.Month && DateTime.Now.Day < DateOfBirth.Day)
                {
                    age = age - 1;
                }

                return age;
            }
        }

        public User(string firstName, string lastName, string patronymic, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
        }
    }
}
