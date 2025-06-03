using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees.Model
{
    public class EmployeesInfo
    {
        private string _fullName;
        private string _position;
        private DateTime _dateOfEmployment;
        private double _salary;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.AssertStringContainsMaxLetters(value, 100, nameof(FullName));
                _fullName = value;
            }
        }

        public string Position
        {
            get { return _position; }
            set
            {
                Validator.AssertStringContainsMaxLetters(value, 50, nameof(Position));
                _position = value;
            }
        }

        public DateTime DateOfEmployment
        {
            get { return _dateOfEmployment; }
            set
            {
                Validator.AssertDateNotLaterThanToday(value, nameof(DateOfEmployment));
                _dateOfEmployment = value;
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                Validator.AssertValueInRange(value, 0, 50000, nameof(Salary));
                _salary = value;
            }
        }

        public EmployeesInfo() { }

        public EmployeesInfo(string fullName, string position, DateTime dateOfEmployment, double salary)
        {
            this.FullName = fullName;
            this.Position = position;
            this.DateOfEmployment = dateOfEmployment;
            this.Salary = salary;
        }
    }
}
