namespace Library.UI
{
    partial class Form_Search_Member
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
            this.pnl_Items = new System.Windows.Forms.Panel();
            this.txt_Family = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_National_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Cancel_Membership = new System.Windows.Forms.Button();
            this.btn_Edit_Member = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.National_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membership_Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_Items.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Items
            // 
            this.pnl_Items.Controls.Add(this.txt_Family);
            this.pnl_Items.Controls.Add(this.label4);
            this.pnl_Items.Controls.Add(this.txt_Name);
            this.pnl_Items.Controls.Add(this.label3);
            this.pnl_Items.Controls.Add(this.txt_National_Code);
            this.pnl_Items.Controls.Add(this.label2);
            this.pnl_Items.Controls.Add(this.txt_Code);
            this.pnl_Items.Controls.Add(this.label1);
            this.pnl_Items.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Items.Location = new System.Drawing.Point(0, 0);
            this.pnl_Items.Name = "pnl_Items";
            this.pnl_Items.Size = new System.Drawing.Size(789, 90);
            this.pnl_Items.TabIndex = 0;
            // 
            // txt_Family
            // 
            this.txt_Family.Location = new System.Drawing.Point(13, 31);
            this.txt_Family.Name = "txt_Family";
            this.txt_Family.Size = new System.Drawing.Size(111, 26);
            this.txt_Family.TabIndex = 7;
            this.txt_Family.TextChanged += new System.EventHandler(this.txt_Family_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام خانوادگی :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(225, 31);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(111, 26);
            this.txt_Name.TabIndex = 5;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام :";
            // 
            // txt_National_Code
            // 
            this.txt_National_Code.Location = new System.Drawing.Point(391, 32);
            this.txt_National_Code.MaxLength = 12;
            this.txt_National_Code.Name = "txt_National_Code";
            this.txt_National_Code.Size = new System.Drawing.Size(111, 26);
            this.txt_National_Code.TabIndex = 3;
            this.txt_National_Code.TextChanged += new System.EventHandler(this.txt_National_Code_TextChanged);
            this.txt_National_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد ملی :";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(571, 32);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(111, 26);
            this.txt_Code.TabIndex = 1;
            this.txt_Code.TextChanged += new System.EventHandler(this.txt_Code_TextChanged);
            this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد عضویت :";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.btn_Cancel_Membership);
            this.pnl_Buttons.Controls.Add(this.btn_Edit_Member);
            this.pnl_Buttons.Controls.Add(this.btn_Return);
            this.pnl_Buttons.Controls.Add(this.btn_Borrow);
            this.pnl_Buttons.Controls.Add(this.btn_Search);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 90);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(789, 52);
            this.pnl_Buttons.TabIndex = 1;
            // 
            // btn_Cancel_Membership
            // 
            this.btn_Cancel_Membership.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel_Membership.Location = new System.Drawing.Point(214, 0);
            this.btn_Cancel_Membership.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Cancel_Membership.Name = "btn_Cancel_Membership";
            this.btn_Cancel_Membership.Size = new System.Drawing.Size(115, 52);
            this.btn_Cancel_Membership.TabIndex = 5;
            this.btn_Cancel_Membership.Text = "لغو عضویت";
            this.btn_Cancel_Membership.UseVisualStyleBackColor = true;
            // 
            // btn_Edit_Member
            // 
            this.btn_Edit_Member.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Edit_Member.Location = new System.Drawing.Point(329, 0);
            this.btn_Edit_Member.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Edit_Member.Name = "btn_Edit_Member";
            this.btn_Edit_Member.Size = new System.Drawing.Size(115, 52);
            this.btn_Edit_Member.TabIndex = 4;
            this.btn_Edit_Member.Text = "ویرایش اطلاعات عضو";
            this.btn_Edit_Member.UseVisualStyleBackColor = true;
            // 
            // btn_Return
            // 
            this.btn_Return.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Return.Location = new System.Drawing.Point(444, 0);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(115, 52);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "برگشت";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // btn_Borrow
            // 
            this.btn_Borrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Borrow.Location = new System.Drawing.Point(559, 0);
            this.btn_Borrow.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(115, 52);
            this.btn_Borrow.TabIndex = 2;
            this.btn_Borrow.Text = "امانت";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Search.Location = new System.Drawing.Point(674, 0);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 52);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "لیست گیری";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Visible = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.F_Name,
            this.L_Name,
            this.National_Number,
            this.Membership_Status});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 142);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(789, 356);
            this.grid.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد عضویت";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // F_Name
            // 
            this.F_Name.DataPropertyName = "F_Name";
            this.F_Name.HeaderText = "نام";
            this.F_Name.Name = "F_Name";
            this.F_Name.ReadOnly = true;
            // 
            // L_Name
            // 
            this.L_Name.DataPropertyName = "L_Name";
            this.L_Name.HeaderText = "نام خانوادگی";
            this.L_Name.Name = "L_Name";
            this.L_Name.ReadOnly = true;
            // 
            // National_Number
            // 
            this.National_Number.DataPropertyName = "National_Number";
            this.National_Number.HeaderText = "شماره ملی";
            this.National_Number.Name = "National_Number";
            this.National_Number.ReadOnly = true;
            this.National_Number.Width = 110;
            // 
            // Membership_Status
            // 
            this.Membership_Status.DataPropertyName = "Membership_Status";
            this.Membership_Status.HeaderText = "عضویت فعال";
            this.Membership_Status.Name = "Membership_Status";
            this.Membership_Status.ReadOnly = true;
            this.Membership_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Membership_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_Search_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 498);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.pnl_Items);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Search_Member";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form_Search_Member_Load);
            this.pnl_Items.ResumeLayout(false);
            this.pnl_Items.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Items;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Cancel_Membership;
        private System.Windows.Forms.Button btn_Edit_Member;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_National_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Family;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn National_Number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Membership_Status;
    }
}