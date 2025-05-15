using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string _phoneNumber;

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

        public Contact(string name, string phoneNumber, string address)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
        }
    }
}
