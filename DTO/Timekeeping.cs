using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Timekeeping
    {
        private string timeKeepingID;
        private int year;
        private int month;

        public Timekeeping()
        {
        }
        public Timekeeping(string timeKeepingID, int year, int month)
        {
            this.timeKeepingID = timeKeepingID;
            this.year = year;
            this.month = month;
        }

        public string TimeKeepingID { get => timeKeepingID; set => timeKeepingID = value; }
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
       
    }
}
