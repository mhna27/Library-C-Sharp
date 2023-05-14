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
    }
}
