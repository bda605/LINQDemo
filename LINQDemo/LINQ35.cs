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
    public partial class LINQ35 : Form
    {
        public LINQ35()
        {
            InitializeComponent();
        }

        private void LINQ35_Load(object sender, EventArgs e)
        {
            string[] animals = new string[] { 
              "Koala","Kangaroo","Spider","wombat","snake","emu","sharek",
              "string-ray","jellyfish"
            };
            var q = from a in animals
                    where IsAdmnimalDeadly(a)
                    select a;
            foreach (string s in q)
                Console.WriteLine("A {0} can be deadly.", s);
        }
        public static bool IsAdmnimalDeadly(string s) 
        {
            string[] deadly = new string[] { "spider", "snake", "shark", "string-ray", "jellyfish" };
            return deadly.Contains(s);
        }
    }
}
