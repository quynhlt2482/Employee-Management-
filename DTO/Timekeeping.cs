using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Timekeeping
    {
        private string id;
        private int year;
        private int month;
        private bool status;
        private int workDayAmount;
        private int dayOff;
        private int workDay;
        private string employeeId;

        public Timekeeping(string id, int year, int month, bool status, int workDayAmount, int dayOff, int workDay, string employeeId)
        {
            this.id = id;
            this.year = year;
            this.month = month;
            this.status = status;
            this.workDayAmount = workDayAmount;
            this.dayOff = dayOff;
            this.workDay = workDay;
            this.EmployeeId = employeeId;
        }

        public string Id { get => id; set => id = value; }
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public bool Status { get => status; set => status = value; }
        public int WorkDayAmount { get => workDayAmount; set => workDayAmount = value; }
        public int DayOff { get => dayOff; set => dayOff = value; }
        public int WorkDay { get => workDay; set => workDay = value; }
        public string EmployeeId { get => employeeId; set => employeeId = value; }
    }
}
