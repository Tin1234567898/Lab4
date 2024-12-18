namespace Lab4_1
{
    partial class frmQuanLyKhoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.lblTotalProfessor = new System.Windows.Forms.Label();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.lblFacultyID = new System.Windows.Forms.Label();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.clnFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalProfessor);
            this.groupBox1.Controls.Add(this.txtFacultyName);
            this.groupBox1.Controls.Add(this.txtFacultyID);
            this.groupBox1.Controls.Add(this.lblTotalProfessor);
            this.groupBox1.Controls.Add(this.lblFacultyName);
            this.groupBox1.Controls.Add(this.lblFacultyID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(14, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa ";
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProfessor.Location = new System.Drawing.Point(113, 153);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(176, 26);
            this.txtTotalProfessor.TabIndex = 1;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyName.Location = new System.Drawing.Point(113, 91);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(197, 26);
            this.txtFacultyName.TabIndex = 1;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyID.Location = new System.Drawing.Point(113, 36);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(176, 26);
            this.txtFacultyID.TabIndex = 1;
            // 
            // lblTotalProfessor
            // 
            this.lblTotalProfessor.AutoSize = true;
            this.lblTotalProfessor.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProfessor.Location = new System.Drawing.Point(3, 156);
            this.lblTotalProfessor.Name = "lblTotalProfessor";
            this.lblTotalProfessor.Size = new System.Drawing.Size(104, 20);
            this.lblTotalProfessor.TabIndex = 0;
            this.lblTotalProfessor.Text = "Tổng số GS";
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.ForeColor = System.Drawing.Color.Black;
            this.lblFacultyName.Location = new System.Drawing.Point(6, 96);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(85, 20);
            this.lblFacultyName.TabIndex = 0;
            this.lblFacultyName.Text = "Tên Khoa";
            // 
            // lblFacultyID
            // 
            this.lblFacultyID.AutoSize = true;
            this.lblFacultyID.ForeColor = System.Drawing.Color.Black;
            this.lblFacultyID.Location = new System.Drawing.Point(6, 37);
            this.lblFacultyID.Name = "lblFacultyID";
            this.lblFacultyID.Size = new System.Drawing.Size(79, 20);
            this.lblFacultyID.TabIndex = 0;
            this.lblFacultyID.Text = "Mã Khoa";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnFacultyID,
            this.clnFacultyName,
            this.clnTotalProfessor});
            this.dgvFaculty.Location = new System.Drawing.Point(377, 135);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.Size = new System.Drawing.Size(409, 193);
            this.dgvFaculty.TabIndex = 1;
            this.dgvFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellClick);
            this.dgvFaculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellContentClick);
            // 
            // clnFacultyID
            // 
            this.clnFacultyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFacultyID.HeaderText = "Mã Khoa";
            this.clnFacultyID.Name = "clnFacultyID";
            // 
            // clnFacultyName
            // 
            this.clnFacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnFacultyName.HeaderText = "Tên Khoa";
            this.clnFacultyName.Name = "clnFacultyName";
            // 
            // clnTotalProfessor
            // 
            this.clnTotalProfessor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTotalProfessor.HeaderText = "Tổng số GS";
            this.clnTotalProfessor.Name = "clnTotalProfessor";
            // 
            // btnAddnEdit
            // 
            this.btnAddnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnEdit.Location = new System.Drawing.Point(97, 346);
            this.btnAddnEdit.Name = "btnAddnEdit";
            this.btnAddnEdit.Size = new System.Drawing.Size(107, 40);
            this.btnAddnEdit.TabIndex = 2;
            this.btnAddnEdit.Text = "Thêm/ Sửa";
            this.btnAddnEdit.UseVisualStyleBackColor = true;
            this.btnAddnEdit.Click += new System.EventHandler(this.btnAddnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(219, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(681, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddnEdit);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyKhoa";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.frmQuanLyKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalProfessor;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblFacultyID;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalProfessor;
        private System.Windows.Forms.Button btnAddnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}