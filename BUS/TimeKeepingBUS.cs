using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TimeKeepingBUS
    {
        private readonly TimeKeepingDAL timeKeepingDAL = new TimeKeepingDAL();

        public void InsertTimeKeeping( )
        {
            timeKeepingDAL.InsertTimeKeeping();
        }
        public bool ExitstTimeKeeping()
        {
            return timeKeepingDAL.ExitstTimeKeeping();
        }

        public List <Timekeeping> GetAllTimeKeeping()
        {
            return timeKeepingDAL.GetAllTimeKeeping();
        }

        public List<Timekeeping> GetAllTimeKeepingYear(int year)
        {
            return timeKeepingDAL.GetAllTimeKeepingYear(year);
        }

        public List<Timekeeping> GetAllTimeKeepingYearMonth(int year, int month)
        {
            return timeKeepingDAL.GetAllTimeKeepingYearMonth(year, month);
        }

        public List<Timekeeping> GetAllTimeKeepingMonth(int month)
        {
            return timeKeepingDAL.GetAllTimeKeepingMonth(month);
        }
    }
}
