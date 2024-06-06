using QLMP.Class;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using COMExcel = Microsoft.Office.Interop.Excel;



namespace QLMP.Forms
{
    public partial class Hoadonban : Form
    {
       
        public Hoadonban()
        {
            InitializeComponent();
            
        }
        private bool isInvalidInputShown = false;
        private void Hoadonban_Load(object sender, EventArgs e)
        {
            function.Connect();
            btnthem.Size = new Size(120, 30);
            btnhuy.Size = new Size(120, 30);
            btnluu.Size = new Size(120, 30);
            btnin.Size = new Size(100, 30);
            btntimkiem.Size = new Size(100, 30);
            btndong.Size = new Size(80, 30);
            //btnboqua.Size = new Size(90, 30);

            DatThuocTinhChoNnut(btnthem, Properties.Resources.add_icon);
            DatThuocTinhChoNnut(btnhuy, Properties.Resources.icons8_delete_20);
            DatThuocTinhChoNnut(btnluu, Properties.Resources.luu_icon);
            DatThuocTinhChoNnut(btnin, Properties.Resources.icons8_print_18);
            DatThuocTinhChoNnut(btntimkiem, Properties.Resources.icons8_search_20);
            //DatThuocTinhChoNnut(btnboqua, Properties.Resources.boqua_icon);
            DatThuocTinhChoNnut(btndong, Properties.Resources.dong_icon);

            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnin.Enabled = false;
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenkhachhang.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            msksdt.ReadOnly = true;
            txttenhang.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtchietkhau.Text = "0";
            txttongtien.Text = "0";
            function.Fillcombo("SELECT MaKH, TenKH FROM KhachHang", cbomakhachhang, "MaKH", "TenKH");
            cbomakhachhang.SelectedIndex = -1;
            function.Fillcombo("SELECT MaNV, TenNV FROM NhanVien", cbomanhanvien, "MaNV", "MaNV");
            cbomanhanvien.SelectedIndex = -1;
            function.Fillcombo("SELECT MaHang, TenHang FROM Hang", cbomahang, "MaHang", "MaHang");
            cbomahang.SelectedIndex = -1;
            function.Fillcombo("SELECT SoHDB, SoHDB FROM CTHDBan", cbomahoadon, "SoHDB", "SoHDB");
            cbomahoadon.SelectedIndex = -1;

            if (txtmahoadon.Text != "")
            {
                Load_ThongtinHD();
                btnhuy.Enabled = true;
                btnin.Enabled = true;
            }
            Load_DataGridViewChitiet();
        }
        private void DatThuocTinhChoNnut(Button button, Image image)
        {
            button.Image = ResizeImage(image, 20, 20);
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleRight;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var anhgoc = new Rectangle(0, 0, width, height);
            var anhthaydoi = new Bitmap(width, height);

            anhthaydoi.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var veanh = Graphics.FromImage(anhthaydoi))
            {
                veanh.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                veanh.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                veanh.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                veanh.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                veanh.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    veanh.DrawImage(image, anhgoc, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return anhthaydoi;
        }
        DataTable tblCTHDB;
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT a.SoHDB, b.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.ChietKhau, a.ThanhTien FROM CTHDBan AS a JOIN Hang AS b ON  a.MaHang=b.MaHang";
            tblCTHDB = function.GetDataToTable(sql);
            dgridhoadonban.DataSource = tblCTHDB;
            dgridhoadonban.Columns[0].HeaderText = "Mã hóa đơn";
            dgridhoadonban.Columns[1].HeaderText = "Mã hàng";
            dgridhoadonban.Columns[2].HeaderText = "Tên hàng";
            dgridhoadonban.Columns[3].HeaderText = "Số lượng";
            dgridhoadonban.Columns[4].HeaderText = "Đơn giá";
            dgridhoadonban.Columns[5].HeaderText = "Chiết khấu%";
            dgridhoadonban.Columns[6].HeaderText = "Thành tiền";
            dgridhoadonban.Columns[0].Width = 150;
            dgridhoadonban.Columns[1].Width = 90;
            dgridhoadonban.Columns[2].Width = 150;
            dgridhoadonban.Columns[3].Width = 90;
            dgridhoadonban.Columns[4].Width = 100;
            dgridhoadonban.Columns[5].Width = 120;
            dgridhoadonban.Columns[6].Width = 120;
            dgridhoadonban.AllowUserToAddRows = false;
            dgridhoadonban.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void HoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {

            ResetValues();
        }
        public string MaHoaDon { get; set; }

        private void dgridhoadonban_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahoadon.Focus();
                return;
            }
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtmahoadon.Text = dgridhoadonban.CurrentRow.Cells["SoHDB"].Value.ToString();
            string ngaybanQuery = "SELECT NgayBan FROM HDBan WHERE SoHDB = '" + txtmahoadon.Text + "'";
            string ngayBanString = function.GetFieldValues(ngaybanQuery);
            if (DateTime.TryParse(ngayBanString, out DateTime ngayBanDateTime))
            {
                dtngayban.Value = ngayBanDateTime;
            }
            else
            {
                MessageBox.Show("Không thể chuyển đổi giá trị ngày bán.");
            }


