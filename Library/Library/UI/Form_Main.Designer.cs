namespace Library.UI
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Right = new System.Windows.Forms.Panel();
            this.btn_User_Management = new System.Windows.Forms.Button();
            this.btn_Book_Management = new System.Windows.Forms.Button();
            this.btn_Member_Management = new System.Windows.Forms.Button();
            this.btn_Borrow_Return = new System.Windows.Forms.Button();
            this.btn_New_Member = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.pnl_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Right
            // 
            this.pnl_Right.Controls.Add(this.btn_Backup);
            this.pnl_Right.Controls.Add(this.btn_Home);
            this.pnl_Right.Controls.Add(this.btn_User_Management);
            this.pnl_Right.Controls.Add(this.btn_Book_Management);
            this.pnl_Right.Controls.Add(this.btn_Member_Management);
            this.pnl_Right.Controls.Add(this.btn_Borrow_Return);
            this.pnl_Right.Controls.Add(this.btn_New_Member);
            this.pnl_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Right.Location = new System.Drawing.Point(765, 0);
            this.pnl_Right.Name = "pnl_Right";
            this.pnl_Right.Size = new System.Drawing.Size(222, 610);
            this.pnl_Right.TabIndex = 0;
            this.pnl_Right.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Right_Paint);
            // 
            // btn_User_Management
            // 
            this.btn_User_Management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_User_Management.Location = new System.Drawing.Point(0, 220);
            this.btn_User_Management.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_User_Management.Name = "btn_User_Management";
            this.btn_User_Management.Size = new System.Drawing.Size(222, 55);
            this.btn_User_Management.TabIndex = 4;
            this.btn_User_Management.Text = "مدیریت کاربران";
            this.btn_User_Management.UseVisualStyleBackColor = true;
            // 
            // btn_Book_Management
            // 
            this.btn_Book_Management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Book_Management.Location = new System.Drawing.Point(0, 165);
            this.btn_Book_Management.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_Book_Management.Name = "btn_Book_Management";
            this.btn_Book_Management.Size = new System.Drawing.Size(222, 55);
            this.btn_Book_Management.TabIndex = 3;
            this.btn_Book_Management.Text = "مدیریت کتابها";
            this.btn_Book_Management.UseVisualStyleBackColor = true;
            // 
            // btn_Member_Management
            // 
            this.btn_Member_Management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Member_Management.Location = new System.Drawing.Point(0, 110);
            this.btn_Member_Management.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_Member_Management.Name = "btn_Member_Management";
            this.btn_Member_Management.Size = new System.Drawing.Size(222, 55);
            this.btn_Member_Management.TabIndex = 2;
            this.btn_Member_Management.Text = "مدیریت اعضا";
            this.btn_Member_Management.UseVisualStyleBackColor = true;
            // 
            // btn_Borrow_Return
            // 
            this.btn_Borrow_Return.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Borrow_Return.Location = new System.Drawing.Point(0, 55);
            this.btn_Borrow_Return.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_Borrow_Return.Name = "btn_Borrow_Return";
            this.btn_Borrow_Return.Size = new System.Drawing.Size(222, 55);
            this.btn_Borrow_Return.TabIndex = 1;
            this.btn_Borrow_Return.Text = "امانت و برگشت";
            this.btn_Borrow_Return.UseVisualStyleBackColor = true;
            // 
            // btn_New_Member
            // 
            this.btn_New_Member.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_New_Member.Location = new System.Drawing.Point(0, 0);
            this.btn_New_Member.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_New_Member.Name = "btn_New_Member";
            this.btn_New_Member.Size = new System.Drawing.Size(222, 55);
            this.btn_New_Member.TabIndex = 0;
            this.btn_New_Member.Text = "عضو جدید";
            this.btn_New_Member.UseVisualStyleBackColor = true;
            this.btn_New_Member.Click += new System.EventHandler(this.btn_New_Member_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(765, 610);
            this.pnl_Main.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.Location = new System.Drawing.Point(0, 275);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(222, 55);
            this.btn_Home.TabIndex = 7;
            this.btn_Home.Text = "صفحه اصلی";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // btn_Backup
            // 
            this.btn_Backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Backup.Location = new System.Drawing.Point(0, 330);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(20, 50, 20, 3);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(222, 55);
            this.btn_Backup.TabIndex = 8;
            this.btn_Backup.Text = "پشتیبان گیری";
            this.btn_Backup.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 610);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Right);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار مدیریت کتابخانه";
            this.pnl_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Right;
        private System.Windows.Forms.Button btn_Borrow_Return;
        private System.Windows.Forms.Button btn_New_Member;
        private System.Windows.Forms.Button btn_User_Management;
        private System.Windows.Forms.Button btn_Book_Management;
        private System.Windows.Forms.Button btn_Member_Management;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Home;
    }
}