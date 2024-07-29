using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, string cellPhone, string workPhone, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhone = cellPhone;
            WorkPhone = workPhone;
            Address = address;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}