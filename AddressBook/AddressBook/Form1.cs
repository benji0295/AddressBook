using System;
using System.CodeDom;
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
    public partial class Form1 : Form
    {
        private Dictionary<string, Person> addressBook;
        public Form1()
        {
            InitializeComponent();
            addressBook = new Dictionary<string, Person>();
            InitializeAddressBook();
            InitializeDataGridView();
            RefreshDataGridView();
        }
        private void InitializeAddressBook()
        {
            var initialAddressBook = new List<Person>
            {
                new Person("John", "Doe", "123-456-7890", "123-456-7890", "123 Main St."),
                new Person("Jane", "Smith", "123-456-7890", "123-456-7890", "123 Main St."),
                new Person("John", "Smith", "123-456-7890", "123-456-7890", "123 Main St."),
                new Person("Jane", "Doe", "123-456-7890", "123-456-7890", "123 Main St.")
            };

            foreach (var person in initialAddressBook)
            {
                addressBook[person.ToString()] = person;
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                Name = "FirstName",
                HeaderText = "First Name",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                Name = "LastName",
                HeaderText = "Last Name",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CellPhone",
                Name = "CellPhone",
                HeaderText = "Cell Phone",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "WorkPhone",
                Name = "WorkPhone",
                HeaderText = "Work Phone",
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                Name = "Address",
                HeaderText = "Address",
            });
        }

        private void RefreshDataGridView()
        {
            var bindingList = new BindingList<Person>(addressBook.Values.ToList());
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var person = addForm.Person;
                addressBook[person.ToString()] = person;
                RefreshDataGridView();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var key = searchForm.SearchKey;
                if (addressBook.TryGetValue(key, out var person))
                {
                    MessageBox.Show($"Name: {person.FirstName} {person.LastName}\nCell Phone: {person.CellPhone}\nWork Phone: {person.WorkPhone}\nAddress: {person.Address}", "Search Result");
                }
                else
                {
                    MessageBox.Show("No results found", "Search Result");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var firstName = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
                var lastName = dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString();
                var key = $"{firstName} {lastName}";

                var confirmResult = MessageBox.Show($"Are you sure you want to delete {key}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (addressBook.Remove(key))
                    {
                        RefreshDataGridView();
                        MessageBox.Show($"{key} has been deleted.", "Delete Successful");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete {key}", "Delete Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Delete Error");
            }
        }
    }
}