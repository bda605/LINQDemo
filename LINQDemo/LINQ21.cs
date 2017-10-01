using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class LINQ21 : Form
    {
        public LINQ21()
        {
            InitializeComponent();
        }

        private void LINQ21_Load(object sender, EventArgs e)
        {
            string name = "hooked on LINQ";
            string link = name.CreateHyperlink("http//tw.yahoo.com");
            Console.WriteLine("- CreateHyperlink -");
            Console.WriteLine("Original: " + name);
            Console.WriteLine("Hyperlink:" + link);
            Console.WriteLine();

            //string password = "ClearTextPassword";
            //string hashedPassword = password.GetSha1Hash();
            //Console.WriteLine("-SHA1 Hashing a string -");
            //Console.WriteLine("Original: " + password);
            //Console.WriteLine("Hashed:" + hashedPassword);
        }
      
    }
    public static class MyStringExtensions
    {
        public static string GetSha1Hash(this string Text)
        {
            if (string.IsNullOrEmpty(Text))
                return null;

            SHA1Managed sha1 = new SHA1Managed();
            byte[] bytes = sha1.ComputeHash(
                new UnicodeEncoding().GetBytes(Text));
            return Convert.ToBase64String(bytes);
        }

        public static string CreateHyperlink(this string text, string url)
        {
            return string.Format("<a href='{0}'></a>", url, text);
        }

    }

}
