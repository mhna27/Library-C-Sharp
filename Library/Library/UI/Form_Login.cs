using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Library.UI
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (cmb_User.SelectedIndex < 0)
            {
                MessageBox.Show("نام کاربری را انتخاب کنید");
                return;
            }
            if (txt_Password.Text == "")
            {
                MessageBox.Show("کلمه عبور را وارد کنید");
                return;
            }
            User user = new User();
            if (user.Select("User_Name", string.Format(
                "WHERE IsNull(Deleted,0)=0 AND tbl_User.ID={0} AND Password='{1}'",
                cmb_User.SelectedValue, txt_Password.Text)).Rows.Count == 0)
            {
                MessageBox.Show("کلمه عبور اشتباه است");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            User user = new User();
            cmb_User.DataSource = user.Select("tbl_User.ID,User_Name", "WHERE IsNull(Deleted,0)=0");
            cmb_User.DisplayMember = "User_Name";
            cmb_User.ValueMember = "ID";
        }
    }
}
