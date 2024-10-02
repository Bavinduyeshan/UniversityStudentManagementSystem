namespace UniStudentManagementSystem
{
    partial class Lecture
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
            this.DGTLectureList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDep_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLectureName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLectureID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDepartmentID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLec_Name = new System.Windows.Forms.Label();
            this.lblLectureID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbB_ID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblB_ID = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTLectureList)).BeginInit();
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
            this.guna2Panel1.Location = new System.Drawing.Point(0, 25);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(155, 538);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 45);
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
            this.lblUpdate.Location = new System.Drawing.Point(18, 145);
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
            this.lblClear.Location = new System.Drawing.Point(18, 294);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(122, 45);
            this.lblClear.TabIndex = 19;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // DGTLectureList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGTLectureList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTLectureList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTLectureList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGTLectureList.ColumnHeadersHeight = 4;
            this.DGTLectureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTLectureList.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGTLectureList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTLectureList.Location = new System.Drawing.Point(786, 111);
            this.DGTLectureList.Name = "DGTLectureList";
            this.DGTLectureList.RowHeadersVisible = false;
            this.DGTLectureList.RowHeadersWidth = 51;
            this.DGTLectureList.RowTemplate.Height = 24;
            this.DGTLectureList.Size = new System.Drawing.Size(800, 305);
            this.DGTLectureList.TabIndex = 54;
            this.DGTLectureList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTLectureList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTLectureList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTLectureList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTLectureList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTLectureList.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DGTLectureList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTLectureList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTLectureList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGTLectureList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTLectureList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTLectureList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTLectureList.ThemeStyle.HeaderStyle.Height = 4;
            this.DGTLectureList.ThemeStyle.ReadOnly = false;
            this.DGTLectureList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTLectureList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTLectureList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTLectureList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTLectureList.ThemeStyle.RowsStyle.Height = 24;
            this.DGTLectureList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTLectureList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTLectureList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTLectureList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(1098, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lecture List";
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
            this.cmbDep_ID.Location = new System.Drawing.Point(368, 299);
            this.cmbDep_ID.Name = "cmbDep_ID";
            this.cmbDep_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbDep_ID.TabIndex = 53;
            // 
            // txtLectureName
            // 
            this.txtLectureName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLectureName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLectureName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLectureName.HintForeColor = System.Drawing.Color.Empty;
            this.txtLectureName.HintText = "";
            this.txtLectureName.isPassword = false;
            this.txtLectureName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLectureName.LineIdleColor = System.Drawing.Color.Green;
            this.txtLectureName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLectureName.LineThickness = 3;
            this.txtLectureName.Location = new System.Drawing.Point(368, 151);
            this.txtLectureName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLectureName.Name = "txtLectureName";
            this.txtLectureName.Size = new System.Drawing.Size(379, 33);
            this.txtLectureName.TabIndex = 51;
            this.txtLectureName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLectureID
            // 
            this.txtLectureID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLectureID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLectureID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLectureID.HintForeColor = System.Drawing.Color.Empty;
            this.txtLectureID.HintText = "";
            this.txtLectureID.isPassword = false;
            this.txtLectureID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtLectureID.LineIdleColor = System.Drawing.Color.Green;
            this.txtLectureID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtLectureID.LineThickness = 3;
            this.txtLectureID.Location = new System.Drawing.Point(368, 95);
            this.txtLectureID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLectureID.Name = "txtLectureID";
            this.txtLectureID.Size = new System.Drawing.Size(379, 33);
            this.txtLectureID.TabIndex = 50;
            this.txtLectureID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDepartmentID
            // 
            this.lblDepartmentID.AutoSize = true;
            this.lblDepartmentID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentID.Location = new System.Drawing.Point(184, 299);
            this.lblDepartmentID.Name = "lblDepartmentID";
            this.lblDepartmentID.Size = new System.Drawing.Size(168, 27);
            this.lblDepartmentID.TabIndex = 49;
            this.lblDepartmentID.Text = "Department ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(184, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 27);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Email";
            // 
            // lblLec_Name
            // 
            this.lblLec_Name.AutoSize = true;
            this.lblLec_Name.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLec_Name.Location = new System.Drawing.Point(184, 151);
            this.lblLec_Name.Name = "lblLec_Name";
            this.lblLec_Name.Size = new System.Drawing.Size(158, 27);
            this.lblLec_Name.TabIndex = 47;
            this.lblLec_Name.Text = "Lecture Name";
            // 
            // lblLectureID
            // 
            this.lblLectureID.AutoSize = true;
            this.lblLectureID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureID.Location = new System.Drawing.Point(184, 95);
            this.lblLectureID.Name = "lblLectureID";
            this.lblLectureID.Size = new System.Drawing.Size(122, 27);
            this.lblLectureID.TabIndex = 46;
            this.lblLectureID.Text = "Lecture ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(656, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectures";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Green;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(368, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(379, 33);
            this.txtEmail.TabIndex = 52;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1662, 25);
            this.guna2Panel2.TabIndex = 44;
            // 
            // cmbB_ID
            // 
            this.cmbB_ID.BackColor = System.Drawing.Color.Transparent;
            this.cmbB_ID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbB_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB_ID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbB_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbB_ID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbB_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbB_ID.ItemHeight = 30;
            this.cmbB_ID.Items.AddRange(new object[] {
            "c001"});
            this.cmbB_ID.Location = new System.Drawing.Point(368, 365);
            this.cmbB_ID.Name = "cmbB_ID";
            this.cmbB_ID.Size = new System.Drawing.Size(140, 36);
            this.cmbB_ID.TabIndex = 57;
            // 
            // lblB_ID
            // 
            this.lblB_ID.AutoSize = true;
            this.lblB_ID.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_ID.Location = new System.Drawing.Point(184, 365);
            this.lblB_ID.Name = "lblB_ID";
            this.lblB_ID.Size = new System.Drawing.Size(118, 27);
            this.lblB_ID.TabIndex = 56;
            this.lblB_ID.Text = "Branch ID";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel3.Location = new System.Drawing.Point(153, 25);
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
            this.btnExit.Location = new System.Drawing.Point(18, 432);
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
            this.btnDel.Location = new System.Drawing.Point(18, 219);
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
            this.btnBack.Location = new System.Drawing.Point(18, 362);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 45);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1662, 563);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbB_ID);
            this.Controls.Add(this.lblB_ID);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.DGTLectureList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDep_ID);
            this.Controls.Add(this.txtLectureName);
            this.Controls.Add(this.txtLectureID);
            this.Controls.Add(this.lblDepartmentID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLec_Name);
            this.Controls.Add(this.lblLectureID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecture";
            this.Text = "Lecture";
            this.Load += new System.EventHandler(this.Lecture_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTLectureList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button lblUpdate;
        private Guna.UI2.WinForms.Guna2Button lblClear;
        private Guna.UI2.WinForms.Guna2DataGridView DGTLectureList;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDep_ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLectureName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLectureID;
        private System.Windows.Forms.Label lblDepartmentID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLec_Name;
        private System.Windows.Forms.Label lblLectureID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbB_ID;
        private System.Windows.Forms.Label lblB_ID;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnDel;
    }
}