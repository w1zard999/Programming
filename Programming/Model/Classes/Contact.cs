using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        public string _surname;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string _phoneNumber;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _phoneNumber = value;
                else
                    throw new ArgumentException("Номер телефона не может быть пустым");
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Конструктор с параметрами контактной информации.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        /// <param name="phoneNumber">Номер телефона контакта.</param>
        public Contact(string name, string surname, string phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }
    }
}