            string manv = "SELECT MaNV FROM HDBan WHERE  SoHDB = '" + txtmahoadon.Text + "'";
            string maNV = function.GetFieldValues(manv);
            cbomanhanvien.Text = maNV;

            string query = "SELECT TenNV FROM NhanVien WHERE MaNV = @MaNV";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@MaNV", maNV }
            };
            DataTable dt = function.ExecuteQueryWithParameters(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txttennhanvien.Text = row["TenNV"].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên cho Mã Nhân viên này.");
            }

            string makh = "SELECT MaKH FROM HDBan WHERE  SoHDB = '" + txtmahoadon.Text + "'";
            string maKH = function.GetFieldValues(makh);
            cbomakhachhang.Text = maKH;

            string khquery = "SELECT TenKH, DiaChi, SDT FROM KhachHang WHERE MaKH = @MaKH";
            Dictionary<string, object> parameter = new Dictionary<string, object>
            {
                { "@MaKH", maKH }
            };
            DataTable dtkh = function.ExecuteQueryWithParameters(khquery, parameter);
            if (dtkh.Rows.Count > 0)
            {
                DataRow row = dtkh.Rows[0];
                txttenkhachhang.Text = row["TenKH"].ToString();
                txtdiachi.Text = row["DiaChi"].ToString();
                msksdt.Text = row["SDT"].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng cho Mã khách hàng này.");
            }

            ma = dgridhoadonban.CurrentRow.Cells["MaHang"].Value.ToString();
            cbomahang.Text = function.GetFieldValues("SELECT MaHang FROM Hang WHERE MaHang = N'" + ma + "'");
            txttenhang.Text = dgridhoadonban.CurrentRow.Cells["TenHang"].Value.ToString();
            txtsoluong.Text = dgridhoadonban.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtchietkhau.Text = dgridhoadonban.CurrentRow.Cells["ChietKhau"].Value.ToString();
            txtthanhtien.Text = dgridhoadonban.CurrentRow.Cells["ThanhTien"].Value.ToString();
            txtdongia.Text = dgridhoadonban.CurrentRow.Cells["DonGiaBan"].Value.ToString();

