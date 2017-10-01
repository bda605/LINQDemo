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
    public partial class LINQ27 : Form
    {
        public LINQ27()
        {
            InitializeComponent();
        }
        
        private void LINQ27_Load(object sender, EventArgs e)
        {
            var query1 = from c in Person.SampeData()
                         where c.State == "WA"
                         select new { 
                            Name = c.FirstName + " " + c.LastName,
                            State = c.State
                         };

            var query2 = Person.SampeData()
                .Where(c => c.State == "WA")
                .Select(c => new
                {
                    Name = c.FirstName + " " + c.LastName,
                    State = c.State
                });
            foreach (var item in query1)
                Console.WriteLine("{0},({1})", item.Name, item.State);
        }
        class Person 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string State { get; set; }

            public static List<Person> SampeData() 
            {
                return new List<Person>
                {
                    new Person { FirstName = "Tony",   LastName = "Magennis",  State="WA"},
                    new Person { FirstName = "Janet",  LastName = "Doherty",   State = "MA" },
                    new Person { FirstName = "James",  LastName = "Wann",      State = "CA" },
                    new Person { FirstName = "Tara",   LastName = "Wann",      State = "WA" }
                };
            }
        }
    }
}
