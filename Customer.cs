using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClass
{
    class Customer : Person
    {
        // Field
        private string _number;
        private bool _mailinglist;

        public Customer() { 
        }

        // Constructor
        public Customer(string name, string address, string telephonenumber, string number, bool mailinglist)
            : base(name, address, telephonenumber)
        {
            _number = number;
            _mailinglist = mailinglist = true;
        }

        // Customer number property
        public string CustomerNumber
        {
            get { return _number; }
            set { _number = value; }
        }

        // Mailing list property
        public bool MailingList
        {
            get { return _mailinglist; }
            set { _mailinglist = value; }
        }



       


    }
}
