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
    public partial class LINQ39 : Form
    {
        public LINQ39()
        {
            InitializeComponent();
        }

        private void LINQ39_Load(object sender, EventArgs e)
        {
            List<CallLog> callLog = CallLog.SampleData();
            var q = callLog.GroupBy(g => g.Number)
                .OrderByDescending(g => g.Count())
                .Select((g, index) => new { 
                     number = g.Key,
                     rank = index + 1,
                     count = g.Count()
                });
            foreach (var c in q)
                Console.WriteLine(
                    "rank{0} - {1} , called{2} times.",
                    c.rank, c.number, c.count);
        }
        public class CallLog
        {
            public string Number { get; set; }
            public int Duration { get; set; }
            public bool Incoming { get; set; }
            public DateTime When { get; set; }

            public static List<CallLog> SampleData()
            {
                return new List<CallLog> 
                {
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
