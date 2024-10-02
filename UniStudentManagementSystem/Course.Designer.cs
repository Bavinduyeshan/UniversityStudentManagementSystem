namespace UniStudentManagementSystem
{
    partial class Course
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
            this.DGTCourseList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDep_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCourseName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCourseID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblCourse_des = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC_des = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTCourseList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.btnAdd);
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.btnDel);
            this.guna2Panel1.Controls.Add(this.lblUpdate);
            this.guna2Panel1.Controls.Add(this.lblClear);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 34);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(167, 540);
            this.guna2Panel1.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(18, 47);
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
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(25, 126);
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
            this.lblClear.FillColor = System.Drawing.Color.ForestGreen;
            this.lblClear.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Black;
            this.lblClear.Location = new System.Drawing.Point(25, 270);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(122, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTCourseList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGTCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTCourseList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGTCourseList.ColumnHeadersHeight = 4;
            this.DGTCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTCourseList.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGTCourseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTCourseList.Location = new System.Drawing.Point(784, 111);
            this.DGTCourseList.Name = "DGTCourseList";
            this.DGTCourseList.RowHeadersVisible = false;
            this.DGTCourseList.RowHeadersWidth = 51;
            this.DGTCourseList.RowTemplate.Height = 24;
            this.DGTCourseList.Size = new System.Drawing.Size(800, 305);
            this.DGTCourseList.TabIndex = 40;
            this.DGTCourseList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTCourseList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTCourseList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTCourseList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTCourseList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTCourseList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTCourseList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTCourseList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTCourseList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTCourseList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTCourseList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTCourseList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTCourseList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTCourseList.ThemeStyle.ReadOnly = false;
            this.DGTCourseList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTCourseList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTCourseList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTCourseList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTCourseList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTCourseList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTCourseList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTCourseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTCourseList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1096, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Courses";
            // 
            // cmbDep_ID
            // 
            this.cmbDep_ID.BackColor = System.Drawing.Color.Transparent;
            this.cmbDep_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDep_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDep_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDep_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDep_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDep_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDep_ID.ItemHeight = 30;
            this.cmbDep_ID.Items.AddRange(new object[] {
            "c001"});
            this.cmbDep_ID.Location = new System.Drawing.Point(366, 278);
            this.cmbDep_ID.Name = "cmbDep_ID";
            this.cmbDep_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbDep_ID.TabIndex = 39;
            // 
            // txtCourseName
            // 
            this.txtCourseName.BackColor = System.Drawing.Color.White;
            this.txtCourseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCourseName.HintForeColor = System.Drawing.Color.Empty;
            this.txtCourseName.HintText = "";
            this.txtCourseName.isPassword = false;
            this.txtCourseName.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtCourseName.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtCourseName.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtCourseName.LineThickness = 3;
            this.txtCourseName.Location = new System.Drawing.Point(366, 151);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(379, 33);
            this.txtCourseName.TabIndex = 34;
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCourseID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCourseID.ForeColor = System.Drawing.Color.Black;
            this.txtCourseID.HintForeColor = System.Drawing.Color.Empty;
            this.txtCourseID.HintText = "";
            this.txtCourseID.isPassword = false;
            this.txtCourseID.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtCourseID.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtCourseID.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtCourseID.LineThickness = 3;
            this.txtCourseID.Location = new System.Drawing.Point(366, 95);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(379, 33);
            this.txtCourseID.TabIndex = 33;
            this.txtCourseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseID.OnValueChanged += new System.EventHandler(this.txtCourseID_OnValueChanged);
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.Location = new System.Drawing.Point(182, 278);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(168, 27);
            this.lblDepartmentID.TabIndex = 32;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // lblCourse_des
            // 
            this.lblCourse_des.AutoSize = true;
            this.lblCourse_des.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse_des.Location = new System.Drawing.Point(182, 214);
            this.lblCourse_des.Name = "lblCourse_des";
            this.lblCourse_des.Size = new System.Drawing.Size(215, 27);
            this.lblCourse_des.TabIndex = 28;
            this.lblCourse_des.Text = "Course Description";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(182, 151);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(151, 27);
            this.lblCourseName.TabIndex = 27;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(182, 95);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(115, 27);
            this.lblCourse.TabIndex = 26;
            this.lblCourse.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(663, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // txtC_des
            // 
            this.txtC_des.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtC_des.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtC_des.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtC_des.HintForeColor = System.Drawing.Color.Empty;
            this.txtC_des.HintText = "";
            this.txtC_des.isPassword = false;
            this.txtC_des.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtC_des.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtC_des.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtC_des.LineThickness = 3;
            this.txtC_des.Location = new System.Drawing.Point(366, 208);
            this.txtC_des.Margin = new System.Windows.Forms.Padding(4);
            this.txtC_des.Name = "txtC_des";
            this.txtC_des.Size = new System.Drawing.Size(379, 33);
            this.txtC_des.TabIndex = 35;
            this.txtC_des.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1618, 34);
            this.guna2Panel2.TabIndex = 24;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel3.Location = new System.Drawing.Point(159, 0);
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
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(25, 404);
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
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(25, 197);
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
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(25, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 45);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1618, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGTCourseList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDep_ID);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblCourse_des);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtC_des);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTCourseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTCourseList;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDep_ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCourseName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCourseID;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblCourse_des;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtC_des;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}