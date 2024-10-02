namespace UniStudentManagementSystem
{
    partial class Module
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
            this.DGTModuleList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLec_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtModuleName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtModuleID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLectureID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.lblModuleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbC_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.DTPSDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DTPEdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTModuleList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnDel);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.lblUpdate);
            this.guna2Panel1.Controls.Add(this.lblClear);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 29);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(159, 561);
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
            this.lblUpdate.Location = new System.Drawing.Point(25, 148);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(122, 45);
            this.lblUpdate.TabIndex = 17;
            this.lblUpdate.Text = "UPDATE";
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
            this.lblClear.Location = new System.Drawing.Point(25, 305);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(122, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTModuleList
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGTModuleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGTModuleList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTModuleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGTModuleList.ColumnHeadersHeight = 4;
            this.DGTModuleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTModuleList.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGTModuleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTModuleList.Location = new System.Drawing.Point(785, 111);
            this.DGTModuleList.Name = "DGTModuleList";
            this.DGTModuleList.RowHeadersVisible = false;
            this.DGTModuleList.RowHeadersWidth = 51;
            this.DGTModuleList.RowTemplate.Height = 24;
            this.DGTModuleList.Size = new System.Drawing.Size(800, 305);
            this.DGTModuleList.TabIndex = 54;
            this.DGTModuleList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTModuleList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTModuleList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTModuleList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTModuleList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTModuleList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTModuleList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTModuleList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTModuleList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTModuleList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTModuleList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTModuleList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTModuleList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTModuleList.ThemeStyle.ReadOnly = false;
            this.DGTModuleList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTModuleList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTModuleList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTModuleList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTModuleList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTModuleList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTModuleList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTModuleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTModuleList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1097, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Student List";
            // 
            // cmbLec_ID
            // 
            this.cmbLec_ID.BackColor = System.Drawing.Color.Transparent;
            this.cmbLec_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLec_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLec_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLec_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLec_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLec_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLec_ID.ItemHeight = 30;
            this.cmbLec_ID.Items.AddRange(new object[] {
            "c001"});
            this.cmbLec_ID.Location = new System.Drawing.Point(367, 350);
            this.cmbLec_ID.Name = "cmbLec_ID";
            this.cmbLec_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbLec_ID.TabIndex = 53;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModuleName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtModuleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModuleName.HintForeColor = System.Drawing.Color.Empty;
            this.txtModuleName.HintText = "";
            this.txtModuleName.isPassword = false;
            this.txtModuleName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtModuleName.LineIdleColor = System.Drawing.Color.Green;
            this.txtModuleName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtModuleName.LineThickness = 3;
            this.txtModuleName.Location = new System.Drawing.Point(367, 167);
            this.txtModuleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(379, 33);
            this.txtModuleName.TabIndex = 51;
            this.txtModuleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModuleID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtModuleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModuleID.HintForeColor = System.Drawing.Color.Empty;
            this.txtModuleID.HintText = "";
            this.txtModuleID.isPassword = false;
            this.txtModuleID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtModuleID.LineIdleColor = System.Drawing.Color.Green;
            this.txtModuleID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtModuleID.LineThickness = 3;
            this.txtModuleID.Location = new System.Drawing.Point(367, 111);
            this.txtModuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(379, 33);
            this.txtModuleID.TabIndex = 50;
            this.txtModuleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblLectureID
            // 
            this.lblLectureID.AutoSize = true;
            this.lblLectureID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureID.Location = new System.Drawing.Point(183, 350);
            this.lblLectureID.Name = "lblLectureID";
            this.lblLectureID.Size = new System.Drawing.Size(122, 27);
            this.lblLectureID.TabIndex = 49;
            this.lblLectureID.Text = "Lecture ID";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(183, 230);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(116, 27);
            this.lblStartDate.TabIndex = 48;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(183, 167);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(156, 27);
            this.lblModuleName.TabIndex = 47;
            this.lblModuleName.Text = "Module Name";
            // 
            // lblModuleID
            // 
            this.lblModuleID.AutoSize = true;
            this.lblModuleID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleID.Location = new System.Drawing.Point(183, 111);
            this.lblModuleID.Name = "lblModuleID";
            this.lblModuleID.Size = new System.Drawing.Size(115, 27);
            this.lblModuleID.TabIndex = 46;
            this.lblModuleID.Text = "ModuleID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(725, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modules";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1688, 29);
            this.guna2Panel2.TabIndex = 44;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(183, 294);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(106, 27);
            this.lblEndDate.TabIndex = 56;
            this.lblEndDate.Text = "End Date";
            // 
            // cmbC_ID
            // 
            this.cmbC_ID.BackColor = System.Drawing.Color.Transparent;
            this.cmbC_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbC_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbC_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbC_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbC_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbC_ID.ItemHeight = 30;
            this.cmbC_ID.Items.AddRange(new object[] {
            "c001"});
            this.cmbC_ID.Location = new System.Drawing.Point(367, 399);
            this.cmbC_ID.Name = "cmbC_ID";
            this.cmbC_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbC_ID.TabIndex = 58;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(183, 399);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(115, 27);
            this.lblCourseID.TabIndex = 57;
            this.lblCourseID.Text = "Course ID";
            // 
            // DTPSDate
            // 
            this.DTPSDate.BackColor = System.Drawing.Color.SeaGreen;
            this.DTPSDate.BorderRadius = 0;
            this.DTPSDate.ForeColor = System.Drawing.Color.White;
            this.DTPSDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPSDate.FormatCustom = null;
            this.DTPSDate.Location = new System.Drawing.Point(367, 231);
            this.DTPSDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPSDate.Name = "DTPSDate";
            this.DTPSDate.Size = new System.Drawing.Size(404, 44);
            this.DTPSDate.TabIndex = 59;
            this.DTPSDate.Value = new System.DateTime(2024, 9, 27, 13, 29, 43, 103);
            // 
            // DTPEdate
            // 
            this.DTPEdate.BackColor = System.Drawing.Color.SeaGreen;
            this.DTPEdate.BorderRadius = 0;
            this.DTPEdate.ForeColor = System.Drawing.Color.White;
            this.DTPEdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTPEdate.FormatCustom = null;
            this.DTPEdate.Location = new System.Drawing.Point(367, 294);
            this.DTPEdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPEdate.Name = "DTPEdate";
            this.DTPEdate.Size = new System.Drawing.Size(404, 44);
            this.DTPEdate.TabIndex = 60;
            this.DTPEdate.Value = new System.DateTime(2024, 9, 27, 13, 29, 43, 103);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel3.Location = new System.Drawing.Point(160, 29);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(17, 681);
            this.guna2Panel3.TabIndex = 67;
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
            this.btnBack.Location = new System.Drawing.Point(25, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 45);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnDel.Location = new System.Drawing.Point(25, 231);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 45);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnExit.Location = new System.Drawing.Point(25, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 45);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1688, 590);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPEdate);
            this.Controls.Add(this.DTPSDate);
            this.Controls.Add(this.cmbC_ID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGTModuleList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLec_ID);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.lblLectureID);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblModuleName);
            this.Controls.Add(this.lblModuleID);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Module";
            this.Text = "Module";
            this.Load += new System.EventHandler(this.Module_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTModuleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTModuleList;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLec_ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtModuleName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtModuleID;
        private System.Windows.Forms.Label lblLectureID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModuleID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblEndDate;
        private Guna.UI2.WinForms.Guna2ComboBox cmbC_ID;
        private System.Windows.Forms.Label lblCourseID;
        private Bunifu.Framework.UI.BunifuDatepicker DTPSDate;
        private Bunifu.Framework.UI.BunifuDatepicker DTPEdate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}