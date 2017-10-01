using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class LINQ12 : Form
    {
        public LINQ12()
        {
            InitializeComponent();
        }

        private void LINQ12_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = Contact.SampleData();
            var query = from c in contacts
                        orderby c.State, c.LastName
                        group c by c.State;
            foreach (var group in query)
            {
                Console.WriteLine("State:" + group.Key);
                foreach (Contact c in group)
                    Console.WriteLine("{0} {1}", c.FirstName, c.LastName);
            }


        }
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string State { get; set; }

            public static List<Contact> SampleData()
            {
                return new List<Contact> {
                     new Contact {FirstName = "Barney",     LastName = "Gottshall",     DateOfBirth = new DateTime(1945,10,19), Phone = "885 983 8858", Email = "bgottshall@aspiring-technology.com", State = "CA" },
                     new Contact {FirstName = "Armando",    LastName = "Valdes",        DateOfBirth = new DateTime(1973,12,09), Phone = "848 553 8487", Email = "val1@aspiring-technology.com", State = "WA" },
                     new Contact {FirstName = "Adam",       LastName = "Gauwain",       DateOfBirth = new DateTime(1959,10,03), Phone = "115 999 1154", Email = "adamg@aspiring-technology.com", State = "AK" },
                     new Contact {FirstName = "Jeffery",    LastName = "Deane",         DateOfBirth = new DateTime(1950,12,16), Phone = "677 602 6774", Email = "jeff.deane@aspiring-technology.com", State = "CA" },
                     new Contact {FirstName = "Collin",     LastName = "Zeeman",        DateOfBirth = new DateTime(1935,02,10), Phone = "603 303 6030", Email = "czeeman@aspiring-technology.com", State = "FL" },
                     new Contact {FirstName = "Stewart",    LastName = "Kagel",         DateOfBirth = new DateTime(1950,02,20), Phone = "546 607 5462", Email = "kagels@aspiring-technology.com", State = "WA" },
                     new Contact {FirstName = "Chance",     LastName = "Lard",          DateOfBirth = new DateTime(1951,10,21), Phone = "278 918 2789", Email = "lard@aspiring-technology.com", State = "WA" },
                     new Contact {FirstName = "Blaine",     LastName = "Reifsteck",     DateOfBirth = new DateTime(1946,05,18), Phone = "715 920 7157", Email = "blaine@aspiring-technology.com", State = "TX" },
                     new Contact {FirstName = "Mack",       LastName = "Kamph",         DateOfBirth = new DateTime(1977,09,17), Phone = "364 202 3644", Email = "mack.kamph@aspiring-technology.com", State = "TX" },
                     new Contact {FirstName = "Ariel",      LastName = "Hazelgrove",    DateOfBirth = new DateTime(1922,05,23), Phone = "165 737 1656", Email = "arielh@aspiring-technology.com", State = "OR" }
                };
            }
        }

    }
}
