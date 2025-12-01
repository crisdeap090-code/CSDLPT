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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            cboBranch.Items.Add("K1");
            cboBranch.Items.Add("K2");
            cboBranch.Items.Add("K3");
            cboBranch.SelectedIndex = 0;
            CbSever.Items.Add(@"DESKTOP-M01KAUI\CLB_K1");
            CbSever.Items.Add(@"DESKTOP-M01KAUI\CLB_K2");
            CbSever.Items.Add(@"DESKTOP-M01KAUI\CLB_K3");
            CbSever.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbSever_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CbSever.SelectedItem == null)
            {
                MessageBox.Show("Chọn server trước khi đăng nhập");
                return;
            }

            var builder = new SqlConnectionStringBuilder
            {
                DataSource = CbSever.SelectedItem.ToString(),   // lấy server từ combobox
                InitialCatalog ="CLB_"+cboBranch.SelectedItem.ToString(),               // hoặc DB của site đó
                UserID = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                MultipleActiveResultSets = true
            };

            Db.ConnectionString = builder.ConnectionString;

            using (var conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại: " + ex.Message);
                    return;
                }
            }

            var f = new Form1();   // nếu không cần truyền branch nữa
            f.Show();
        }
    }
}
