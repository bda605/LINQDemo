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
    public partial class LINQ30 : Form
    {
        public LINQ30()
        {
            InitializeComponent();
        }

        private void LINQ30_Load(object sender, EventArgs e)
        {
            //string[] animals = new string[] { "koala", "kangaroo", "spider"
            //    , "wombat", "snake", "emu","shark","string-ray","jellyfish" };
            //// first query
            ////   var q = animals.Where(a => a.StartsWith("s") && a.Length > 5);
            ////two query
            ////var q = from a in animals
            ////        where a.StartsWith("s") && a.Length > 5
            ////        select a;
            ////three 
            //var q = from a in animals
            //        where MyPredicate(a)
            //        select a;
            //foreach (string s in q)
            //    Console.WriteLine(s);
            int[] nums = new int[] { 5, 3, 4, 2, 7, 6, 4, 5, 8, 2, 1, 2, 3, 4, 2 };
            int lessthans = nums.Count(n=> n  < 5);

            int product = nums.Aggregate(
                (runningproduct,n)
                => runningproduct *= n);
            Console.WriteLine("{0} numbers less than 5.", lessthans);
            Console.WriteLine("The product of all numbers is {0}",product);

            int first = nums.First();
            int firstGT5 = nums.First(n => n > 5);

            int firstDflt = nums.FirstOrDefault(n => n == 100);


            int element = nums.ElementAt(7);
            Console.WriteLine("first:{0},first > 5 : {1},first default: {2}",first,firstGT5 ,firstDflt);

        }
        public bool MyPredicate(string a)
        {
            if (a.StartsWith("s") && a.Length > 5)
                return true;
            else
                return false;
        }
    }
}
