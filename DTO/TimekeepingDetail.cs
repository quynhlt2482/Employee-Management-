using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class TimekeepingDetail
    {
        private int id;
        private string dayOfweek;
        private DateTime checkIn;
        private DateTime checkOut;
        private DateTime late;
        private string shiftId;
        private string timekeepingId;

        public TimekeepingDetail(int id, string dayOfweek, DateTime checkIn, DateTime checkOut, DateTime late, string shiftId, string timekeeping)
        {
            this.Id = id;
            this.DayOfweek = dayOfweek;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.Late = late;
            this.ShiftId = shiftId;
            this.TimekeepingId = timekeeping;
        }

        public int Id { get => id; set => id = value; }
        public string DayOfweek { get => dayOfweek; set => dayOfweek = value; }
        public DateTime CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime CheckOut { get => checkOut; set => checkOut = value; }
        public DateTime Late { get => late; set => late = value; }
        public string ShiftId { get => shiftId; set => shiftId = value; }
        public string TimekeepingId { get => timekeepingId; set => timekeepingId = value; }
    }
}
