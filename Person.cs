using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClass
{
    class Person
    {
        // Field
        private string _name;
        private string _address;
        private string _telephonenumber;

        public Person()
        {
            _name = "";
            _address = "";
            _telephonenumber = "";
        }

        // Constructor
        public Person(string name, string address, string telephonenumber)
        {
            _name = name;
            _address = address;
            _telephonenumber = telephonenumber;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Telephone Number property
        public string TelephoneNumber
        {
            get { return _telephonenumber; }
            set { _telephonenumber = value; }
        }

    }
}
