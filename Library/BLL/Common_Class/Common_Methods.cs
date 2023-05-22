using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Common_Class
{
    public class Common_Methods
    {
        public static string Check_Query_Condition(string condition)
        {
            condition = condition.Trim();
            if (condition != "" && condition.Substring(0, 5).ToLower() != "where")
            {
                condition = "WHERE " + condition;
            }
            return condition;
        }
    }
}
