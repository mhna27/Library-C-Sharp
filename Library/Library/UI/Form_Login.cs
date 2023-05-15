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
            Form_Main form_Main = new Form_Main();
            form_Main.ShowDialog();
            this.Close();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            User user = new User();
            cmb_User.DataBindings.Clear();
            //cmb_User.DataBindings.Add("Text", user.Select("User_Name", "WHERE IsNull(Deleted,0)=0"), "User_Name");

            cmb_User.DataSource = user.Select("tbl_User.ID,User_Name", "WHERE IsNull(Deleted,0)=0");
            cmb_User.DisplayMember = "User_Name";
            cmb_User.ValueMember = "ID";
        }
    }
}
