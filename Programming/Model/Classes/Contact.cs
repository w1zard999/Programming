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
        public string _name;
        public string _surname;
        public string _phoneNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

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
        public Contact() { }

        public Contact(string name, string surname, string phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
        }
    }
}
