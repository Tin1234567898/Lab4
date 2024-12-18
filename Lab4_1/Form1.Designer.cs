namespace Lab4_1
{
    partial class frmStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thông tin Sinh Viên";
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.rdFemale);
            this.grbTTSV.Controls.Add(this.rdMale);
            this.grbTTSV.Controls.Add(this.btnDelete);
            this.grbTTSV.Controls.Add(this.btnEdit);
            this.grbTTSV.Controls.Add(this.btnAdd);
            this.grbTTSV.Controls.Add(this.cmbFaculty);
            this.grbTTSV.Controls.Add(this.txtScore);
            this.grbTTSV.Controls.Add(this.txtName);
            this.grbTTSV.Controls.Add(this.txtID);
            this.grbTTSV.Controls.Add(this.lblScore);
            this.grbTTSV.Controls.Add(this.lblGender);
            this.grbTTSV.Controls.Add(this.lblFaculty);
            this.grbTTSV.Controls.Add(this.lblName);
            this.grbTTSV.Controls.Add(this.lblID);
            this.grbTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTSV.Location = new System.Drawing.Point(18, 146);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Size = new System.Drawing.Size(309, 241);
            this.grbTTSV.TabIndex = 1;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(205, 92);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(41, 17);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(125, 92);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(50, 17);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(118, 192);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(125, 131);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(149, 21);
            this.cmbFaculty.TabIndex = 2;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(125, 160);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(132, 20);
            this.txtScore.TabIndex = 1;
            this.txtScore.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(34, 164);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Điểm TB";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(34, 96);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Giới Tính";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(34, 130);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(36, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Khoa";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ Tên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã Số SV";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnName,
            this.clnGender,
            this.clnFaculty,
            this.clnScore});
            this.dgvStudent.Location = new System.Drawing.Point(369, 146);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(572, 241);
            this.dgvStudent.TabIndex = 2;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // clnID
            // 
            this.clnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnID.HeaderText = "Mã Số SV";
            this.clnID.Name = "clnID";
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.HeaderText = "Họ Tên";
            this.clnName.Name = "clnName";
            // 
            // clnGender
            // 
            this.clnGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnGender.HeaderText = "Giới Tính";
            this.clnGender.Name = "clnGender";
            // 
            // clnFaculty
            // 
            this.clnFaculty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFaculty.HeaderText = "Tên Khoa";
            this.clnFaculty.Name = "clnFaculty";
            // 
            // clnScore
            // 
            this.clnScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnScore.HeaderText = "Điểm TB";
            this.clnScore.Name = "clnScore";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(844, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyKhoa,
            this.tìmKiếmToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // menuQuanLyKhoa
            // 
            this.menuQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("menuQuanLyKhoa.Image")));
            this.menuQuanLyKhoa.Name = "menuQuanLyKhoa";
            this.menuQuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuQuanLyKhoa.Size = new System.Drawing.Size(208, 26);
            this.menuQuanLyKhoa.Text = "Quản lý khoa";
            this.menuQuanLyKhoa.Click += new System.EventHandler(this.menuQuanLyKhoa_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tìmKiếmToolStripMenuItem.Image")));
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.grbTTSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStudentManagement";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFaculty;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

