using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAndCustomerClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Variables to hold input
            string name, address, telephone, customernumber;
            bool mailinglist;

            // Get the information from customer
            name = textBoxName.Text;
            address = textBoxAddress.Text;
            telephone = textBoxTelephoneNumber.Text;
            customernumber = textBoxCustomerNumber.Text;

            // Check for mailing list
            if (radioButtonMailingList.Checked)
            {
                mailinglist =  true;
                MessageBox.Show("Thank you for your information. You are now added to our mailing list!");
            }
            else
            {
                mailinglist = false;
                MessageBox.Show("Thank you for your information. You will not recieve any emails from us in the future.");
            }

            // Create a customer object

            Customer newCustomer = new Customer(name, address, telephone, customernumber, mailinglist);
                

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
