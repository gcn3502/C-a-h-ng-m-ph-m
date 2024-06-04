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
    public partial class TKHDB : Form
    {
        public TKHDB()
        {
            InitializeComponent();
        }

        DataTable tblHDB;
        private void TKHDB_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgridtkhdb.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmahd.Focus();
        }

        private void txtnam_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmahd.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") &&(txtmanv.Text == "") && (txtmakh.Text == "") &&(txttong.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT * FROM HDBan WHERE 1=1";
            if (txtmahd.Text != "")
                sql = sql + " AND SoHDB Like N'%" + txtmahd.Text + "%'";

            if (txtthang.Text != "")
                sql = sql + " AND MONTH(NgayBan) =" + txtthang.Text;

            if (txtnam.Text != "")
                sql = sql + " AND YEAR(NgayBan) =" + txtnam.Text;

            if (txtmanv.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtmanv.Text + "%'";

            if (txtmakh.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtmakh.Text + "%'";

            if (txttong.Text != "")
                sql = sql + " AND TongTien <=" + txttong.Text;

            tblHDB = function.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgridtkhdb.DataSource = tblHDB;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            dgridtkhdb.Columns[0].HeaderText = "Mã HĐB";
            dgridtkhdb.Columns[1].HeaderText = "Mã nhân viên";
            dgridtkhdb.Columns[2].HeaderText = "Ngày bán";
            dgridtkhdb.Columns[3].HeaderText = "Mã khách";
            dgridtkhdb.Columns[4].HeaderText = "Tổng tiền";
            dgridtkhdb.Columns[0].Width = 150;
            dgridtkhdb.Columns[1].Width = 100;
            dgridtkhdb.Columns[2].Width = 80;
            dgridtkhdb.Columns[3].Width = 80;
            dgridtkhdb.Columns[4].Width = 80;
            dgridtkhdb.AllowUserToAddRows = false;
            dgridtkhdb.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgridtkhdb.DataSource = null;

        }

        private void txttong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgridtkhdb_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgridtkhdb.CurrentRow.Cells["SoHDB"].Value.ToString();
                Hoadonban frm = new Hoadonban();
                frm.txtmahoadon.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmahd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtthang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtnam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmanv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmakh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtthang_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô không rỗng và không phải là số dương
            if (!string.IsNullOrEmpty(txtthang.Text))
            {
                if (int.TryParse(txtthang.Text, out int value))
                {
                    if (value <= 0)
                    {
                        MessageBox.Show("Tháng phải lớn hơn 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtthang.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chỉ nhập số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtthang.Text = "";
                }
            }
        }

        private void txtnam_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô không rỗng và không phải là số dương
            if (!string.IsNullOrEmpty(txtnam.Text))
            {
                if (int.TryParse(txtnam.Text, out int value))
                {
                    if (value <= 0)
                    {
                        MessageBox.Show("Năm phải lớn hơn 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnam.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chỉ nhập số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnam.Text = "";
                }
            }
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttong_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô không rỗng và không phải là số dương
            if (!string.IsNullOrEmpty(txttong.Text))
            {
                if (int.TryParse(txttong.Text, out int value))
                {
                    if (value <= 0)
                    {
                        MessageBox.Show("Tổng phải lớn hơn 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txttong.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chỉ nhập số", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttong.Text = "";
                }
            }
        }
    }
}
