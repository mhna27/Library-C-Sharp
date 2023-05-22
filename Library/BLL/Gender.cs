using BLL.Common_Class;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Gender : Data_Access
    {
        public DataTable Select(string field_Names, string condtion = "")
        {
            condtion = Common_Methods.Check_Query_Condition(condtion);
            base.Connect();
            DataTable dt = base.Select_Data(string.Format("SELECT {0} FROM dbo.tbl_Gender {1}",
             field_Names, condtion));
            base.Disconnect();
            return dt;
        }
    }
}
