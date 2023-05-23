using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.UI
{
    public enum Search_Display_Type { Borrow_Return, Member_Management }
    public partial class Form_Search_Member : Form
    {
        Member member = new Member();

        public Form_Search_Member(Search_Display_Type search_Display_Type)
        {
            InitializeComponent();
            switch (search_Display_Type)
            {
                case Search_Display_Type.Borrow_Return:
                    btn_Edit_Member.Visible = false;
                    btn_Cancel_Membership.Visible = false;
                    break;
                case Search_Display_Type.Member_Management:
                    btn_Borrow.Visible = false;
                    btn_Return.Visible = false;
                    break;
            }
        }

        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form_Search_Member_Load(object sender, EventArgs e)
        {
            Search_Member("");
        }

        private void Search_Member(string filter_Sql)
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = member.Select(
                "Top 100 dbo.tbl_Member.ID,F_Name,L_Name,National_Number,Membership_Status", filter_Sql);
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
            if (txt_Code.Text == "")
                Search_Member("");
            else
                Search_Member("Where tbl_Person.ID=" + txt_Code.Text);
        }

        private void txt_National_Code_TextChanged(object sender, EventArgs e)
        {
            if (txt_National_Code.Text == "")
                Search_Member("");
            else
                Search_Member("Where National_Number Like '" + txt_National_Code.Text + "%'");
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
                Search_Member("");
            else
                Search_Member("Where F_Name Like '%" + txt_Name.Text + "%'");
        }

        private void txt_Family_TextChanged(object sender, EventArgs e)
        {
            if (txt_Family.Text == "")
                Search_Member("");
            else
                Search_Member("Where L_Name Like '%" + txt_Family.Text + "%'");
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {

        }
    }
}
