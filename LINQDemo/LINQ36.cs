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
    public partial class LINQ36 : Form
    {
        public LINQ36()
        {
            InitializeComponent();
        }

        private void LINQ36_Load(object sender, EventArgs e)
        {
            string[] animals = new string[]{"koala","kangaroo",
            "spider","wombat","snake","emu","shark","string-ray","jellyfish"};
            var q = animals.Where((a, index) => index % 2 == 0);
            foreach (string s in q)
                Console.WriteLine(s);
        }
    }
}
