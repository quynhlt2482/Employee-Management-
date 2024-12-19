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
    }
}
