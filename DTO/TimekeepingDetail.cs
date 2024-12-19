using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TimekeepingDetail
    {
        private int tkDetailID;
        private string dayOfweek;
        private TimeSpan checkIn;
        private TimeSpan checkOut;
        private TimeSpan late;
        private string shiftId;
        private string timekeepingId;
        private string employeeId;

        public TimekeepingDetail() {}
        public TimekeepingDetail(int tkDetailID, string dayOfweek, TimeSpan checkIn, TimeSpan checkOut, TimeSpan late, string shiftId, string timekeepingId, string employeeId)
        {
            this.tkDetailID = tkDetailID;
            this.DayOfweek = dayOfweek;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.Late = late;
            this.ShiftId = shiftId;
            this.timekeepingId = timekeepingId;
            this.employeeId = employeeId;
        }

        public int TkDetailID { get => tkDetailID; set => tkDetailID = value; }
        public string DayOfweek { get => dayOfweek; set => dayOfweek = value; }
        public TimeSpan CheckIn { get => checkIn; set => checkIn = value; }
        public TimeSpan CheckOut { get => checkOut; set => checkOut = value; }
        public TimeSpan Late { get => late; set => late = value; }
        public string ShiftId { get => shiftId; set => shiftId = value; }
        public string TimekeepingId { get => timekeepingId; set => timekeepingId = value; }
        public string EmployeeID { get => employeeId; set => employeeId = value;}
    }
}
