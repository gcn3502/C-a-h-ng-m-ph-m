using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLMP.Class;

namespace QLMP.Forms
{
    public partial class TimHDNhap : Form
    {
        public TimHDNhap()
        {
            InitializeComponent();
        }

        DataTable tblHDN;
        private void TimHDNhap_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgridtimkiem.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtsohd.Focus();

        }

        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            string sql;
            if ((txtsohd.Text == "") && (txtngay.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") &&
               (txtmanhanvien.Text == "") && (txtncc.Text == "") &&
               (txttongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM HDNhap WHERE 1=1";
            if (txtsohd.Text != "")
                sql = sql + " AND SoHDN Like N'%" + txtsohd.Text + "%'";
            if (txtngay.Text != "")
                sql = sql + " AND DAY(NgayNhap) =" + txtngay.Text;
            if (txtthang.Text != "")
                sql = sql + " AND MONTH(NgayNhap) =" + txtthang.Text;
            if (txtnam.Text != "")
                sql = sql + " AND YEAR(NgayNhap) =" + txtnam.Text;
            if (txtmanhanvien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtmanhanvien.Text + "%'";
            if (txtncc.Text != "")
                sql = sql + " AND MaNCC Like N'%" + txtncc.Text + "%'";
            if (txttongtien.Text != "")
                sql = sql + " AND TongTien <=" + txttongtien.Text;
            tblHDN = function.GetDataToTable(sql);
            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDN.Rows.Count + " Bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgridtimkiem.DataSource = tblHDN;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgridtimkiem.Columns[0].HeaderText = "Số HĐN";
            dgridtimkiem.Columns[1].HeaderText = "Mã nhân viên";
            dgridtimkiem.Columns[2].HeaderText = "Ngày nhập";
            dgridtimkiem.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgridtimkiem.Columns[4].HeaderText = "Tổng tiền";
            dgridtimkiem.Columns[0].Width = 200;
            dgridtimkiem.Columns[1].Width = 150;
            dgridtimkiem.Columns[2].Width = 150;
            dgridtimkiem.Columns[3].Width = 120;
            dgridtimkiem.Columns[4].Width = 150;
            dgridtimkiem.AllowUserToAddRows = false;
            dgridtimkiem.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridtimkiem.DataSource = null;
        }

        private void txttongtien_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgridtimkiem_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết hoá đơn nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgridtimkiem.CurrentRow.Cells["SoHDN"].Value.ToString();
                frmHoaDonNhap frm = new frmHoaDonNhap();
                frm.txthoadon.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
}
