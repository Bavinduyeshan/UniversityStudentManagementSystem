namespace UniStudentManagementSystem
{
    partial class Department
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblClear = new Guna.UI2.WinForms.Guna2Button();
            this.DGTDepartmentList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBr_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDep_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDepartmentID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTDepartmentList)).BeginInit();
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
            this.guna2Panel1.Location = new System.Drawing.Point(0, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(167, 575);
            this.guna2Panel1.TabIndex = 55;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
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
            this.lblUpdate.FillColor = System.Drawing.Color.Green;
            this.lblUpdate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(18, 148);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(122, 45);
            this.lblUpdate.TabIndex = 17;
            this.lblUpdate.Text = "UPDATE";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblClear
            // 
            this.lblClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblClear.FillColor = System.Drawing.Color.Green;
            this.lblClear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.White;
            this.lblClear.Location = new System.Drawing.Point(18, 284);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(122, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTDepartmentList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGTDepartmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTDepartmentList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTDepartmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGTDepartmentList.ColumnHeadersHeight = 4;
            this.DGTDepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTDepartmentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGTDepartmentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTDepartmentList.Location = new System.Drawing.Point(785, 110);
            this.DGTDepartmentList.Name = "DGTDepartmentList";
            this.DGTDepartmentList.RowHeadersVisible = false;
            this.DGTDepartmentList.RowHeadersWidth = 51;
            this.DGTDepartmentList.RowTemplate.Height = 24;
            this.DGTDepartmentList.Size = new System.Drawing.Size(800, 305);
            this.DGTDepartmentList.TabIndex = 54;
            this.DGTDepartmentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTDepartmentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTDepartmentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTDepartmentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTDepartmentList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTDepartmentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTDepartmentList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTDepartmentList.ThemeStyle.ReadOnly = false;
            this.DGTDepartmentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTDepartmentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTDepartmentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTDepartmentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTDepartmentList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTDepartmentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTDepartmentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTDepartmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTDepartmentList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(592, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1097, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Departments";
            // 
            // cmbBr_ID
            // 
            this.cmbBr_ID.BackColor = System.Drawing.Color.Transparent;
            this.cmbBr_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBr_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBr_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBr_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBr_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBr_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBr_ID.ItemHeight = 30;
            this.cmbBr_ID.Items.AddRange(new object[] {
            "c001"});
            this.cmbBr_ID.Location = new System.Drawing.Point(394, 213);
            this.cmbBr_ID.Name = "cmbBr_ID";
            this.cmbBr_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbBr_ID.TabIndex = 53;
            // 
            // txtDep_Name
            // 
            this.txtDep_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDep_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDep_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDep_Name.HintForeColor = System.Drawing.Color.Empty;
            this.txtDep_Name.HintText = "";
            this.txtDep_Name.isPassword = false;
            this.txtDep_Name.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDep_Name.LineIdleColor = System.Drawing.Color.Green;
            this.txtDep_Name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDep_Name.LineThickness = 3;
            this.txtDep_Name.Location = new System.Drawing.Point(394, 150);
            this.txtDep_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtDep_Name.Name = "txtDep_Name";
            this.txtDep_Name.Size = new System.Drawing.Size(379, 33);
            this.txtDep_Name.TabIndex = 51;
            this.txtDep_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartmentID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepartmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepartmentID.HintForeColor = System.Drawing.Color.Empty;
            this.txtDepartmentID.HintText = "";
            this.txtDepartmentID.isPassword = false;
            this.txtDepartmentID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDepartmentID.LineIdleColor = System.Drawing.Color.Green;
            this.txtDepartmentID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDepartmentID.LineThickness = 3;
            this.txtDepartmentID.Location = new System.Drawing.Point(394, 94);
            this.txtDepartmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(379, 33);
            this.txtDepartmentID.TabIndex = 50;
            this.txtDepartmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchID.Location = new System.Drawing.Point(192, 213);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(118, 27);
            this.lblBranchID.TabIndex = 49;
            this.lblBranchID.Text = "Branch ID";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(183, 150);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(204, 27);
            this.lblDepartmentName.TabIndex = 47;
            this.lblDepartmentName.Text = "Department Name";
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.Location = new System.Drawing.Point(183, 94);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(168, 27);
            this.lblDepartmentID.TabIndex = 46;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1616, 26);
            this.guna2Panel2.TabIndex = 44;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel3.Location = new System.Drawing.Point(169, 26);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(17, 681);
            this.guna2Panel3.TabIndex = 67;
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
            this.btnExit.Location = new System.Drawing.Point(18, 423);
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
            this.btnDel.Location = new System.Drawing.Point(18, 215);
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
            this.btnBack.Location = new System.Drawing.Point(18, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 45);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1616, 601);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGTDepartmentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBr_ID);
            this.Controls.Add(this.txtDep_Name);
            this.Controls.Add(this.txtDepartmentID);
            this.Controls.Add(this.lblBranchID);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTDepartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTDepartmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBr_ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDep_Name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDepartmentID;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}