using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TimeKeepingDetailBUS
    {
        public static readonly TimeKeepingDetailDAL timeKeepingDetailDAL = new TimeKeepingDetailDAL();
        public List<TimekeepingDetail> GetAllTimeKeepingDetail(string ID)
        {
            return timeKeepingDetailDAL.GetAllTimeKeepingDetail(ID);
        }

        public TimekeepingDetail GetTimekeepingDetail(string timekeepingID, string tkDetailID, string manv)
        {
            return timeKeepingDetailDAL.GetTimekeepingDetail(timekeepingID, tkDetailID, manv);
        }

        public void UpdateTimeKeepingDetail(TimekeepingDetail timekeepingDetail)
        {
            timeKeepingDetailDAL.UpdateTimeKeepingDetail(timekeepingDetail);
        }

        public List<TimekeepingDetail> GetAllTimeKeepingDetailEmployee(string timekeepingID, string manv)
        {
            return timeKeepingDetailDAL.GetAllTimeKeepingDetailEmployee(timekeepingID, manv);
        }
    }
}
