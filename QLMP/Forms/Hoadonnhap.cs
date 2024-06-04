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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLMP.Forms
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        DataTable tblCTHDN;

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnin.Enabled = false;
            txthoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenncc.ReadOnly = true;  
            txtdiachi.ReadOnly = true;
            mskdienthoai.ReadOnly = true;
            txttenhang.ReadOnly = true;
            txtdongia.ReadOnly = false;  
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtchietkhau.Text = "0";
            txttongtien.Text = "0";

            cbomanhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbomancc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbomahang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbomahd.DropDownStyle = ComboBoxStyle.DropDownList;

            function.Fillcombo("SELECT MaNCC, TenNCC FROM NhaCungCap", cbomancc, "MaNCC", "MaNCC");
            cbomancc.SelectedIndex = -1;
            function.Fillcombo("SELECT MaNV, TenNV FROM NhanVien", cbomanhanvien, "MaNV", "MaNV");
            cbomanhanvien.SelectedIndex = -1;
            function.Fillcombo("SELECT MaHang,TenHang FROM Hang", cbomahang, "MaHang", "MaHang");
            cbomahang.SelectedIndex = -1;
            function.Fillcombo("SELECT SoHDN From CTHDNhap", cbomahd, "SoHDN", "SoHDN");
            cbomahd.SelectedIndex = -1;

            if (txthoadon.Text != "")
            {
                LoadInfoHD();
                btnhuy.Enabled = true;
                btnin.Enabled = true;
            }

            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaNhap, a.ChietKhau, a.ThanhTien FROM CTHDNhap AS a INNER JOIN Hang AS b ON a.MaHang = b.MaHang WHERE a.SoHDN = N'" + txthoadon.Text + "'";
            //sql = "SELECT a.MaHang, a.TenHang, a.SoLuong, b.DonGiaNhap, a.ChietKhau, a.ThanhTien FROM CTHDNhap AS a, Hang AS b WHERE a.SoHDN = N'" + txthoadon.Text + "' AND a.MaHang = b.MaHang";
            tblCTHDN = function.GetDataToTable(sql);
            dgridHDNhap.DataSource = tblCTHDN;
            dgridHDNhap.Columns[0].HeaderText = "Mã hàng";
            dgridHDNhap.Columns[1].HeaderText = "Tên hàng";
            dgridHDNhap.Columns[2].HeaderText = "Số lượng";
            dgridHDNhap.Columns[3].HeaderText = "Đơn giá";
            dgridHDNhap.Columns[4].HeaderText = "Chiết khấu %";
            dgridHDNhap.Columns[5].HeaderText = "Thành tiền";
            dgridHDNhap.Columns[0].Width = 90;
            dgridHDNhap.Columns[1].Width = 200;
            dgridHDNhap.Columns[2].Width = 90;
            dgridHDNhap.Columns[3].Width = 120;
            dgridHDNhap.Columns[4].Width = 100;
            dgridHDNhap.Columns[5].Width = 150;
            dgridHDNhap.AllowUserToAddRows = false;
            dgridHDNhap.EditMode = DataGridViewEditMode.EditProgrammatically;
            btnsua.Enabled = true;
        }

        private void LoadInfoHD()
        {
            string str;
            str = "SELECT NgayNhap FROM HDNhap WHERE SOHDN = N'" + txthoadon.Text + "'";
            dtngaynhap.Value = DateTime.Parse(function.GetFieldValues(str));

            str = "SELECT MaNV FROM HDNhap WHERE SoHDN = N'" + txthoadon.Text + "'";
            cbomanhanvien.SelectedValue = function.GetFieldValues(str);

            str = "SELECT MaNCC FROM HDNhap WhERE SoHDN = N'" + txthoadon.Text + "'";
            cbomancc.SelectedValue = function.GetFieldValues(str);

            str = "SELECT TongTien FROM HDNhap WHERE SoHDN =N'" + txthoadon.Text + "'";
            txttongtien.Text = function.GetFieldValues(str);

            lblbangchu.Text = "Bằng chữ: " + function.Chuyensangchuoi(double.Parse(txttongtien.Text));
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;
            ResetValues();
            txthoadon.Text = function.CreateKey("HDN");
            LoadDataGridView();
            ResetValuesHang();
        }

        private void ResetValues()
        {
            txthoadon.Text = "";
            dtngaynhap.Value = DateTime.Now;
            cbomanhanvien.Text = "";
            cbomancc.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtchietkhau.Text = "0";
            txtthanhtien.Text = "0";
            txttennhanvien.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";

        }



        private void ResetValuesHang()
        {
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtchietkhau.Text = "0";
            txtthanhtien.Text = "0";


            txttenhang.Text = "";
            txtdongia.Text = "0";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            int sl, slton;
            double tong, tongmoi;
            sql = "SELECT SoHDN FROM HDNhap WHERE SoHDN = N'" + txthoadon.Text + "'";
            if (!function.CheckKey(sql))
            {
                if (cbomanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomanhanvien.Focus();
                    return;
                }

                if (cbomancc.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomancc.Focus();
                    return;
                }

                sql = "INSERT INTO HDNhap(SoHDN, NgayNhap, MaNV, MaNCC, TongTien) VALUES (N'" + txthoadon.Text.Trim() + "', '" + dtngaynhap.Value + "', N'" + cbomanhanvien.SelectedValue + "', N'" + cbomancc.SelectedValue + "', " + txttongtien.Text + ") ";

                function.RunSql(sql);
            }

            if (cbomahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahang.Focus();
                return;
            }
            if ((txtdongia.Text.Trim().Length == 0) || (txtdongia.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            sql = "UPDATE Hang SET DonGiaNhap=" + txtdongia.Text + " WHERE MaHang= N'" + cbomahang.SelectedValue + "'";
            function.RunSql(sql);
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }

            if (txtchietkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chiết khấu %", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchietkhau.Focus();
                return;
            }

            sql = "SELECT MaHang FROM CTHDNhap WHERE MaHang = N'" + cbomahang.SelectedValue + "' AND SoHDN =N'" + txthoadon.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn hãy nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cbomahang.Focus();
                return;
            }

            sql = "INSERT INTO CTHDNhap(SoHDN, MaHang, SoLuong, ChietKhau, ThanhTien) VALUES (N'" + txthoadon.Text.Trim() + "', N'" + cbomahang.SelectedValue + "', " + txtsoluong.Text + ", " + txtchietkhau.Text + ", " + txtthanhtien.Text + ") ";
            function.RunSql(sql);
            LoadDataGridView();
            string sqlsoluong = "SELECT SoLuong FROM Hang WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
            sl = Convert.ToInt32(function.GetFieldValues(sqlsoluong));

            // Cập nhật lại số lượng mặt hàng vào bảng hàng
            slton = sl + Convert.ToInt32(txtsoluong.Text);
            sql = "UPDATE Hang SET SoLuong=" + slton + " WHERE MaHang= N'" + cbomahang.SelectedValue + "'";
            function.RunSql(sql);

            //Cập nhật lại tổng tiền cho hoá đơn nhập
            tong = Convert.ToDouble(function.GetFieldValues("SELECT TongTien FROM HDNhap WHERE SoHDN=N'" + txthoadon.Text + "'"));
            tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE HDNhap SET TongTien= " + tongmoi + " WHERE SoHDN = N'" + txthoadon.Text + "'";
            function.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + function.Chuyensangchuoi(double.Parse(tongmoi.ToString()));

            // cập nhật đơn giá nhập
            int donGiaNhapMoi = Convert.ToInt32(txtdongia.Text);
            // Cập nhật đơn giá nhập mới vào bảng hàng
            sql = "UPDATE Hang SET DonGiaNhap = " + donGiaNhapMoi + " WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
            function.RunSql(sql);

            ResetValuesHang();
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnthem.Enabled = true;
            btnin.Enabled = true;
        }
        private void cbomahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtdongia.Text = "";
            }
            str = "SELECT TenHang FROM Hang WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
            txttenhang.Text = function.GetFieldValues(str);
            //str = "SELECT DonGiaNhap FROM Hang WHERE MaHang=N'" + cbomahang.SelectedValue + "'";
            //txtdongia.Text = function.GetFieldValues(str);
        }

        private void cbomanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "") {
                txttennhanvien.Text = "";
            }
            str = "SELECT TenNV FROM NhanVien WHERE MaNV =N'"+cbomanhanvien.SelectedValue+"'";
            txttennhanvien.Text = function.GetFieldValues(str);
        }

        private void cbomancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomancc.Text == "")
            {
                txttenncc.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
            }
            str = "SELECT TenNCC FROM NhaCungCap WHERE MaNCC=N'" + cbomancc.SelectedValue + "'";
            txttenncc.Text = function.GetFieldValues(str);
            str = "SELECT DiaChi FROM NhaCungCap WHERE MaNCC=N'" + cbomancc.SelectedValue + "'";
            txtdiachi.Text = function.GetFieldValues(str);
            str = "SELECT SDT FROM NhaCungCap WHERE MaNCC=N'" + cbomancc.SelectedValue + "'";
            mskdienthoai.Text = function.GetFieldValues(str);

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, dg, ck;
            int sl;
            if(txtsoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtsoluong.Text);
            }

            if (txtchietkhau.Text == "")
            {
                ck= 0;
            }
            else
            {
                ck = Convert.ToDouble(txtchietkhau.Text);
            }

            if (txtdongia.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToDouble(txtdongia.Text);
            }

            tt = sl * dg - sl * dg * ck / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            if (!(txtchietkhau.Text.Trim().Length == 0) && txtchietkhau.Text != ".")
            {
                // Kiểm tra nếu giá trị trong khoảng 0-99
                double chietkhau = Convert.ToDouble(txtchietkhau.Text);
                if (chietkhau < 0 || chietkhau > 99)
                {
                    MessageBox.Show("Bạn phải nhập chiết khấu trong khoảng từ 0-99", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtchietkhau.Text = "";
                    txtchietkhau.Focus();
                }
            }
            double tt, dg, ck;
            int sl;
            if (txtsoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtsoluong.Text);
            }

            if (txtchietkhau.Text == "")
            {
                ck = 0;
            }
            else
            {
                ck = Convert.ToDouble(txtchietkhau.Text);
            }

            if (txtdongia.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToDouble(txtdongia.Text);
            }

            tt = sl * dg - sl * dg * ck / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            double tt, dg, ck;
            int sl;
            if (txtsoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtsoluong.Text);
            }

            if (txtchietkhau.Text == "")
            {
                ck = 0;
            }
            else
            {
                ck = Convert.ToDouble(txtchietkhau.Text);
            }

            if (txtdongia.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToDouble(txtdongia.Text);
            }

            tt = sl * dg - sl * dg * ck / 100;
            txtthanhtien.Text = tt.ToString();
        }
        private void cbomahd_DropDown(object sender, EventArgs e)
        {
            function.Fillcombo("SELECT SoHDN FROM HDNhap", cbomahd, "SoHDN", "SoHDN");
            cbomahd.SelectedIndex = -1;
        }

        private void btnimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahd.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một hoá đơn để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahd.Focus();
                return;
            }
            txthoadon.Text = cbomahd.Text;
            LoadInfoHD();
            LoadDataGridView();
            btnhuy.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            btnin.Enabled = true;
            ResetValuesHang();
            cbomahd.SelectedIndex = -1;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            int sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaHang,SoLuong FROM CTHDNhap WHERE SoHDN = N'" + txthoadon.Text + "'";
                DataTable tblHang = function.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToInt32(function.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToInt32(tblHang.Rows[hang][1].ToString());
                    slcon = sl - slxoa;
                    sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    function.RunSql(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE CTHDNhap WHERE SoHDN=N'" + txthoadon.Text + "'";
                function.RunSql(sql);

                //Xóa hóa đơn
                sql = "DELETE HDNhap WHERE SoHDN =N'" + txthoadon.Text + "'";
                function.RunSql(sql);
                ResetValues();
                LoadDataGridView();
                btnhuy.Enabled = false;
                btnin.Enabled = false;
            }
        }
        private void dgridHDNhap_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, tong, tongmoi;
            int slgxoa, sl, slcon;
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgridHDNhap.CurrentRow.Cells["MaHang"].Value.ToString();
                slgxoa = Convert.ToInt32(dgridHDNhap.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgridHDNhap.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE CTHDNhap WHERE SoHDN=N'" + txthoadon.Text + "' AND MaHang = N'" + MaHangxoa + "'";
                function.RunSql(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToInt32(function.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + MaHangxoa + "'"));
                slcon = sl - slgxoa;
                sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + MaHangxoa + "'";
                function.RunSql(sql);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                tong = Convert.ToDouble(function.GetFieldValues("SELECT TongTien FROM HDNhap WHERE SoHDN = N'" + txthoadon.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE HDNhap SET TongTien =" + tongmoi + " WHERE SoHDN = N'" + txthoadon.Text + "'";
                function.RunSql(sql);
                txttongtien.Text = tongmoi.ToString();
                lblbangchu.Text = "Bằng chữ: " + function.Chuyensangchuoi(double.Parse(tongmoi.ToString()));
                LoadDataGridView();
                ResetValuesHang();
            }
        }

        private void txtchietkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||(Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13)|| (Convert.ToInt32(e.KeyChar) == 46))
            {
                if ((Convert.ToInt32(e.KeyChar) == 46) && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)|| (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           ResetValues();
        }
        private void dgridHDNhap_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoadon.Focus();
                return;
            }
            if (tblCTHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ma = dgridHDNhap.CurrentRow.Cells["MaHang"].Value.ToString();
            cbomahang.Text = function.GetFieldValues("SELECT MaHang FROM Hang WHERE MaHang = N'" + ma + "'");
            txttenhang.Text = dgridHDNhap.CurrentRow.Cells["TenHang"].Value.ToString();
            txtsoluong.Text = dgridHDNhap.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtchietkhau.Text = dgridHDNhap.CurrentRow.Cells["ChietKhau"].Value.ToString();
            txtthanhtien.Text = dgridHDNhap.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtdongia.Text = dgridHDNhap.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            btnsua.Enabled = true;
        }

        //private void btnsua_Click(object sender, EventArgs e)
        //{
        //    string sql;
        //    int slcu, slmoi, slton, sl;
        //    double tong, tongmoi;
        //    if (tblCTHDN.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Không có bản ghi nào để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (cbomahang.Text == "")
        //    {
        //        MessageBox.Show("Bạn chưa chọn bản ghi nào để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        cbomahang.Focus();
        //        return;
        //    }
        //    if ((txtdongia.Text.Trim().Length == 0) || (txtdongia.Text == "0"))
        //    {
        //        MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtdongia.Focus();
        //        return;
        //    }
        //    if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
        //    {
        //        MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtsoluong.Focus();
        //        return;
        //    }

        //    if (txtchietkhau.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Bạn phải nhập chiết khấu %", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        txtchietkhau.Focus();
        //        return;
        //    }

        //    string sqlsoluong = "SELECT SoLuong FROM Hang WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
        //    sl = Convert.ToInt32(function.GetFieldValues(sqlsoluong));

        //    string maHang = cbomahang.Text;
        //    string sqlslg = "SELECT SoLuong FROM CTHDNhap WHERE MaHang =N'" + maHang + "'";
        //    DataTable dt = function.GetDataToTable(sqlslg);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        object soLuongObj = dt.Rows[0]["SoLuong"];
        //        int slcu = Convert.ToInt32(soLuongObj);
        //        slmoi = Convert.ToInt32(txtsoluong.Text);

        //        slton = sl + slcu - slmoi;

        //        sql = "UPDATE Hang SET SoLuong=" + slton + " WHERE MaHang= N'" + cbomahang.SelectedValue + "'";
        //        function.RunSql(sql);
        //    }


        //    // Cập nhật lại tổng tiền cho hóa đơn nhập
        //    tong = Convert.ToDouble(function.GetFieldValues("SELECT TongTien FROM HDNhap WHERE SoHDN = N'" + txthoadon.Text + "'"));
        //    tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
        //    sql = "UPDATE HDNhap SET TongTien = " + tongmoi + " WHERE SoHDN = N'" + txthoadon.Text + "'";
        //    function.RunSql(sql);
        //    txttongtien.Text = tongmoi.ToString();
        //    lblbangchu.Text = "Bằng chữ: " + function.Chuyensangchuoi(double.Parse(tongmoi.ToString()));

        //    // cập nhật đơn giá nhập
        //    int donGiaNhapMoi = Convert.ToInt32(txtdongia.Text);
        //    // Cập nhật đơn giá nhập mới vào bảng hàng
        //    sql = "UPDATE Hang SET DonGiaNhap = " + donGiaNhapMoi + " WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
        //    function.RunSql(sql);

        //    ResetValuesHang();
        //    cbomahang.Enabled = false;
        //    btnsua.Enabled = true;
        //    btnhuy.Enabled = true;
        //    btnthem.Enabled = true;
        //    btnin.Enabled = true;
        //    LoadDataGridView();
        //}

        private void btnin_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop kem trộn";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Thanh Xuân - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (038)8555999";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";
            // Biểu diễn thông tin chung của hóa đơn nhập

            sql = @"SELECT a.SoHDN, a.NgayNhap, a.TongTien, b.TenNCC, b.DiaChi, b.SDT, c.TenNV
                    FROM HDNhap AS a
                    INNER JOIN NhaCungCap AS b ON a.MaNCC = b.MaNCC
                    INNER JOIN NhanVien AS c ON a.MaNV = c.MaNV
                    WHERE a.SoHDN='" + txthoadon.Text + "';";

            tblThongtinHD = function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Số hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Nhà cung cấp";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenHang, a.SoLuong, b.DonGiaNhap, a.ChietKhau, a.ThanhTien " +
            "FROM CTHDNhap AS a , Hang AS b WHERE a.SoHDN = N'" + txthoadon.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = function.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Chiết khấu";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + function.Chuyensangchuoi(double.Parse(tblThongtinHD.Rows[0][2].ToString()));
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
