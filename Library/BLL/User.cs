using BLL.Common_Class;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User : Data_Access, IPerson
    {
        public string F_Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string L_Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string National_Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone_Number1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone_Number2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Birthdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date_Time_Insert { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        


        [Required]
        public int Person_ID { get; set; }
        [Required]
        public byte User_Type_ID { get; set; }
        [Required]
        public string User_Name { get; set; }
        [Required]
        public string Password { get; set; }
        public bool Deleted { get; set; } = false;

        int param_Count = 14;
        public void Insert()
        {
            SqlParameter[] parameters = new SqlParameter[param_Count];
            parameters[0] = new SqlParameter("@Edit", 0);
            parameters[1] = new SqlParameter("@Person_ID", Person_ID);
            parameters[2] = new SqlParameter("@F_Name", F_Name);
            parameters[3] = new SqlParameter("@L_Name", L_Name);
            parameters[4] = new SqlParameter("@Gender", Gender);
            parameters[5] = new SqlParameter("@National_Number", National_Number);
            parameters[6] = new SqlParameter("@Phone_Number1", Phone_Number1);
            parameters[7] = new SqlParameter("@Phone_Number2", Phone_Number2);
            parameters[8] = new SqlParameter("@Birthdate", Birthdate);
            parameters[9] = new SqlParameter("@Date_Time_Insert", Date_Time_Insert);
            parameters[10] = new SqlParameter("@User_Type_ID", User_Type_ID);
            parameters[11] = new SqlParameter("@User_Name", User_Name);
            parameters[12] = new SqlParameter("@Password", Password);
            parameters[13] = new SqlParameter("@Deleted", Deleted);
            base.Connect();
            base.Exec_Store_Procedre("SP_Insert_Edit_User", parameters);
            base.Disconnect();
        }
        public void Update()
        {
            SqlParameter[] parameters = new SqlParameter[param_Count];
            parameters[0] = new SqlParameter("@Edit", 1);
            parameters[1] = new SqlParameter("@Person_ID", Person_ID);
            parameters[2] = new SqlParameter("@F_Name", F_Name);
            parameters[3] = new SqlParameter("@L_Name", L_Name);
            parameters[4] = new SqlParameter("@Gender", Gender);
            parameters[5] = new SqlParameter("@National_Number", National_Number);
            parameters[6] = new SqlParameter("@Phone_Number1", Phone_Number1);
            parameters[7] = new SqlParameter("@Phone_Number2", Phone_Number2);
            parameters[8] = new SqlParameter("@Birthdate", Birthdate);
            parameters[9] = new SqlParameter("@Date_Time_Insert", Date_Time_Insert);
            parameters[10] = new SqlParameter("@User_Type_ID", User_Type_ID);
            parameters[11] = new SqlParameter("@User_Name", User_Name);
            parameters[12] = new SqlParameter("@Password", Password);
            parameters[13] = new SqlParameter("@Deleted", Deleted);
            base.Connect();
            base.Exec_Store_Procedre("SP_Insert_Edit_User", parameters);
            base.Disconnect();
        }
        public DataTable Select(string field_Names, string condtion = "")
        {
            condtion = Common_Methods.Check_Query_Condition(condtion);
            base.Connect();
            DataTable dt = base.Select_Data(string.Format("SELECT {0} FROM dbo.tbl_Person INNER JOIN dbo.tbl_User ON tbl_User.Person_ID = tbl_Person.ID {1}",
             field_Names, condtion));
            base.Disconnect();
            return dt;
        }
    }
}
