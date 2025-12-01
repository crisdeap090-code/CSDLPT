using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CLB_PhanTan
{
    public partial class Form1 : Form
    {
        private readonly string _branch;
        private string _origMaSV;
        private string _origMaGV;   // thêm dòng này
        public Form1(string branch)
        {
            cboQuery.SelectedIndex = 0;
            InitializeComponent();
            _branch = branch;
        }
        public Form1()
        {
            InitializeComponent();
            // gắn event Load
            this.Load += Form1_Load;
            LoadCLB_ToCombo();

            // gắn event SelectedIndexChanged cho combobox
            cboQuery.SelectedIndexChanged += cboQuery_SelectedIndexChanged;
            // tab sinh viên
            btnSV_Load.Click += btnSV_Load_Click;
            btnSV_Add.Click += btnSV_Add_Click;
            btnSV_Update.Click += btnSV_Update_Click;
            btnSV_Delete.Click += btnSV_Delete_Click;
            dgvSV.SelectionChanged += dgvSV_SelectionChanged;

            // tab GiangVien
            btnGV_Load.Click += btnGV_Load_Click;
            btnGV_Add.Click += btnGV_Add_Click;
            btnGV_Update.Click += btnGV_Update_Click;
            btnGV_Delete.Click += btnGV_Delete_Click;
            dgvGV.SelectionChanged += dgvGV_SelectionChanged;
            // tab Danh sách dữ liệu
            btnDS_Load.Click += btnDS_Load_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboQuery.Items.Add("Câu 1");
            cboQuery.Items.Add("Câu 2");
            cboQuery.Items.Add("Câu 3");
            cboQuery.Items.Add("Câu 4");
            cboQuery.SelectedIndex = 0;
            UpdateParamControls();
            // tab Danh sách dữ liệu: danh sách bảng
            cboDS_Table.Items.Add("Câu lạc bộ");
            cboDS_Table.Items.Add("Giảng viên");
            cboDS_Table.Items.Add("Sinh viên");
            cboDS_Table.Items.Add("Lớp năng khiếu");
            cboDS_Table.Items.Add("Biên lai");
            cboDS_Table.SelectedIndex = 0;
            // 2 lựa chọn server
            cboDS_Server.Items.Add("Server hiện tại");   // CLB_K2 (hoặc DB fragment đang login)
            cboDS_Server.Items.Add("Server cục bộ");     // DB tổng hợp qua linked server
            cboDS_Server.SelectedIndex = 0;
            // chỉ xem, không sửa trực tiếp trong grid
            dgvDS.ReadOnly = true;
            dgvDS.AllowUserToAddRows = false;
            dgvDS.AllowUserToDeleteRows = false;
        }
        private void cboQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateParamControls();
        }

        private void UpdateParamControls()
        {
            // mặc định ẩn hết
            txtMaGV.Visible = lblMaGV.Visible = false;
            txtMaLop.Visible = lblMaLop.Visible = false;
            txtMaSV.Visible = lblMaSV.Visible = false;

            if (cboQuery.SelectedItem == null) return;
            var q = cboQuery.SelectedItem.ToString();

            if (q == "Câu 1")
            {
                lblMaGV.Visible = txtMaGV.Visible = true;
                txtMaGV.Text = "GV05";
            }
            else if (q == "Câu 2")
            {
                lblMaLop.Visible = txtMaLop.Visible = true;
                lblMaSV.Visible = txtMaSV.Visible = true;
            }
            // Câu 3, Câu 4 không cần tham số
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (cboQuery.SelectedItem == null) return;
            var q = cboQuery.SelectedItem.ToString();

            switch (q)
            {
                case "Câu 1":
                    RunCau1();
                    break;
                case "Câu 2":
                    RunCau2();
                    break;
                case "Câu 3":
                    RunCau3();
                    break;
                case "Câu 4":
                    RunCau4();
                    break;
            }
        }
        private void RunCau1()
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("sp_Cau1", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", txtMaGV.Text.Trim());

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvResult.DataSource = dt;
            }
        }

        private void RunCau2()
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("sp_Cau2", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@malop", txtMaLop.Text.Trim());
                cmd.Parameters.AddWithValue("@masv", txtMaSV.Text.Trim());

                var dt = new DataTable();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvResult.DataSource = dt;
            }
        }

        private void RunCau3()
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("sp_Cau3", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                var dt = new DataTable();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvResult.DataSource = dt;
            }
        }

        private void RunCau4()
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("sp_Cau4", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Đã cập nhật câu lạc bộ theo Câu 4.");
            dgvResult.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadCLB_ToCombo()
        {
            using (var conn = Db.GetConnection())
            using (var da = new SqlDataAdapter(
                "SELECT maclb, tenclb FROM caulacbo", conn))   // hoặc v_caulacbo
            {
                var dt = new DataTable();
                da.Fill(dt);

                cboSV_CLB.DataSource = dt;          // đưa dữ liệu vào combo
                cboSV_CLB.DisplayMember = "tenclb"; // cột hiển thị
                cboSV_CLB.ValueMember = "maclb";    // cột giá trị (lấy để lưu DB)
                cboSV_CLB.DropDownStyle = ComboBoxStyle.DropDownList; // không cho gõ tay
            }
        }
        private void dgvSV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSV.CurrentRow == null) return;

            var masv = dgvSV.CurrentRow.Cells["masv"].Value?.ToString();
            _origMaSV = masv;                         // lưu mã gốc

            txtMaSV1.Text = masv;
            txtHoTenSV.Text = dgvSV.CurrentRow.Cells["hotensv"].Value?.ToString();

            var maclb = dgvSV.CurrentRow.Cells["maclb"].Value?.ToString();
            if (!string.IsNullOrEmpty(maclb))
                cboSV_CLB.SelectedValue = maclb;
        }
        private void btnSV_Load_Click(object sender, EventArgs e)
        {
            LoadCLB_ToCombo();
            LoadSinhVien();
        }
        private void LoadSinhVien()
        {
            using (var conn = Db.GetConnection())
            using (var da = new SqlDataAdapter(
                "SELECT masv, hotensv, maclb FROM sinhvien", conn)) // hoặc v_sinhvien
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvSV.DataSource = dt;
            }
        }
        private void btnSV_Add_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SV_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masv", txtMaSV1.Text.Trim());
                cmd.Parameters.AddWithValue("@hoten", txtHoTenSV.Text.Trim());
                cmd.Parameters.AddWithValue("@maclb", cboSV_CLB.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadSinhVien();
                }
                catch (SqlException ex)
                {
                    // bắt thông báo RAISERROR ở proc
                    if (ex.Message.Contains("trùng khóa chính toàn cục"))
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại, trùng khóa chính toàn cục.");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
            }
        }
        private void btnSV_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_origMaSV)) return;

            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SV_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@oldmasv", _origMaSV);                  // mã cũ
                cmd.Parameters.AddWithValue("@newmasv", txtMaSV1.Text.Trim());       // mã mới (có thể sửa)
                cmd.Parameters.AddWithValue("@hoten", txtHoTenSV.Text.Trim());
                cmd.Parameters.AddWithValue("@maclb", cboSV_CLB.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadSinhVien();
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("trùng khóa chính toàn cục"))
                        MessageBox.Show("Mã sinh viên đã tồn tại (trùng khóa chính toàn cục).");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
        private void btnSV_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV1.Text)) return;

            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_SV_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@masv", txtMaSV1.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadSinhVien(); // chỉ reload từ bảng local
            }
        }

        private void tabDanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaSV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSV_CLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMaCLB_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTenSV_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSV1_Click(object sender, EventArgs e)
        {

        }

        private void btnSV_Add_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSV_Load_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSV_Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSV_Update_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnGV_Load_Click(object sender, EventArgs e)
        {
            LoadCLB_ForGV();
            LoadGiangVien();
        }
        private void LoadGiangVien()
        {
            using (var conn = Db.GetConnection())
            using (var da = new SqlDataAdapter(
                // nếu dùng view v_giangvien thì đổi lại
                "SELECT MaGV, HoTenGV, MaCLB FROM GiangVien", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvGV.DataSource = dt;
            }
        }
        private void LoadCLB_ForGV()
        {
            using (var conn = Db.GetConnection())
            using (var da = new SqlDataAdapter(
                "SELECT MaCLB, TenCLB FROM CauLacBo", conn))   // đúng tên bảng/view CLB
            {
                var dt = new DataTable();
                da.Fill(dt);

                cboGV_CLB.DataSource = dt;
                cboGV_CLB.DisplayMember = "TenCLB";
                cboGV_CLB.ValueMember = "MaCLB";
                cboGV_CLB.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGV.CurrentRow == null) return;

            var magv = dgvGV.CurrentRow.Cells["MaGV"].Value?.ToString();
            _origMaGV = magv;                       // lưu mã gốc

            txtMaGV1.Text = magv;
            txtHoTenGV.Text = dgvGV.CurrentRow.Cells["HoTenGV"].Value?.ToString();

            var maclb = dgvGV.CurrentRow.Cells["MaCLB"].Value?.ToString();
            if (!string.IsNullOrEmpty(maclb))
                cboGV_CLB.SelectedValue = maclb;
        }
        
        private void btnGV_Add_Click(object sender, EventArgs e)
        {
            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_GV_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", txtMaGV1.Text.Trim());
                cmd.Parameters.AddWithValue("@hoten", txtHoTenGV.Text.Trim());
                cmd.Parameters.AddWithValue("@maclb", cboGV_CLB.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadGiangVien();
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("đã tồn tại"))
                        MessageBox.Show("Mã giảng viên đã tồn tại.");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }
        private void btnGV_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_origMaGV)) return;

            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_GV_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@oldmagv", _origMaGV);                  // mã cũ
                cmd.Parameters.AddWithValue("@newmagv", txtMaGV1.Text.Trim());       // mã mới
                cmd.Parameters.AddWithValue("@hoten", txtHoTenGV.Text.Trim());
                cmd.Parameters.AddWithValue("@maclb", cboGV_CLB.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadGiangVien();
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("trùng khóa chính toàn cục") ||
                        ex.Message.Contains("đã tồn tại"))
                    {
                        MessageBox.Show("Mã giảng viên đã tồn tại (trùng khóa chính toàn cục).");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
            }
        }
        private void btnGV_Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGV1.Text)) return;

            using (var conn = Db.GetConnection())
            using (var cmd = new SqlCommand("dbo.sp_GV_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@magv", txtMaGV1.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadGiangVien(); // reload từ bảng GiangVien local
            }
        }
        private void dgvGV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGV.CurrentRow == null) return;

            txtMaGV1.Text = dgvGV.CurrentRow.Cells["MaGV"].Value?.ToString();
            txtHoTenGV.Text = dgvGV.CurrentRow.Cells["HoTenGV"].Value?.ToString();

            var maclb = dgvGV.CurrentRow.Cells["MaCLB"].Value?.ToString();
            if (!string.IsNullOrEmpty(maclb))
                cboGV_CLB.SelectedValue = maclb;
        }
        private string GetDS_TableName(string entity, string serverCode)
        {
            // bảng local trong DB phân mảnh hiện tại (ví dụ CLB_K2)
            string localTable;
            switch (entity)
            {
                case "CLB": localTable = "CauLacBo"; break;
                case "GV": localTable = "GiangVien"; break;
                case "SV": localTable = "SinhVien"; break;
                case "LOP": localTable = "LopNangKhieu"; break;
                case "BL": localTable = "BienLai"; break;
                default: throw new InvalidOperationException("entity không hợp lệ");
            }

            // xem dữ liệu trên server hiện tại
            if (cboDS_Server.SelectedItem.ToString() == "Server hiện tại")
                return localTable;

            // xem dữ liệu trên server cục bộ/tổng hợp qua linked server
            // TODO: đổi LINK_TONGHOP, QL_CLB_TONGHOP theo đúng cấu hình
            string linkName = "K1_LINK";
            string dbName = "CLB";

            // cú pháp 4 phần: [linked].[db].dbo.Table
            return $"[{linkName}].[{dbName}].dbo.{localTable}";
        }
        private void btnDS_Load_Click(object sender, EventArgs e)
        {
            if (cboDS_Table.SelectedItem == null || cboDS_Server.SelectedItem == null) return;

            var tenBang = cboDS_Table.SelectedItem.ToString();
            var serverName = cboDS_Server.SelectedItem.ToString();

            string entity;
            string selectCols;

            switch (tenBang)
            {
                case "Câu lạc bộ":
                    entity = "CLB";
                    selectCols = "MaCLB, TenCLB, TenKhoa";
                    break;

                case "Giảng viên":
                    entity = "GV";
                    selectCols = "MaGV, HoTenGV, MaCLB";
                    break;

                case "Sinh viên":
                    entity = "SV";
                    selectCols = "MaSV, HoTenSV, MaCLB";
                    break;

                case "Lớp năng khiếu":
                    entity = "LOP";
                    selectCols = "MaLop, NgayMo, MaGV, HocPhi";
                    break;

                case "Biên lai":
                    entity = "BL";
                    selectCols = "SoBL, Thang, Nam, MaLop, MaSV, SoTien";
                    break;

                default:
                    return;
            }

            // tên bảng: local hoặc qua linked server
            string tableName = GetDS_TableName(entity, serverName);

            string sql = $"SELECT {selectCols} FROM {tableName}";

            using (var conn = Db.GetConnection()) // chỉ 1 connection tới server fragment hiện tại
            using (var da = new SqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvDS.DataSource = dt;
            }
        }

    }
}

 
