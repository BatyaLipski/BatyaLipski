using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milgaPluse
{
    public class Scholarship
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int basic { get; set; }
        public bool musar { get; set; }
        public bool dailyRoutine { get; set; }
        public bool continuous { get; set; }
        public int lastMonthMark { get; set; }
        public int excellenceScholarship { get; set; }
        public int holidayScholarship { get; set; }
        public int religiousMinistry { get; set; }
        public int sumScholarships { get; set; }
        public int ScholarshipsAndLoan { get; set; }
        public int refund { get; set; }
        public int donation { get; set; }
        public int remainderDebt { get; set; }
    }
}
