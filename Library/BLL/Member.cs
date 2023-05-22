using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Common_Class;

namespace BLL
{
    public class Member : Data_Access, IPerson
    {
        public string F_Name { get => f_Name; set => f_Name = value.Trim(); }
        public string L_Name { get => l_Name; set => l_Name = value.Trim(); }
        public byte Gender { get => gender; set => gender = value; }
        public string National_Number { get => national_Number; set => national_Number = value; }
        public string Phone_Number1 { get => phone_Number1; set => phone_Number1 = value; }
        public string Phone_Number2 { get => phone_Number2; set => phone_Number2 = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public DateTime Date_Time_Insert { get => date_Time_Insert; set => date_Time_Insert = value; }

        string f_Name; string l_Name; string national_Number; byte gender; string phone_Number1; string phone_Number2;
        DateTime birthdate; DateTime date_Time_Insert; 

        [Required]
        public int Person_ID { get; set; }
        [Required]
        public float Membership_Fee { get; set; }
        [Required]
        public DateTime Start_Membership_Date { get; set; }
        [Required]
        public DateTime End_Membership_Date { get; set; }
        [Required]
        public bool Membership_Status { get; set; }

        int param_Count = 14;
        public void Insert()
        {
            SqlParameter[] parameters = new SqlParameter[param_Count];
            parameters[0] = new SqlParameter("@Edit", false);
            parameters[1] = new SqlParameter("@Person_ID", Person_ID);
            parameters[2] = new SqlParameter("@F_Name", f_Name);
            parameters[3] = new SqlParameter("@L_Name", l_Name);
            parameters[4] = new SqlParameter("@Gender", gender);
            parameters[5] = new SqlParameter("@National_Number", national_Number);
            parameters[6] = new SqlParameter("@Phone_Number1", phone_Number1);
            parameters[7] = new SqlParameter("@Phone_Number2", phone_Number2);
            parameters[8] = new SqlParameter("@Birthdate", birthdate);
            parameters[9] = new SqlParameter("@Date_Time_Insert", date_Time_Insert);
            parameters[10] = new SqlParameter("@Membership_Fee", Membership_Fee);
            parameters[11] = new SqlParameter("@Start_Membership_Date", Start_Membership_Date);
            parameters[12] = new SqlParameter("@End_Membership_Date", End_Membership_Date);
            parameters[13] = new SqlParameter("@Membership_Status", Membership_Status);
            base.Connect();
            base.Exec_Store_Procedre("SP_Insert_Edit_Member", parameters);
            base.Disconnect();
        }
        public void Update()
        {
            SqlParameter[] parameters = new SqlParameter[param_Count];
            parameters[0] = new SqlParameter("@Edit", true);
            parameters[1] = new SqlParameter("@Person_ID", Person_ID);
            parameters[2] = new SqlParameter("@F_Name", f_Name);
            parameters[3] = new SqlParameter("@L_Name", l_Name);
            parameters[4] = new SqlParameter("@Gender", gender);
            parameters[5] = new SqlParameter("@National_Number", national_Number);
            parameters[6] = new SqlParameter("@Phone_Number1", phone_Number1);
            parameters[7] = new SqlParameter("@Phone_Number2", phone_Number2);
            parameters[8] = new SqlParameter("@Birthdate", birthdate);
            parameters[9] = new SqlParameter("@Date_Time_Insert", date_Time_Insert);
            parameters[10] = new SqlParameter("@Membership_Fee", Membership_Fee);
            parameters[11] = new SqlParameter("@Start_Membership_Date", Start_Membership_Date);
            parameters[12] = new SqlParameter("@End_Membership_Date", End_Membership_Date);
            parameters[13] = new SqlParameter("@Membership_Status", Membership_Status);
            base.Connect();
            base.Exec_Store_Procedre("SP_Insert_Edit_Member", parameters);
            base.Disconnect();
        }
        public DataTable Select(string field_Names, string condtion = "")
        {
            condtion = Common_Methods.Check_Query_Condition(condtion);
            base.Connect();
            DataTable dt = base.Select_Data(string.Format("SELECT {0} FROM dbo.tbl_Person INNER JOIN dbo.tbl_Member ON tbl_Member.Person_ID = tbl_Person.ID {1}",
             field_Names, condtion));
            base.Disconnect();
            return dt;
        }
    }
}
