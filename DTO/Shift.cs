using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Shift
    {
        private string shiftID;
        private string shiftName;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private float coefficientSalary;

        // Constructors
        public Shift(string shiftID, string shiftName, TimeSpan startTime, TimeSpan endTime, float coefficientSalary)
        {
            this.shiftID = shiftID;
            this.shiftName = shiftName;
            this.startTime = startTime;
            this.endTime = endTime;
            this.coefficientSalary = coefficientSalary;
        }

        // Properties
        public string ShiftID { get => shiftID; set => shiftID = value; }
        public string ShiftName { get => shiftName; set => shiftName = value; }
        public TimeSpan StartTime { get => startTime; set => startTime = value; }
        public TimeSpan EndTime { get => endTime; set => endTime = value; }
        public float CoefficientSalary { get => coefficientSalary; set => coefficientSalary = value; }

    }
}
