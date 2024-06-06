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
    public partial class Phanloai : Form
    {
        public Phanloai()
        {
            InitializeComponent();
        }

        DataTable tblpl;
        private void Phanloai_Load(object sender, EventArgs e)
        {
            function.Connect();
            txtmaloai.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            load_datagrid();
            ResetValues();
        }

        private void ResetValues()
        {
            // Không reset giá trị của txtmanv
            txtmaloai.Text = "";
            txttenloai.Text = "";

        }

        private void load_datagrid()
        {
            string sql;
            sql = "SELECT * FROM Loai";
            tblpl = function.GetDataToTable(sql);
            dgridphanloai.DataSource = tblpl;
            dgridphanloai.Columns[0].HeaderText = "Mã phân loại ";
            dgridphanloai.Columns[1].HeaderText = "Tên phân loại ";
            dgridphanloai.Columns[0].Width = 325;
            dgridphanloai.Columns[1].Width = 325;

            dgridphanloai.AllowUserToAddRows = false;
            dgridphanloai.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridphanloai_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (tblpl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaloai.Text = dgridphanloai.CurrentRow.Cells["MaLoai"].Value.ToString();
            txttenloai.Text = dgridphanloai.CurrentRow.Cells["TenLoai"].Value.ToString();

            txtmaloai.Enabled = true;
            txttenloai.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "INSERT INTO Loai(MaLoai, TenLoai) VALUES(null,-1)";
            function.RunSql(sql);

            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnsua.Enabled = false;

            ResetValues();
            txtmaloai.Focus();
            string sqlcheck = "SELECT TOP 1 MaLoai FROM Loai ORDER BY MaLoai DESC";
            DataTable dt = function.GetDataToTable(sqlcheck);
            string maloai = "";

            if (dt != null)
            {
                maloai = dt.Rows[0]["MaLoai"].ToString();
            }

            txtmaloai.Text = maloai;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenloai.Focus();
                return;
            }

            sql = "UPDATE Loai SET TenLoai =N'" + txttenloai.Text.Trim() + "' WHERE MaLoai =N'" + txtmaloai.Text + "'";

            function.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblpl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            sql = "UPDATE Loai SET TenLoai=N'" + txttenloai.Text.Trim() + "' WHERE MaLoai=N'" + txtmaloai.Text + "'";
            function.RunSql(sql);
            load_datagrid();
            ResetValues();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblpl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txttenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM Loai WHERE Maloai=N'" + txtmaloai.Text.Trim() + "'";
                function.RunSql(sql);
                load_datagrid();
                ResetValues();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            //string Maloai = txtmaloai.Text.Trim();
            ResetValues();
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void txttimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmaloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }



        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttimkiem.Text.Trim() == "" || txttimkiem.Text.Trim() == "Hãy nhập từ khóa tìm kiếm")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT * FROM Loai WHERE 1=1";

            if (!string.IsNullOrEmpty(txttimkiem.Text) && txttimkiem.Text.Trim() != "Hãy nhập từ khóa tìm kiếm")
            {
                sql += " AND (TenLoai LIKE N'%" + txttimkiem.Text.Trim() + "%' OR MaLoai LIKE N'%" + txttimkiem.Text.Trim() + "%')";
            }

            tblpl = function.GetDataToTable(sql);
            if (tblpl.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblpl.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgridphanloai.DataSource = tblpl;
            ResetValues();
            txttimkiem.Enabled = true;
            dgridphanloai.Columns[0].Width = 325;
            dgridphanloai.Columns[1].Width = 325;
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khóa tìm kiếm.....")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Nhập từ khóa tìm kiếm.....";
                txttimkiem.ForeColor = System.Drawing.Color.Gray;
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

        private void txttenloai_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là chữ cái không (bao gồm cả chữ hoa và chữ thường)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Hủy bỏ ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void txttimkiem_MouseEnter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khóa tìm kiếm.....")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txttimkiem_MouseLeave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khóa tìm kiếm.....")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btnđong_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Application.Exit();
        }

        
    }
}
