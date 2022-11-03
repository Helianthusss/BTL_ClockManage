namespace Vd_Bt
{
    partial class frmQLSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.txt_DiemTB = new System.Windows.Forms.TextBox();
            this.lbl_DiemTB = new System.Windows.Forms.Label();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_MaSoSV = new System.Windows.Forms.TextBox();
            this.lbl_MaSoSV = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falcultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.cb_Khoa);
            this.groupBox1.Controls.Add(this.txt_DiemTB);
            this.groupBox1.Controls.Add(this.lbl_DiemTB);
            this.groupBox1.Controls.Add(this.lbl_Khoa);
            this.groupBox1.Controls.Add(this.txt_HoTen);
            this.groupBox1.Controls.Add(this.lbl_HoTen);
            this.groupBox1.Controls.Add(this.txt_MaSoSV);
            this.groupBox1.Controls.Add(this.lbl_MaSoSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(297, 277);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 37);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(167, 277);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(103, 37);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(35, 277);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 37);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Items.AddRange(new object[] {
            ""});
            this.cb_Khoa.Location = new System.Drawing.Point(138, 152);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(275, 33);
            this.cb_Khoa.TabIndex = 8;
            this.cb_Khoa.Items.Add("");
            // 
            // txt_DiemTB
            // 
            this.txt_DiemTB.Location = new System.Drawing.Point(138, 202);
            this.txt_DiemTB.Name = "txt_DiemTB";
            this.txt_DiemTB.Size = new System.Drawing.Size(275, 30);
            this.txt_DiemTB.TabIndex = 7;
            // 
            // lbl_DiemTB
            // 
            this.lbl_DiemTB.AutoSize = true;
            this.lbl_DiemTB.Location = new System.Drawing.Point(15, 202);
            this.lbl_DiemTB.Name = "lbl_DiemTB";
            this.lbl_DiemTB.Size = new System.Drawing.Size(94, 25);
            this.lbl_DiemTB.TabIndex = 6;
            this.lbl_DiemTB.Text = "Điểm TB:";
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Location = new System.Drawing.Point(15, 152);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(65, 25);
            this.lbl_Khoa.TabIndex = 4;
            this.lbl_Khoa.Text = "Khoa:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(138, 102);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(275, 30);
            this.txt_HoTen.TabIndex = 3;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(15, 102);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(75, 25);
            this.lbl_HoTen.TabIndex = 2;
            this.lbl_HoTen.Text = "Họ tên:";
            // 
            // txt_MaSoSV
            // 
            this.txt_MaSoSV.Location = new System.Drawing.Point(138, 52);
            this.txt_MaSoSV.Name = "txt_MaSoSV";
            this.txt_MaSoSV.Size = new System.Drawing.Size(275, 30);
            this.txt_MaSoSV.TabIndex = 1;
            // 
            // lbl_MaSoSV
            // 
            this.lbl_MaSoSV.AutoSize = true;
            this.lbl_MaSoSV.Location = new System.Drawing.Point(15, 52);
            this.lbl_MaSoSV.Name = "lbl_MaSoSV";
            this.lbl_MaSoSV.Size = new System.Drawing.Size(105, 25);
            this.lbl_MaSoSV.TabIndex = 0;
            this.lbl_MaSoSV.Text = "Mã số SV:";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.falcultyDataGridViewTextBoxColumn});
            this.dgvSinhVien.DataSource = this.studentBindingSource;
            this.dgvSinhVien.Location = new System.Drawing.Point(467, 23);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(435, 565);
            this.dgvSinhVien.TabIndex = 1;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AverageScore";
            this.dataGridViewTextBoxColumn3.HeaderText = "AverageScore";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FacultyID";
            this.dataGridViewTextBoxColumn4.HeaderText = "FacultyID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // falcultyDataGridViewTextBoxColumn
            // 
            this.falcultyDataGridViewTextBoxColumn.DataPropertyName = "Falculty";
            this.falcultyDataGridViewTextBoxColumn.HeaderText = "Falculty";
            this.falcultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.falcultyDataGridViewTextBoxColumn.Name = "falcultyDataGridViewTextBoxColumn";
            this.falcultyDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Vd_Bt.Student);
            // 
            // frmQLSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLSinhVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQLSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.TextBox txt_DiemTB;
        private System.Windows.Forms.Label lbl_DiemTB;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_MaSoSV;
        private System.Windows.Forms.Label lbl_MaSoSV;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn falcultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}

