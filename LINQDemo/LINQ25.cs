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
    public partial class LINQ25 : Form
    {
        public LINQ25()
        {
            InitializeComponent();
        }

        private void LINQ25_Load(object sender, EventArgs e)
        {
            Console.WriteLine(" - Sampel Anonymous Type -");
            var item = new { Name = "Car", Price = 9999 };
            Console.WriteLine("Type:{0}, Name:{1} , Price:{2}",
                item.GetType().ToString(),item.Name,item.Price);

            Console.WriteLine();
            Console.WriteLine("- Iterating Anonymous Types Array -");
            var list = new[] {
               new {LastName = "AAA",
               FirstName = "AAA"
             },new {LastName = "BBB",
               FirstName = "BBB"
             }
            
            };
            foreach (var x in list)
                Console.WriteLine("{0} ({1})",
                    x.LastName, x.FirstName);

        }
    }
}
