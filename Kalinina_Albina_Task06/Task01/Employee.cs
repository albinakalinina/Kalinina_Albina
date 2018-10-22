using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
 public class Employee:User
    {
        private double _workExperience;
        public double WorkExperience {
            get
            {
                return _workExperience;
            }
            set
            {
                ;
                if (WorkExperience > 0)
                {
                    _workExperience = value;
                }
                else
                {
                    throw new Exception("Work experience can't be 1 years!");
                }
            }
        }
        private string _position;
        public string Position 
        {
            get
            {
                return _position;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _position = value;
                }
                else
                {
                    throw new Exception("You must specify the position!");
                }

            }
        }

        public Employee(double workExperience, string position, string firstName, string lastName, string patronymic, DateTime dateOfBirth)
        {
            WorkExperience = workExperience;
            Position = position;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;

        }
    }
       
    }

