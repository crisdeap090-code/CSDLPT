namespace QL_CLB_PhanTan
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
            this.tabTruyVan = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnExecute = new System.Windows.Forms.Button();
            this.grpParams = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSinhVien = new System.Windows.Forms.TabPage();
            this.tabDanhsach = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSV_Delete = new System.Windows.Forms.Button();
            this.btnSV_Update = new System.Windows.Forms.Button();
            this.btnSV_Load = new System.Windows.Forms.Button();
            this.btnSV_Add = new System.Windows.Forms.Button();
            this.cboSV_CLB = new System.Windows.Forms.ComboBox();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV1 = new System.Windows.Forms.TextBox();
            this.lblMaCLB = new System.Windows.Forms.Label();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblMaSV1 = new System.Windows.Forms.Label();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGV_Delete = new System.Windows.Forms.Button();
            this.btnGV_Update = new System.Windows.Forms.Button();
            this.btnGV_Load = new System.Windows.Forms.Button();
            this.btnGV_Add = new System.Windows.Forms.Button();
            this.cboGV_CLB = new System.Windows.Forms.ComboBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboDS_Server = new System.Windows.Forms.ComboBox();
            this.btnDS_Load = new System.Windows.Forms.Button();
            this.cboDS_Table = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabTruyVan.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.grpParams.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabDanhsach.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTruyVan
            // 
            this.tabTruyVan.AccessibleName = "";
            this.tabTruyVan.Controls.Add(this.tabPage1);
            this.tabTruyVan.Controls.Add(this.tabSinhVien);
            this.tabTruyVan.Location = new System.Drawing.Point(12, 12);
            this.tabTruyVan.Name = "tabTruyVan";
            this.tabTruyVan.SelectedIndex = 0;
            this.tabTruyVan.Size = new System.Drawing.Size(899, 675);
            this.tabTruyVan.TabIndex = 0;
            this.tabTruyVan.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvResult);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.grpParams);
            this.tabPage1.Controls.Add(this.cboQuery);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Truy vấn dữ liệu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(26, 260);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 62;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(841, 366);
            this.dgvResult.TabIndex = 6;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(565, 197);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(84, 38);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Kết quả ";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // grpParams
            // 
            this.grpParams.Controls.Add(this.txtMaSV);
            this.grpParams.Controls.Add(this.txtMaLop);
            this.grpParams.Controls.Add(this.txtMaGV);
            this.grpParams.Controls.Add(this.lblMaSV);
            this.grpParams.Controls.Add(this.lblMaLop);
            this.grpParams.Controls.Add(this.lblMaGV);
            this.grpParams.Location = new System.Drawing.Point(26, 82);
            this.grpParams.Name = "grpParams";
            this.grpParams.Size = new System.Drawing.Size(481, 153);
            this.grpParams.TabIndex = 4;
            this.grpParams.TabStop = false;
            this.grpParams.Text = "Tham số ";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(88, 107);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(352, 26);
            this.txtMaSV.TabIndex = 7;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(88, 70);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(352, 26);
            this.txtMaLop.TabIndex = 6;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(88, 34);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(352, 26);
            this.txtMaGV.TabIndex = 5;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(16, 107);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(61, 20);
            this.lblMaSV.TabIndex = 4;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(16, 70);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(66, 20);
            this.lblMaLop.TabIndex = 3;
            this.lblMaLop.Text = "Mã Lớp:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(16, 34);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(63, 20);
            this.lblMaGV.TabIndex = 2;
            this.lblMaGV.Text = "Mã GV:";
            // 
            // cboQuery
            // 
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Location = new System.Drawing.Point(114, 33);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(393, 28);
            this.cboQuery.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Câu hỏi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn câu hỏi và tham số ";
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.tabDanhsach);
            this.tabSinhVien.Location = new System.Drawing.Point(4, 29);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabSinhVien.Size = new System.Drawing.Size(891, 642);
            this.tabSinhVien.TabIndex = 1;
            this.tabSinhVien.Text = "Quản lý dữ liệu";
            this.tabSinhVien.UseVisualStyleBackColor = true;
            // 
            // tabDanhsach
            // 
            this.tabDanhsach.Controls.Add(this.tabPage2);
            this.tabDanhsach.Controls.Add(this.tabPage3);
            this.tabDanhsach.Controls.Add(this.tabPage4);
            this.tabDanhsach.Location = new System.Drawing.Point(6, 15);
            this.tabDanhsach.Name = "tabDanhsach";
            this.tabDanhsach.SelectedIndex = 0;
            this.tabDanhsach.Size = new System.Drawing.Size(889, 631);
            this.tabDanhsach.TabIndex = 0;
            this.tabDanhsach.SelectedIndexChanged += new System.EventHandler(this.tabDanhsach_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dgvSV);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 598);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "SinhVien";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSV_Delete);
            this.groupBox1.Controls.Add(this.btnSV_Update);
            this.groupBox1.Controls.Add(this.btnSV_Load);
            this.groupBox1.Controls.Add(this.btnSV_Add);
            this.groupBox1.Controls.Add(this.cboSV_CLB);
            this.groupBox1.Controls.Add(this.txtHoTenSV);
            this.groupBox1.Controls.Add(this.txtMaSV1);
            this.groupBox1.Controls.Add(this.lblMaCLB);
            this.groupBox1.Controls.Add(this.lblHoTenSV);
            this.groupBox1.Controls.Add(this.lblMaSV1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dữ liệu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSV_Delete
            // 
            this.btnSV_Delete.Location = new System.Drawing.Point(631, 114);
            this.btnSV_Delete.Name = "btnSV_Delete";
            this.btnSV_Delete.Size = new System.Drawing.Size(158, 34);
            this.btnSV_Delete.TabIndex = 9;
            this.btnSV_Delete.Text = "Xóa dữ liệu";
            this.btnSV_Delete.UseVisualStyleBackColor = true;
            this.btnSV_Delete.Click += new System.EventHandler(this.btnSV_Delete_Click_1);
            // 
            // btnSV_Update
            // 
            this.btnSV_Update.Location = new System.Drawing.Point(631, 42);
            this.btnSV_Update.Name = "btnSV_Update";
            this.btnSV_Update.Size = new System.Drawing.Size(158, 36);
            this.btnSV_Update.TabIndex = 8;
            this.btnSV_Update.Text = "Sửa dữ liệu ";
            this.btnSV_Update.UseVisualStyleBackColor = true;
            this.btnSV_Update.Click += new System.EventHandler(this.btnSV_Update_Click_1);
            // 
            // btnSV_Load
            // 
            this.btnSV_Load.Location = new System.Drawing.Point(452, 114);
            this.btnSV_Load.Name = "btnSV_Load";
            this.btnSV_Load.Size = new System.Drawing.Size(142, 34);
            this.btnSV_Load.TabIndex = 7;
            this.btnSV_Load.Text = "Load dữ liệu";
            this.btnSV_Load.UseVisualStyleBackColor = true;
            this.btnSV_Load.Click += new System.EventHandler(this.btnSV_Load_Click_1);
            // 
            // btnSV_Add
            // 
            this.btnSV_Add.Location = new System.Drawing.Point(452, 42);
            this.btnSV_Add.Name = "btnSV_Add";
            this.btnSV_Add.Size = new System.Drawing.Size(142, 36);
            this.btnSV_Add.TabIndex = 6;
            this.btnSV_Add.Text = "Thêm dữ liệu";
            this.btnSV_Add.UseVisualStyleBackColor = true;
            this.btnSV_Add.Click += new System.EventHandler(this.btnSV_Add_Click_1);
            // 
            // cboSV_CLB
            // 
            this.cboSV_CLB.FormattingEnabled = true;
            this.cboSV_CLB.Location = new System.Drawing.Point(127, 143);
            this.cboSV_CLB.Name = "cboSV_CLB";
            this.cboSV_CLB.Size = new System.Drawing.Size(286, 28);
            this.cboSV_CLB.TabIndex = 5;
            this.cboSV_CLB.SelectedIndexChanged += new System.EventHandler(this.cboSV_CLB_SelectedIndexChanged);
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(127, 90);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(286, 26);
            this.txtHoTenSV.TabIndex = 4;
            this.txtHoTenSV.TextChanged += new System.EventHandler(this.txtHoTenSV_TextChanged);
            // 
            // txtMaSV1
            // 
            this.txtMaSV1.Location = new System.Drawing.Point(127, 39);
            this.txtMaSV1.Name = "txtMaSV1";
            this.txtMaSV1.Size = new System.Drawing.Size(286, 26);
            this.txtMaSV1.TabIndex = 3;
            this.txtMaSV1.TextChanged += new System.EventHandler(this.txtMaSV1_TextChanged);
            // 
            // lblMaCLB
            // 
            this.lblMaCLB.AutoSize = true;
            this.lblMaCLB.Location = new System.Drawing.Point(26, 143);
            this.lblMaCLB.Name = "lblMaCLB";
            this.lblMaCLB.Size = new System.Drawing.Size(70, 20);
            this.lblMaCLB.TabIndex = 2;
            this.lblMaCLB.Text = "Mã CLB:";
            this.lblMaCLB.Click += new System.EventHandler(this.lblMaCLB_Click);
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(26, 90);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(87, 20);
            this.lblHoTenSV.TabIndex = 1;
            this.lblHoTenSV.Text = "Họ tên SV:";
            this.lblHoTenSV.Click += new System.EventHandler(this.lblHoTenSV_Click);
            // 
            // lblMaSV1
            // 
            this.lblMaSV1.AutoSize = true;
            this.lblMaSV1.Location = new System.Drawing.Point(26, 39);
            this.lblMaSV1.Name = "lblMaSV1";
            this.lblMaSV1.Size = new System.Drawing.Size(61, 20);
            this.lblMaSV1.TabIndex = 0;
            this.lblMaSV1.Text = "Mã SV:";
            this.lblMaSV1.Click += new System.EventHandler(this.lblMaSV1_Click);
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(6, 222);
            this.dgvSV.MultiSelect = false;
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.ReadOnly = true;
            this.dgvSV.RowHeadersWidth = 62;
            this.dgvSV.RowTemplate.Height = 28;
            this.dgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSV.Size = new System.Drawing.Size(869, 370);
            this.dgvSV.TabIndex = 0;
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvGV);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(881, 598);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "GiangVien";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvGV
            // 
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Location = new System.Drawing.Point(6, 222);
            this.dgvGV.MultiSelect = false;
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.ReadOnly = true;
            this.dgvGV.RowHeadersWidth = 62;
            this.dgvGV.RowTemplate.Height = 28;
            this.dgvGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGV.Size = new System.Drawing.Size(869, 370);
            this.dgvGV.TabIndex = 4;
            this.dgvGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGV_Delete);
            this.groupBox2.Controls.Add(this.btnGV_Update);
            this.groupBox2.Controls.Add(this.btnGV_Load);
            this.groupBox2.Controls.Add(this.btnGV_Add);
            this.groupBox2.Controls.Add(this.cboGV_CLB);
            this.groupBox2.Controls.Add(this.txtHoTenGV);
            this.groupBox2.Controls.Add(this.txtMaGV1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 210);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu";
            // 
            // btnGV_Delete
            // 
            this.btnGV_Delete.Location = new System.Drawing.Point(631, 114);
            this.btnGV_Delete.Name = "btnGV_Delete";
            this.btnGV_Delete.Size = new System.Drawing.Size(158, 34);
            this.btnGV_Delete.TabIndex = 9;
            this.btnGV_Delete.Text = "Xóa dữ liệu";
            this.btnGV_Delete.UseVisualStyleBackColor = true;
            // 
            // btnGV_Update
            // 
            this.btnGV_Update.Location = new System.Drawing.Point(631, 42);
            this.btnGV_Update.Name = "btnGV_Update";
            this.btnGV_Update.Size = new System.Drawing.Size(158, 36);
            this.btnGV_Update.TabIndex = 8;
            this.btnGV_Update.Text = "Sửa dữ liệu ";
            this.btnGV_Update.UseVisualStyleBackColor = true;
            // 
            // btnGV_Load
            // 
            this.btnGV_Load.Location = new System.Drawing.Point(452, 114);
            this.btnGV_Load.Name = "btnGV_Load";
            this.btnGV_Load.Size = new System.Drawing.Size(142, 34);
            this.btnGV_Load.TabIndex = 7;
            this.btnGV_Load.Text = "Load dữ liệu";
            this.btnGV_Load.UseVisualStyleBackColor = true;
            this.btnGV_Load.Click += new System.EventHandler(this.btnGV_Load_Click);
            // 
            // btnGV_Add
            // 
            this.btnGV_Add.Location = new System.Drawing.Point(452, 42);
            this.btnGV_Add.Name = "btnGV_Add";
            this.btnGV_Add.Size = new System.Drawing.Size(142, 36);
            this.btnGV_Add.TabIndex = 6;
            this.btnGV_Add.Text = "Thêm dữ liệu";
            this.btnGV_Add.UseVisualStyleBackColor = true;
            // 
            // cboGV_CLB
            // 
            this.cboGV_CLB.FormattingEnabled = true;
            this.cboGV_CLB.Location = new System.Drawing.Point(127, 143);
            this.cboGV_CLB.Name = "cboGV_CLB";
            this.cboGV_CLB.Size = new System.Drawing.Size(286, 28);
            this.cboGV_CLB.TabIndex = 5;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(127, 90);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(286, 26);
            this.txtHoTenGV.TabIndex = 4;
            // 
            // txtMaGV1
            // 
            this.txtMaGV1.Location = new System.Drawing.Point(127, 39);
            this.txtMaGV1.Name = "txtMaGV1";
            this.txtMaGV1.Size = new System.Drawing.Size(286, 26);
            this.txtMaGV1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã CLB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên GV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã GV:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDS);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(881, 598);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Danh sách dữ liệu ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDS
            // 
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(6, 158);
            this.dgvDS.MultiSelect = false;
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.ReadOnly = true;
            this.dgvDS.RowHeadersWidth = 62;
            this.dgvDS.RowTemplate.Height = 28;
            this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDS.Size = new System.Drawing.Size(869, 434);
            this.dgvDS.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboDS_Server);
            this.groupBox3.Controls.Add(this.btnDS_Load);
            this.groupBox3.Controls.Add(this.cboDS_Table);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 146);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin dữ liệu";
            // 
            // cboDS_Server
            // 
            this.cboDS_Server.FormattingEnabled = true;
            this.cboDS_Server.Location = new System.Drawing.Point(126, 39);
            this.cboDS_Server.Name = "cboDS_Server";
            this.cboDS_Server.Size = new System.Drawing.Size(147, 28);
            this.cboDS_Server.TabIndex = 10;
            // 
            // btnDS_Load
            // 
            this.btnDS_Load.Location = new System.Drawing.Point(603, 53);
            this.btnDS_Load.Name = "btnDS_Load";
            this.btnDS_Load.Size = new System.Drawing.Size(193, 43);
            this.btnDS_Load.TabIndex = 7;
            this.btnDS_Load.Text = "Load dữ liệu";
            this.btnDS_Load.UseVisualStyleBackColor = true;
            // 
            // cboDS_Table
            // 
            this.cboDS_Table.FormattingEnabled = true;
            this.cboDS_Table.Location = new System.Drawing.Point(126, 87);
            this.cboDS_Table.Name = "cboDS_Table";
            this.cboDS_Table.Size = new System.Drawing.Size(286, 28);
            this.cboDS_Table.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dữ liệu bảng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "sever:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 699);
            this.Controls.Add(this.tabTruyVan);
            this.Name = "Form1";
            this.Text = "Hệ thống quản trị dữ liệu";
            this.tabTruyVan.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.grpParams.ResumeLayout(false);
            this.grpParams.PerformLayout();
            this.tabSinhVien.ResumeLayout(false);
            this.tabDanhsach.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTruyVan;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSinhVien;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox grpParams;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.TabControl tabDanhsach;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboSV_CLB;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TextBox txtMaSV1;
        private System.Windows.Forms.Label lblMaCLB;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblMaSV1;
        private System.Windows.Forms.Button btnSV_Delete;
        private System.Windows.Forms.Button btnSV_Update;
        private System.Windows.Forms.Button btnSV_Load;
        private System.Windows.Forms.Button btnSV_Add;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGV_Delete;
        private System.Windows.Forms.Button btnGV_Update;
        private System.Windows.Forms.Button btnGV_Load;
        private System.Windows.Forms.Button btnGV_Add;
        private System.Windows.Forms.ComboBox cboGV_CLB;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtMaGV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDS_Load;
        private System.Windows.Forms.ComboBox cboDS_Table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDS_Server;
        private System.Windows.Forms.DataGridView dgvDS;
    }
}

