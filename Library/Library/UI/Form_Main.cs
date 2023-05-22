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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void pnl_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_New_Member_Click(object sender, EventArgs e)
        {
            Form_New_Member frm_New = new Form_New_Member();
            frm_New.TopLevel = false;
            pnl_Main.Controls.Add(frm_New);
            frm_New.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_New.Dock = DockStyle.Fill;
            frm_New.Show();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Form_Login frm_Login = new Form_Login();
            if (frm_Login.ShowDialog() != DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
            frm_Login.Close();
            frm_Login.Dispose();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            foreach (Form f in pnl_Main.Controls.OfType<Form>())
            {
                f.Dispose();
            }
        }
    }
}
