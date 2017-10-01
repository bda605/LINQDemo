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
    public partial class LINQ33 : Form
    {
        public LINQ33()
        {
            InitializeComponent();
        }

        private void LINQ33_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = Contact.SampleData();
            List<CallLog> callLog = CallLog.SampleData();

            var q = callLog.Join(contacts,
                call => call.Number,
                contact => contact.Phone,
                (call, contact) => new
                {
                    contact.FirstName,
                    contact.LastName,
                    call.When,
                    call.Duration
                }).Take(5)
                .OrderByDescending(call => call.When);
            foreach (var call in q)
                Console.WriteLine("{0} - {1} {2} ({3} min)",
                    call.When.ToString("ddMM hh:m"),
                    call.FirstName, call.LastName, call.Duration);
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

        public class CallLog
        {
            public string Number { get; set; }
            public int Duration { get; set; }
            public bool Incoming { get; set; }
            public DateTime When { get; set; }

            public static List<CallLog> SampleData()
            {
                return new List<CallLog> {
            new CallLog { Number = "885 983 8858", Duration = 2,  Incoming = true,  When = new DateTime(2006,	8,	7,	8,	12,	0)},
            new CallLog { Number = "165 737 1656", Duration = 15, Incoming = true,  When = new DateTime(2006,	8,	7,	9,	23,	0) },
            new CallLog { Number = "364 202 3644", Duration = 1,  Incoming = false, When = new DateTime(2006,	8,	7,	10,	5,	0) },
            new CallLog { Number = "603 303 6030", Duration = 2,  Incoming = false, When = new DateTime(2006,	8,	7,	10,	35,	0) },
            new CallLog { Number = "546 607 5462", Duration = 4,  Incoming = true,  When = new DateTime(2006,	8,	7,	11,	15,	0) },
            new CallLog { Number = "885 983 8858", Duration = 15, Incoming = false, When = new DateTime(2006,	8,	7,	13,	12,	0) },
            new CallLog { Number = "885 983 8858", Duration = 3,  Incoming = true,  When = new DateTime(2006,	8,	7,	13,	47,	0) },
            new CallLog { Number = "546 607 5462", Duration = 1,  Incoming = false, When = new DateTime(2006,	8,	7,	20,	34,	0) },
            new CallLog { Number = "546 607 5462", Duration = 3,  Incoming = false, When = new DateTime(2006,	8,	8,	10,	10,	0) },
            new CallLog { Number = "603 303 6030", Duration = 23, Incoming = false, When = new DateTime(2006,	8,	8,	10,	40,	0) },
            new CallLog { Number = "848 553 8487", Duration = 3,  Incoming = false, When = new DateTime(2006,	8,	8,	14,	0,	0) },
            new CallLog { Number = "848 553 8487", Duration = 7,  Incoming = true,  When = new DateTime(2006,	8,	8,	14,	37,	0) },
            new CallLog { Number = "278 918 2789", Duration = 6,  Incoming = true,  When = new DateTime(2006,	8,	8,	15,	23,	0) },
            new CallLog { Number = "364 202 3644", Duration = 20, Incoming = true,  When = new DateTime(2006,	8,	8,	17,	12,	0) },
            new CallLog { Number = "885 983 8858", Duration = 5,  Incoming = true,  When = new DateTime(2006,	7,	12,	8,	12,	0)},
            new CallLog { Number = "165 737 1656", Duration = 12, Incoming = true,  When = new DateTime(2006,	6,	14,	9,	23,	0) },
            new CallLog { Number = "364 202 3644", Duration = 10,  Incoming = false, When = new DateTime(2006,	7,	9,	10,	5,	0) },
            new CallLog { Number = "603 303 6030", Duration = 22,  Incoming = false, When = new DateTime(2006,	7,	5,	10,	35,	0) },
            new CallLog { Number = "546 607 5462", Duration = 9,  Incoming = true,  When = new DateTime(2006,	6,	7,	11,	15,	0) },
            new CallLog { Number = "885 983 8858", Duration = 10, Incoming = false, When = new DateTime(2006,	6,	7,	13,	12,	0) },
            new CallLog { Number = "885 983 8858", Duration = 21,  Incoming = true,  When = new DateTime(2006,	7,	7,	13,	47,	0) },
            new CallLog { Number = "546 607 5462", Duration = 7,  Incoming = false, When = new DateTime(2006,	7,	7,	20,	34,	0) },
            new CallLog { Number = "546 607 5462", Duration = 2,  Incoming = false, When = new DateTime(2006,	6,	8,	10,	10,	0) },
            new CallLog { Number = "603 303 6030", Duration = 3, Incoming = false, When = new DateTime(2006,	6,	8,	10,	40,	0) },
            new CallLog { Number = "848 553 8487", Duration = 32,  Incoming = false, When = new DateTime(2006,	7,	8,	14,	0,	0) },
            new CallLog { Number = "848 553 8487", Duration = 13,  Incoming = true,  When = new DateTime(2006,	7,	8,	14,	37,	0) },
            new CallLog { Number = "278 918 2789", Duration = 16,  Incoming = true,  When = new DateTime(2006,	5,	8,	15,	23,	0) },
            new CallLog { Number = "364 202 3644", Duration = 24, Incoming = true,  When = new DateTime(2006,	6,	8,	17,	12,	0) }
        };
            }
        }
    }
  

}
