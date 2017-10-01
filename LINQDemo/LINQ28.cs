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
    public partial class LINQ28 : Form
    {
        public LINQ28()
        {
            InitializeComponent();
        }

        private void LINQ28_Load(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };
            var result = from n in nums
                         where n < 5
                         orderby n
                         select n;
            foreach (int i in result)
                Console.WriteLine(i);
        }
    }
}
