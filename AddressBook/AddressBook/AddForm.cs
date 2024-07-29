using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddForm : Form
    {
        public Person Person { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person = new Person(firstNameText.Text, lastNameText.Text, cellPhoneText.Text, workPhoneText.Text, addressText.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
