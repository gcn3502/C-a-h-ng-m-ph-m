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
    public partial class Congviec : Form
    {
        public Congviec()
        {
            InitializeComponent();
        }

        DataTable tblcv;

        private void Congviec_Load(object sender, EventArgs e)
        {
            function.Connect();
            txttimkiem.Text = "Nhập từ khóa tìm kiếm";
            txttimkiem.ForeColor = System.Drawing.Color.Gray;
            txttencv.KeyPress += new KeyPressEventHandler(txttencv_KeyPress);
            txtmucluong.KeyPress += new KeyPressEventHandler(txtmucluong_KeyPress);
            txtmucluong.TextChanged += new EventHandler(txtmucluong_TextChanged);
            btntimkiem.Enter += new EventHandler(btntimkiem_Enter);
            btntimkiem.Leave += new EventHandler(btntimkiem_Leave);

            txtmacv.Enabled = false;
            //txttencv.Enabled = false;
            //txtmota.Enabled = false;
            //txtmucluong.Enabled = false;
            //btnluu.Enabled = false;
            //btnhuy.Enabled = false;
            load_datagrid();
            ResetValues();
        }

        private void ResetValues()
        {
            // Không reset giá trị của txtmanv
            txtmacv.Text = "";
            txttencv.Text = "";
            txtmucluong.Text = "";
            txtmota.Text = "";

        }

        private void load_datagrid()
        {
            string sql;
            sql = "SELECT * FROM CongViec";
            tblcv = function.GetDataToTable(sql);
            dgridcongviec.DataSource = tblcv;
            dgridcongviec.Columns[0].HeaderText = "Mã công việc ";
            dgridcongviec.Columns[1].HeaderText = "Tên công việc ";
            dgridcongviec.Columns[2].HeaderText = "Mức lương";
            dgridcongviec.Columns[3].HeaderText = "Mô tả";
            dgridcongviec.Columns[0].Width = 162;
            dgridcongviec.Columns[1].Width = 162;
            dgridcongviec.Columns[2].Width = 162;
            dgridcongviec.Columns[3].Width = 162;

            dgridcongviec.AllowUserToAddRows = false;
            dgridcongviec.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgridcongviec_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmacv.Focus();
                return;
            }

            if (tblcv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if (txttencv.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txttencv.Focus();
            //    return;
            //}

            //if (txtmucluong.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtmucluong.Focus();
            //    return;
            //}

            txtmacv.Text = dgridcongviec.CurrentRow.Cells["MaCV"].Value.ToString();
            txttencv.Text = dgridcongviec.CurrentRow.Cells["TenCV"].Value.ToString();
            txtmucluong.Text = dgridcongviec.CurrentRow.Cells["MucLuong"].Value.ToString();
            txtmota.Text = dgridcongviec.CurrentRow.Cells["MoTa"].Value.ToString();

            txtmacv.Enabled = true;
            txttencv.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "INSERT INTO CongViec(MaCV, TenCV, MucLuong, MoTa) VALUES(null,-1,-1,-1)";
            function.RunSql(sql);

            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnsua.Enabled = false;

            ResetValues();
            txtmacv.Focus();
            string sqlcheck = "SELECT TOP 1 MaCV FROM CongViec ORDER BY MaCV DESC";
            DataTable dt = function.GetDataToTable(sqlcheck);
            string macv = "";

            if (dt != null)
            {
                macv = dt.Rows[0]["MaCV"].ToString();
            }

            txtmacv.Text = macv;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttencv.Focus();
                return;
            }

            if (txtmucluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmucluong.Focus();
                return;
            }

            //if (txtmota.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn cần nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtmota.Focus();
            //    return;
            //}

            sql = "UPDATE CongViec SET TenCV=N'" + txttencv.Text.Trim() + "',MucLuong=N'" + txtmucluong.Text.Trim() + "',MoTa=N'" + txtmota.Text.Trim() + "' WHERE MaCV =N'" + txtmacv.Text + "'";

            function.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmacv.Enabled = false;
            txttencv.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblcv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtmacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txttencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (txtmucluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            //if (txtmota.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Bạn phải nhập mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            sql = "UPDATE CongViec SET TenCV=N'" + txttencv.Text.Trim().ToString() + "',MucLuong=N'" + txtmucluong.Text.Trim().ToString() + "',MoTa=N'" + txtmota.Text.Trim().ToString() + "' WHERE MaCV=N'" + txtmacv.Text + "'";
            function.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnhuy.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblcv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txttencv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtmucluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mức lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM CongViec WHERE MaCV=N'" + txtmacv.Text.Trim() + "'";
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
            txtmacv.Enabled = false;
        }

        private void txttimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmacv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttencv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmucluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmota_KeyUp(object sender, KeyEventArgs e)
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

            sql = "SELECT * FROM CongViec WHERE 1=1";

            if (!string.IsNullOrEmpty(txttimkiem.Text) && txttimkiem.Text.Trim() != "Hãy nhập từ khóa tìm kiếm")
            {
                sql += " AND (TenCV LIKE N'%" + txttimkiem.Text.Trim() + "%' OR MaCV LIKE N'%" + txttimkiem.Text.Trim() + "%')";
            }

            tblcv = function.GetDataToTable(sql);
            if (tblcv.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblcv.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dgridcongviec.DataSource = tblcv;
            ResetValues();
            txttimkiem.Enabled = true;
            dgridcongviec.Columns[0].Width = 162;
            dgridcongviec.Columns[1].Width = 162;
            dgridcongviec.Columns[2].Width = 162;
            dgridcongviec.Columns[3].Width = 162;
        }

        private void btntimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Nhập từ khóa tìm kiếm.....")
            {
                txttimkiem.Text = "";
                txttimkiem.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void btntimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Nhập từ khóa tìm kiếm.....";
                txttimkiem.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txttencv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là chữ cái không (bao gồm cả chữ hoa và chữ thường)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hủy bỏ ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void txtmucluong_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô không rỗng và không phải là số dương
            if (!string.IsNullOrEmpty(txtmucluong.Text))
            {
                if (int.TryParse(txtmucluong.Text, out int value))
                {
                    if (value <= 0)
                    {
                        MessageBox.Show("Mức lương phải lớn hơn 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmucluong.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chỉ nhập số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmucluong.Text = "";
                }
            }
        }

        private void txtmucluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnđong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát không???", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Application.Exit();
        }

        
    }
}
