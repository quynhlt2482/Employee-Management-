using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ShiftBUS
    {
        private readonly ShiftDAL shiftDAL = new ShiftDAL();
        
        public void insertShiftBUS(Shift shift)
        {
            shiftDAL.InsertShift(shift);
        }

        public List<Shift> GetInformationListShift()
        {
            return shiftDAL.GetListShift();
        }

        public Shift GetInformationShift(string shiftID)
        {
            return shiftDAL.GetShift(shiftID);
        }
        public void UpdateInformationShift(Shift shift)
        {
            shiftDAL.UpdateShift(shift);
        }

        public bool DeleteShip (string shiftID)
        {
            return shiftDAL.DeleteShift(shiftID);
        }
    }
}
