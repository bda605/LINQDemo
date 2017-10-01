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
    public partial class LINQ29 : Form
    {
        public LINQ29()
        {
            InitializeComponent();
        }

        private void LINQ29_Load(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };
            int result = nums.Sum();
            Console.WriteLine(result);
        }
    }
}