            string tongtienquery = "SELECT TongTien FROM HDBan WHERE SoHDB = N'" + txtmahoadon.Text + "'";
            string tongtien = function.GetFieldValues(tongtienquery);
            txttongtien.Text = tongtien;
            txtbangchu.Text = function.ChuyenSoSangChu(tongtien);
            btnin.Enabled = true;
            btnhuy.Enabled = true;
            btndong.Enabled = true;
            //btnboqua.Enabled = true;
        }
        private void Load_ThongtinHD()
        {
            
            string str;
            str = "SELECT NgayBan FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            dtngayban.Value = DateTime.Parse(function.GetFieldValues(str));
            str = "SELECT MaNV FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            cbomanhanvien.Text = function.GetFieldValues(str);

            str = "SELECT MaKH FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            cbomakhachhang.Text = function.GetFieldValues(str);

            str = "SELECT TongTien FROM HDBan WHERE MaHDBan = N'" + txtmahoadon.Text + "'";
            txttongtien.Text = function.GetFieldValues(str);

            txtbangchu.Text = function.ChuyenSoSangChu(txttongtien.Text);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnin.Enabled = false;
            btnthem.Enabled = false;
            //btnboqua.Enabled = true;
            ResetValues();
            txtmahoadon.Text = function.CreateKey("HDB");
            Load_DataGridViewChitiet();
        }
        private void ResetValues()
        {
            txtmahoadon.Text = "";
            dtngayban.Value = DateTime.Now;
            cbomanhanvien.Text = "";
            txttennhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            msksdt.Text = "";
            txttongtien.Text = "0";
            txtbangchu.Text = " ";
            txtsoluong.Text = "";
            txtchietkhau.Text = "";
            txtthanhtien.Text = "0";

        }
        private void ResetValuesHang()
        {
            cbomahang.Text = "";
            txttenhang.Text = "";
            txtdongia.Text = "0";
            txtsoluong.Text = "";
            txtchietkhau.Text = "";
            txtthanhtien.Text = "0";

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double slcon, tong, tongmoi;
            int sl;

            sql = "SELECT SoHDB FROM HDBan WHERE SoHDB=N'" + txtmahoadon.Text + "'";
            bool isHDBanExists = function.CheckKey(sql);

            if (cbomanhanvien.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanhanvien.Focus();
                return;
            }
            if (cbomakhachhang.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakhachhang.Focus();
                return;
            }

            if (!isHDBanExists)
            {
                sql = "INSERT INTO HDBan(SoHDB, NgayBan, MaNV, MaKH, TongTien) VALUES(N'" + txtmahoadon.Text.Trim() + "', '" + function.ConvertDateTime(dtngayban.Text.Trim()) + "',N'" + cbomanhanvien.SelectedValue + "',N'" + cbomakhachhang.SelectedValue + "', 0)";
                function.RunSql(sql);
            }

            if (cbomahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahang.Focus();
                return;
            }
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtchietkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chiết khấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtchietkhau.Focus();
                return;
            }

            sql = "SELECT MaHang FROM CTHDBan WHERE MaHang= N'" + cbomahang.SelectedValue + "' AND SoHDB = N'" + txtmahoadon.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cbomahang.Focus();
                return;
            }

            sl = Convert.ToInt32(function.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + cbomahang.SelectedValue + "'"));
            if (Convert.ToInt32(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }

            sql = "INSERT INTO CTHDBan(SoHDB, MaHang, SoLuong, ChietKhau, ThanhTien) VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + cbomahang.SelectedValue + "'," + txtsoluong.Text + "," + txtchietkhau.Text + "," + txtthanhtien.Text + ")";
            function.RunSql(sql);
            Load_DataGridViewChitiet();

            slcon = sl - Convert.ToInt32(txtsoluong.Text);
            sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + cbomahang.SelectedValue + "'";
            function.RunSql(sql);

            tong = Convert.ToDouble(function.GetFieldValues("SELECT TongTien FROM HDBan WHERE SoHDB = N'" + txtmahoadon.Text + "'"));
            tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE HDBan SET TongTien =" + tongmoi + " WHERE SoHDB = N'" + txtmahoadon.Text + "'";
            function.RunSql(sql);

            txttongtien.Text = tongmoi.ToString();
            txtbangchu.Text = function.ChuyenSoSangChu(tongmoi.ToString());


            ResetValuesHang();

            btnhuy.Enabled = true;
            btnthem.Enabled = true;
            btnin.Enabled = true;

        }

        private void dgridhoadonban_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            Double thanhtien;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                mahang = dgridhoadonban.CurrentRow.Cells["MaHang"].Value.ToString();
                DelHang(txtmahoadon.Text, mahang);

                thanhtien = Convert.ToDouble(dgridhoadonban.CurrentRow.Cells["ThanhTien"].Value.ToString());
                DelUpdateTongtien(txtmahoadon.Text, thanhtien);
                Load_DataGridViewChitiet();
            }
        }
       
        private void DelHang(string mahd, string mahang)
        {
            Double s, sl, slcon;
            string sql;
            sql = "SELECT SoLuong FROM CTHDBan WHERE SoHDB = N'" + mahd + "' AND MaHang = N'" + mahang + "'";
            s = Convert.ToInt32(function.GetFieldValues(sql));
            sql = "DELETE CTHDBan WHERE SoHDB=N'" + mahd + "' AND MaHang = N'" + mahang + "'";
            function.RunSql(sql);

            sql = "SELECT SoLuong FROM Hang WHERE MaHang = N'" + mahang + "'";
            sl = Convert.ToInt32(function.GetFieldValues(sql));
            slcon = sl + s;
            sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + mahang + "'";
            function.RunSql(sql);
        }
        private void DelUpdateTongtien(string sohd, double thanhtien)
        {
            Double tong, tongmoi;
            string sql;
            sql = "SELECT TongTien FROM HDBan WHERE SoHDB = N'" + txtmahoadon.Text + "'";
            tong = Convert.ToDouble(function.GetFieldValues(sql));
            tongmoi = tong - thanhtien;
            sql = "UPDATE HDBan SET TongTien =" + tongmoi + " WHERE SoHDB = N'" + txtmahoadon.Text + "'";
            function.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            txtbangchu.Text = function.ChuyenSoSangChu(tongmoi.ToString());
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MaHang FROM CTHDBan WHERE SoHDB = N'" + txtmahoadon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, function.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();

                for (i = 0; i <= n - 1; i++)
                    DelHang(txtmahoadon.Text, Mahang[i]);

                sql = "DELETE HDBan WHERE SoHDB=N'" + txtmahoadon.Text + "'";
                function.RunSqlDel(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                btnhuy.Enabled = false;
                btnin.Enabled = false;
            }

        }

        private void cbomanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")
                txttennhanvien.Text = "";

            str = "Select TenNV from NhanVien where MaNV =N'" + cbomanhanvien.SelectedValue + "'";
            txttennhanvien.Text = function.GetFieldValues(str);
        }

        private void cbomakhachhang_TextChanged(object sender, EventArgs e)
        {

            string str;
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                msksdt.Text = "";
            }

            str = "Select TenKH from KhachHang where MaKH = N'" + cbomakhachhang.SelectedValue + "'";
            txttenkhachhang.Text = function.GetFieldValues(str);
            str = "Select DiaChi from KhachHang where MaKH = N'" + cbomakhachhang.SelectedValue + "'";
            txtdiachi.Text = function.GetFieldValues(str);
            str = "Select SDT from KhachHang where MaKH= N'" + cbomakhachhang.SelectedValue + "'";
            msksdt.Text = function.GetFieldValues(str);
        }

        private void cbomahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtdongia.Text = "";
            }

            str = "SELECT TenHang FROM Hang WHERE MaHang =N'" + cbomahang.SelectedValue + "'";
            txttenhang.Text = function.GetFieldValues(str);

            string updatedongiamoi = "UPDATE Hang SET DonGiaBan = ROUND(DonGiaNhap * 1.10,0) WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
            function.ExecuteQuery(updatedongiamoi);
            string selectdongiamoi = "SELECT DonGiaBan FROM Hang WHERE MaHang = N'" + cbomahang.SelectedValue + "'";
            txtdongia.Text = function.GetFieldValues(selectdongiamoi);
        }
        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsoluong.Text))
            {
                isInvalidInputShown = false;
                txtsoluong.Text = string.Empty;
                txtsoluong.Focus();
            }
            else if (!int.TryParse(txtsoluong.Text, out int sl) || sl <= 0)
            {
                if (!isInvalidInputShown)
                {
                    MessageBox.Show("Bạn chỉ được nhập số nguyên dương cho số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInvalidInputShown = true;
                }
                txtsoluong.Text = string.Empty;
                txtsoluong.Focus();
            }
            else
            {
                isInvalidInputShown = false;
                ThanhTien();
            }
        }
        private void txtchietkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }
        private void txtchietkhau_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtchietkhau.Text))
            {
                isInvalidInputShown = false;
                txtchietkhau.Text = string.Empty;
                txtchietkhau.Focus();
            }
            else if (!double.TryParse(txtchietkhau.Text, out double ck) || ck < 0)
            {
                if (!isInvalidInputShown)
                {
                    MessageBox.Show("Bạn phải nhập chiết khấu là một số không âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isInvalidInputShown = true;
                }
                txtchietkhau.Text = string.Empty;
                txtchietkhau.Focus();
            }
            else
            {
                isInvalidInputShown = false;
                ThanhTien();
            }
        }
        private void ThanhTien()
        {
            double tt, dg, ck;
            int sl;

            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToInt32(txtsoluong.Text);

            if (txtchietkhau.Text == "")
                ck = 0;
            else
                ck = Convert.ToDouble(txtchietkhau.Text);

            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);

            tt = sl * dg - sl * dg * ck / 100;
            txtthanhtien.Text = tt.ToString();

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng mỹ phẩm Sami";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (09)87562222";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";

            sql = "SELECT a.SoHDB, a.NgayBan, a.TongTien, b.TenKH, b.DiaChi, b.SDT, c.TenNV FROM HDBan AS a, KhachHang AS b, NhanVien AS c WHERE a.SoHDB = N'" + txtmahoadon.Text + "' AND a.MaKH= b.MaKH AND a.MaNV =c.MaNV";
            tblThongtinHD = function.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();

            sql = "SELECT b.TenHang, a.SoLuong, b.DonGiaBan, a.ChietKhau, a.ThanhTien " + "FROM CTHDBan AS a , Hang AS b WHERE a.SoHDB = N'" + txtmahoadon.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = function.GetDataToTable(sql);



            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Chiết khấu";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {

                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)

                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15];
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + function.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            //btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnhuy.Enabled = true;
            btnluu.Enabled = false;
            txtmahoadon.Enabled = false;
            ResetValues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahoadon.Focus();
                return;
            }
            string mahd = cbomahoadon.Text;
            this.Hide();
            TKHDB frmTKHDB = new TKHDB(mahd);
            frmTKHDB.ShowDialog();

            this.Show();
        }

        private void cbomahoadon_DropDown(object sender, EventArgs e)
        {

            function.Fillcombo("SELECT SoHDB FROM HDBan", cbomahoadon, "SoHDB", "SoHDB");
            cbomahoadon.SelectedIndex = -1;
        }

        private void cbomahang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    } 
}
