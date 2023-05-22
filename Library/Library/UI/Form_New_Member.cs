using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library.UI
{
    public partial class Form_New_Member : Form
    {
        public Form_New_Member()
        {
            InitializeComponent();
        }

        private void Form_New_Member_Load(object sender, EventArgs e)
        {
            Clear_Items();
        }

        private void txt_National_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_National_Number.Text.Length < 10)
            {
                MessageBox.Show("کد ملی را به درستی وارد کنید");
                txt_National_Number.Focus();
                return;
            }
            if (cmb_Gender.SelectedIndex < 0)
            {
                MessageBox.Show("جنسیت را انتخاب کنید");
                cmb_Gender.Focus();
                return;
            }
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("نام را وارد کنید");
                txt_Name.Focus();
                return;
            }
            if (txt_Family.Text.Trim() == "")
            {
                MessageBox.Show("نام خانوادگی را وارد کنید");
                txt_Family.Focus();
                return;
            }
            if (txt_Phone_Number.Text.Length < 11)
            {
                MessageBox.Show("شماره موبایل را به درستی وارد کنید");
                txt_Phone_Number.Focus();
                return;
            }
            if (txt_Phone_Number2.Text.Length < 11)
            {
                MessageBox.Show("شماره موبایل را به درستی وارد کنید");
                txt_Phone_Number2.Focus();
                return;
            }
            if (txt_Phone_Number.Text == txt_Phone_Number2.Text)
            {
                MessageBox.Show("شماره های موبایل با متفاوت باشند");
                txt_Phone_Number.Focus();
                return;
            }
            if (txt_Membership_Fee.Text == "")
            {
                MessageBox.Show("هزینه عضویت را وارد کنید");
                txt_Membership_Fee.Focus();
                return;
            }
            if (date_Birthdate.Value == null)
            {
                MessageBox.Show("تاریخ تولد را وارد کنید");
                date_Birthdate.Focus();
                return;
            }
            if (date_Start_Membership.Value == null)
            {
                MessageBox.Show("تاریخ شروع عضویت را وارد کنید");
                date_Birthdate.Focus();
                return;
            }
            if (date_End_Membership.Value == null)
            {
                MessageBox.Show("تاریخ پایان عضویت را وارد کنید");
                date_Birthdate.Focus();
                return;
            }
            Member member = new Member
            {
                National_Number = txt_National_Number.Text,
                F_Name = txt_Name.Text,
                L_Name = txt_Family.Text,
                Gender = Convert.ToByte(cmb_Gender.SelectedValue),
                Birthdate = (DateTime)date_Birthdate.Value,
                Start_Membership_Date = (DateTime)date_Start_Membership.Value,
                End_Membership_Date = (DateTime)date_End_Membership.Value,
                Phone_Number1 = txt_Phone_Number.Text,
                Phone_Number2 = txt_Phone_Number2.Text,
                Membership_Fee = float.Parse(txt_Membership_Fee.Text),
                Membership_Status = true,
                Date_Time_Insert = DateTime.Now
            };
            member.Insert();
        }
        private void Clear_Items()
        {
            Member member = new Member();
            DataTable dt = member.Select("MAX(tbl_Member.ID) AS max_ID");
            txt_Code.Text = dt.Rows[0]["max_ID"].ToString() == "" ? "1"
                : dt.Rows[0]["max_ID"].ToString();

            Gender gender = new Gender();
            cmb_Gender.DataSource = gender.Select("*");
            cmb_Gender.DisplayMember = "Title";
            cmb_Gender.ValueMember = "ID";

            txt_National_Number.Text = "0";
            txt_Name.Text = "";
            txt_Family.Text = "";
            date_Birthdate.Value = null;
            date_Start_Membership.Value = null;
            date_End_Membership.Value = null;
            txt_Phone_Number.Text = "0";
            txt_Phone_Number2.Text = "0";
            txt_Membership_Fee.Text = "0";
        }
    }
}
