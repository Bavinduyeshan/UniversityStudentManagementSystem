namespace UniStudentManagementSystem
{
    partial class Branch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblClear = new Guna.UI2.WinForms.Guna2Button();
            this.DGTBranchList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBranchName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBranchID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTBranchList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.btnDel);
            this.guna2Panel1.Controls.Add(this.lblUpdate);
            this.guna2Panel1.Controls.Add(this.lblClear);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 23);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(152, 681);
            this.guna2Panel1.TabIndex = 65;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Purple;
            this.btnAdd.Location = new System.Drawing.Point(18, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 45);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblUpdate.FillColor = System.Drawing.Color.ForestGreen;
            this.lblUpdate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Purple;
            this.lblUpdate.Location = new System.Drawing.Point(18, 172);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(129, 45);
            this.lblUpdate.TabIndex = 17;
            this.lblUpdate.Text = "UPDATE";
            // 
            // lblClear
            // 
            this.lblClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblClear.FillColor = System.Drawing.Color.ForestGreen;
            this.lblClear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Purple;
            this.lblClear.Location = new System.Drawing.Point(20, 332);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(129, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTBranchList
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGTBranchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGTBranchList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTBranchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGTBranchList.ColumnHeadersHeight = 4;
            this.DGTBranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTBranchList.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGTBranchList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTBranchList.Location = new System.Drawing.Point(784, 112);
            this.DGTBranchList.Name = "DGTBranchList";
            this.DGTBranchList.RowHeadersVisible = false;
            this.DGTBranchList.RowHeadersWidth = 51;
            this.DGTBranchList.RowTemplate.Height = 24;
            this.DGTBranchList.Size = new System.Drawing.Size(800, 305);
            this.DGTBranchList.TabIndex = 64;
            this.DGTBranchList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTBranchList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTBranchList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTBranchList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTBranchList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTBranchList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTBranchList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTBranchList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTBranchList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTBranchList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTBranchList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTBranchList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTBranchList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTBranchList.ThemeStyle.ReadOnly = false;
            this.DGTBranchList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTBranchList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTBranchList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTBranchList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTBranchList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTBranchList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTBranchList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTBranchList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTBranchList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(632, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1096, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Branches";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBranchName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBranchName.ForeColor = System.Drawing.Color.Black;
            this.txtBranchName.HintForeColor = System.Drawing.Color.Empty;
            this.txtBranchName.HintText = "";
            this.txtBranchName.isPassword = false;
            this.txtBranchName.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtBranchName.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtBranchName.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtBranchName.LineThickness = 3;
            this.txtBranchName.Location = new System.Drawing.Point(393, 152);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(379, 33);
            this.txtBranchName.TabIndex = 62;
            this.txtBranchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBranchID
            // 
            this.txtBranchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBranchID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBranchID.ForeColor = System.Drawing.Color.Black;
            this.txtBranchID.HintForeColor = System.Drawing.Color.Empty;
            this.txtBranchID.HintText = "";
            this.txtBranchID.isPassword = false;
            this.txtBranchID.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtBranchID.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtBranchID.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtBranchID.LineThickness = 3;
            this.txtBranchID.Location = new System.Drawing.Point(393, 96);
            this.txtBranchID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(379, 33);
            this.txtBranchID.TabIndex = 61;
            this.txtBranchID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.ForeColor = System.Drawing.Color.Black;
            this.lblBranchName.Location = new System.Drawing.Point(182, 152);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(159, 27);
            this.lblBranchName.TabIndex = 59;
            this.lblBranchName.Text = "Branch  Name";
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchID.ForeColor = System.Drawing.Color.Black;
            this.lblBranchID.Location = new System.Drawing.Point(182, 96);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(118, 27);
            this.lblBranchID.TabIndex = 58;
            this.lblBranchID.Text = "Branch ID";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1634, 23);
            this.guna2Panel2.TabIndex = 56;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel3.Location = new System.Drawing.Point(153, 23);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(17, 681);
            this.guna2Panel3.TabIndex = 66;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Green;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(25, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 45);
            this.btnExit.TabIndex = 72;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.Green;
            this.btnDel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(25, 261);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 45);
            this.btnDel.TabIndex = 71;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(25, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 45);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1634, 704);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGTBranchList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.lblBranchID);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Branch";
            this.Text = "Branch";
            this.Load += new System.EventHandler(this.Branch_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTBranchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTBranchList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBranchName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBranchID;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblBranchID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}