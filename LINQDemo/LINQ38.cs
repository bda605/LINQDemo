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
    public partial class LINQ38 : Form
    {
        public LINQ38()
        {
            InitializeComponent();
        }

        private void LINQ38_Load(object sender, EventArgs e)
        {
            string[] sentence = new string[] {"The quick brown",
            "fox jumps over","the lazy dog."};
            Console.WriteLine("option 1:");
            Console.WriteLine("---------");
            
            IEnumerable<string[]> words1 =
               sentence.Select(w => w.Split(' '));

            foreach (string[] segment in words1)
                foreach (string word in segment)
                    Console.WriteLine(word);

            Console.WriteLine("option 2:");
            Console.WriteLine("---------");

            IEnumerable<string> words2 = 
                sentence.SelectMany(segment => segment.Split(' '));

            foreach (var word in words2)
                Console.WriteLine(word);

            Console.WriteLine("option 3:");
            Console.WriteLine("---------");

            IEnumerable<string> words3 =
                from segment in sentence
                from word in segment.Split(' ')
                select word;

            foreach (var word in words3)
                Console.WriteLine(word);

        }
    }
}
