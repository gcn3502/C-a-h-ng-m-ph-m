using QLMP.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.Forms
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }
        DataTable tblKH;
        private void Khachhang_Load(object sender, EventArgs e)
        {
            function.Connect();
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtmakhach.Enabled = false;
            load_datagridview();
        }
        private void load_datagridview()
        {
            string sql;
            sql = "SELECT MaKH,TenKH,DiaChi,SDT FROM KhachHang";
            tblKH = function.GetDataToTable(sql);
            dgridkhachhang.DataSource = tblKH;
            dgridkhachhang.Columns[0].HeaderText = "Mã khách";
            dgridkhachhang.Columns[1].HeaderText = "Tên khách";
            dgridkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgridkhachhang.Columns[3].HeaderText = "Số điện thoại";
            dgridkhachhang.Columns[0].Width = 100;
            dgridkhachhang.Columns[1].Width = 150;
            dgridkhachhang.Columns[2].Width = 150;
            dgridkhachhang.Columns[3].Width = 150;
            dgridkhachhang.AllowUserToAddRows = false;
            dgridkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgridkhachhang_Click(object sender, EventArgs e)
        {

            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }

            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dũ diệu nào để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtmakhach.Text = dgridkhachhang.CurrentRow.Cells["MaKH"].Value.ToString();
            txttenkhach.Text = dgridkhachhang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtdiachi.Text = dgridkhachhang.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskdienthoai.Text = dgridkhachhang.CurrentRow.Cells["SDT"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }
        private void resetvalues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "INSERT INTO KhachHang(TenKH,DiaChi,SDT) VALUES('null', 'null', -1)";
            function.RunSql(sql);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            resetvalues();
            txtmakhach.Focus();
            string sqlcheck = "SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC ";
            DataTable dt = function.GetDataToTable(sqlcheck);
            string makh = "";

            if (dt != null)
            {
                makh = dt.Rows[0]["MaKH"].ToString();
            }

            txtmakhach.Text = makh;
            txttimkiem.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }

            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }

            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }

            sql = "UPDATE KhachHang SET TenKH = N'" + txttenkhach.Text + "',DiaChi=N'" + txtdiachi.Text + "',SDT = '" + mskdienthoai.Text + "'WHERE MaKH =N'" + txtmakhach.Text + "'";
            function.RunSql(sql);
            load_datagridview();
            resetvalues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }

            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }

            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }

            sql = "UPDATE KhachHang SET TenKH = N'" + txttenkhach.Text + "',DiaChi=N'" + txtdiachi.Text + "',SDT = '" + mskdienthoai.Text + "'WHERE MaKH =N'" + txtmakhach.Text + "'";
            function.RunSql(sql);
            load_datagridview();
            resetvalues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xoá bản ghi này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE KhachHang WHERE MaKH = N'" + txtmakhach.Text + "'";
                function.RunSqlDel(sql);
                load_datagridview();
                resetvalues();
                txttimkiem.Text = "";
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            string maKH = txtmakhach.Text.Trim();
            string sqlcheck = "SELECT TenKH FROM KhachHang WHERE MaKH = N'" + maKH + "' AND TenKH = 'null' ";
            DataTable dt = function.GetDataToTable(sqlcheck);

            if (dt.Rows.Count > 0)
            {
                string sqlDel = "DELETE FROM KhachHang WHERE MaKH = '" + maKH + "'";
                function.RunSqlDel(sqlDel);
            }

            resetvalues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmakhach.Enabled = false;
            txttimkiem.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttimkiem.Text.Trim().Length == 0 || txttimkiem.Text.Trim() == "Nhập từ khoá tìm kiếm...")
            {
                MessageBox.Show("Hãy nhập một từ khoá tìm kiếm!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM KhachHang WHERE 1=1";
            if (!string.IsNullOrEmpty(txttimkiem.Text) && txttimkiem.Text.Trim() != "Nhập từ khoá tìm kiếm...")
            {
                sql += " AND (MaKH LIKE N'%" + txttimkiem.Text.Trim() + "%' OR TenKH LIKE N'%" + txttimkiem.Text.Trim() + "%' OR DiaChi LIKE N'%" + txttimkiem.Text.Trim() + "%' OR SDT LIKE N'%" + txttimkiem.Text.Trim() + "%')";
            }

            tblKH = function.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblKH.Rows.Count + " Bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgridkhachhang.DataSource = tblKH;
            resetvalues();
            txttimkiem.Enabled = true;
            dgridkhachhang.Columns[0].Width = 100;
            dgridkhachhang.Columns[1].Width = 150;
            dgridkhachhang.Columns[2].Width = 150;
            dgridkhachhang.Columns[3].Width = 150;

        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khoá tìm kiếm...")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Nhập từ khoá tìm kiếm...";
                txttimkiem.ForeColor = Color.Gray;
            }
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khoá tìm kiếm...")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = Color.Black;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi form khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txttenkhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void mskdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
