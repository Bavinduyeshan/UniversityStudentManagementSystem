namespace UniStudentManagementSystem
{
    partial class Form1
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtStudentID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Dtp1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbCourseID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lblUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblClear = new Guna.UI2.WinForms.Guna2Button();
            this.DGTStudentList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGTStudentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1631, 28);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(600, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(183, 94);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(123, 27);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(183, 150);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(127, 27);
            this.lblFname.TabIndex = 3;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(183, 213);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(121, 27);
            this.lblLname.TabIndex = 4;
            this.lblLname.Text = "Last Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(183, 278);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(59, 27);
            this.lblDob.TabIndex = 5;
            this.lblDob.Text = "DOB";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(183, 327);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 27);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(183, 376);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 27);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(183, 502);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(110, 27);
            this.lblCourseID.TabIndex = 8;
            this.lblCourseID.Text = "CourseID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentID.HintForeColor = System.Drawing.Color.Empty;
            this.txtStudentID.HintText = "";
            this.txtStudentID.isPassword = false;
            this.txtStudentID.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtStudentID.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtStudentID.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtStudentID.LineThickness = 3;
            this.txtStudentID.Location = new System.Drawing.Point(367, 94);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(379, 33);
            this.txtStudentID.TabIndex = 9;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFName
            // 
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFName.HintText = "";
            this.txtFName.isPassword = false;
            this.txtFName.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtFName.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtFName.LineMouseHoverColor = System.Drawing.Color.Orange;
            this.txtFName.LineThickness = 3;
            this.txtFName.Location = new System.Drawing.Point(367, 150);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(379, 33);
            this.txtFName.TabIndex = 10;
            this.txtFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLName
            // 
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLName.HintForeColor = System.Drawing.Color.Empty;
            this.txtLName.HintText = "";
            this.txtLName.isPassword = false;
            this.txtLName.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtLName.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtLName.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtLName.LineThickness = 3;
            this.txtLName.Location = new System.Drawing.Point(367, 207);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(379, 33);
            this.txtLName.TabIndex = 11;
            this.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.txtAddress.LineThickness = 3;
            this.txtAddress.Location = new System.Drawing.Point(367, 370);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(379, 33);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Dtp1
            // 
            this.Dtp1.BackColor = System.Drawing.Color.Honeydew;
            this.Dtp1.BorderRadius = 0;
            this.Dtp1.ForeColor = System.Drawing.Color.White;
            this.Dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtp1.FormatCustom = null;
            this.Dtp1.Location = new System.Drawing.Point(367, 278);
            this.Dtp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp1.Name = "Dtp1";
            this.Dtp1.Size = new System.Drawing.Size(404, 44);
            this.Dtp1.TabIndex = 13;
            this.Dtp1.Value = new System.DateTime(2024, 9, 26, 20, 0, 12, 220);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(367, 327);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(140, 36);
            this.cmbGender.TabIndex = 14;
            // 
            // cmbCourseID
            // 
            this.cmbCourseID.BackColor = System.Drawing.Color.Transparent;
            this.cmbCourseID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCourseID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCourseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCourseID.ItemHeight = 30;
            this.cmbCourseID.Items.AddRange(new object[] {
            "c001"});
            this.cmbCourseID.Location = new System.Drawing.Point(367, 502);
            this.cmbCourseID.Name = "cmbCourseID";
            this.cmbCourseID.Size = new System.Drawing.Size(140, 36);
            this.cmbCourseID.TabIndex = 15;
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
            this.btnAdd.Location = new System.Drawing.Point(12, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 45);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
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
            this.lblUpdate.Location = new System.Drawing.Point(12, 180);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(136, 45);
            this.lblUpdate.TabIndex = 17;
            this.lblUpdate.Text = "UPDATE";
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.lblDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.lblDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.lblDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.lblDelete.FillColor = System.Drawing.Color.ForestGreen;
            this.lblDelete.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Black;
            this.lblDelete.Location = new System.Drawing.Point(12, 283);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(136, 45);
            this.lblDelete.TabIndex = 18;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
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
            this.lblClear.Location = new System.Drawing.Point(12, 355);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(136, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTStudentList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGTStudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTStudentList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGTStudentList.ColumnHeadersHeight = 4;
            this.DGTStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTStudentList.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGTStudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTStudentList.Location = new System.Drawing.Point(785, 110);
            this.DGTStudentList.Name = "DGTStudentList";
            this.DGTStudentList.RowHeadersVisible = false;
            this.DGTStudentList.RowHeadersWidth = 51;
            this.DGTStudentList.RowTemplate.Height = 24;
            this.DGTStudentList.Size = new System.Drawing.Size(800, 305);
            this.DGTStudentList.TabIndex = 20;
            this.DGTStudentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTStudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTStudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTStudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTStudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTStudentList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTStudentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTStudentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTStudentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTStudentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTStudentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTStudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTStudentList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTStudentList.ThemeStyle.ReadOnly = false;
            this.DGTStudentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTStudentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTStudentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTStudentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTStudentList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTStudentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTStudentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTStudentList_CellContentClick);
            // 
            // btnEmail
            // 
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmail.HintForeColor = System.Drawing.Color.Empty;
            this.btnEmail.HintText = "";
            this.btnEmail.isPassword = false;
            this.btnEmail.LineFocusedColor = System.Drawing.Color.DarkGreen;
            this.btnEmail.LineIdleColor = System.Drawing.Color.PaleGreen;
            this.btnEmail.LineMouseHoverColor = System.Drawing.Color.DarkGreen;
            this.btnEmail.LineThickness = 3;
            this.btnEmail.Location = new System.Drawing.Point(367, 432);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(379, 33);
            this.btnEmail.TabIndex = 22;
            this.btnEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(183, 438);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(71, 27);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(1097, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblClear);
            this.panel1.Controls.Add(this.lblUpdate);
            this.panel1.Controls.Add(this.lblDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 536);
            this.panel1.TabIndex = 23;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Location = new System.Drawing.Point(160, 28);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(17, 536);
            this.guna2Panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1631, 564);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.DGTStudentList);
            this.Controls.Add(this.cmbCourseID);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.Dtp1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTStudentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCourseID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStudentID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuDatepicker Dtp1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCourseID;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblDelete;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTStudentList;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

