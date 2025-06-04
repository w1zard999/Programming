using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees.Model
{
    public class EmployeesInfo
    {
        /// <summary>
        /// Полное имя сотрудника.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Должность сотрудника.
        /// </summary>
        private string _position;

        /// <summary>
        /// Дата принятия на работу.
        /// </summary>
        private DateTime _dateOfEmployment;

        /// <summary>
        /// Зарплата сотрудника.
        /// </summary>
        private double _salary;

        /// <summary>
        /// Возвращает и задаёт полное имя сотрудника.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.AssertStringContainsMaxLetters(value, 100, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт должность сотрудника.
        /// </summary>
        public string Position
        {
            get { return _position; }
            set
            {
                Validator.AssertStringContainsMaxLetters(value, 50, nameof(Position));
                _position = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт дату принятия на работу.
        /// </summary>
        public DateTime DateOfEmployment
        {
            get { return _dateOfEmployment; }
            set
            {
                Validator.AssertDateNotLaterThanToday(value, nameof(DateOfEmployment));
                _dateOfEmployment = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт зарплату сотрудника.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                Validator.AssertValueInRange(value, 0, 50000, nameof(Salary));
                _salary = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public EmployeesInfo() { }

        /// <summary>
        /// Конструктор с полной информацией о сотруднике.
        /// </summary>
        /// <param name="fullName">Полное имя сотрудника.</param>
        /// <param name="position">Должность сотрудника.</param>
        /// <param name="dateOfEmployment">Дата принятия на работу.</param>
        /// <param name="salary">Зарплата сотрудника.</param>
        public EmployeesInfo(string fullName, string position, DateTime dateOfEmployment, double salary)
        {
            this.FullName = fullName;
            this.Position = position;
            this.DateOfEmployment = dateOfEmployment;
            this.Salary = salary;
        }
    }
}
