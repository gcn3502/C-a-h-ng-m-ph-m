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

namespace QLMP.Forms
{
    public partial class Hanghoa : Form
    {
        public Hanghoa()
        {
            InitializeComponent();
        }

        // MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
        private void Hanghoa_Load(object sender, EventArgs e)
        {
            function.Connect();
            txt_tk.Focus();
            txt_mahang.Enabled = false;
            btn_luu.Enabled = false;
            btn_boqua.Enabled = false;
            Load_DataGridView();
            function.Fillcombo("SELECT MaLoai, TenLoai FROM Loai", combo_maloai, "MaLoai", "TenLoai");
            combo_maloai.SelectedIndex = -1;

            ResetValues();

        }
        // 1
        private void ResetValues()
        {
            txt_mahang.Text = "";
            txt_ten.Text = "";
            combo_maloai.Text = "";
            txt_thuonghieu.Text = "";
            txt_quocgia.Text = "";
            txt_congdung.Text = " ";
            txt_khoiluong.Text = "";
            txt_sl.Text = "0";
            txt_dgnhap.Text = "0";
            txt_dgban.Text = "0";
            //txt_sl.Enabled = false;
            //txt_dgban.Enabled = false;
            //txt_dgnhap.Enabled = false;
            txt_anh.Text = "";
            pic.Image = null;
            txt_ghichu.Text = "";
            txt_quocgia.Text = "";
            txt_tk.Text= "Nhập từ khóa để tìm kiếm";
            combox_sx.SelectedIndex = -1;

        }
        DataTable dt;
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu FROM Hang";
            dt = function.GetDataToTable(sql);
            datagridview_hanghoa.DataSource = dt;
            datagridview_hanghoa.Columns[0].HeaderText = "Mã hàng";
            datagridview_hanghoa.Columns[1].HeaderText = "Tên hàng";
            datagridview_hanghoa.Columns[2].HeaderText = "Loại";
            datagridview_hanghoa.Columns[3].HeaderText = "Thương hiệu";
            datagridview_hanghoa.Columns[4].HeaderText = "Quốc gia";
            datagridview_hanghoa.Columns[5].HeaderText = "Công dụng";
            datagridview_hanghoa.Columns[6].HeaderText = "Khối lượng";
            datagridview_hanghoa.Columns[7].HeaderText = "Số lượng";
            datagridview_hanghoa.Columns[8].HeaderText = "Đơn giá nhập";
            datagridview_hanghoa.Columns[9].HeaderText = "Đơn giá bán";

            datagridview_hanghoa.AllowUserToAddRows = false;
            datagridview_hanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void datagridview_hanghoa_Click(object sender, EventArgs e)
        {
            //string ma;
            //if (btn_them.Enabled == false)
            //{
            //    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_mahang.Focus();
            //    return;
            //}
            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    return;
            //}
            //// // MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
            //txt_mahang.Text = datagridview_hanghoa.CurrentRow.Cells["MaHang"].Value.ToString();
            //txt_ten.Text = datagridview_hanghoa.CurrentRow.Cells["TenHang"].Value.ToString();

            ////ma = datagridview_hanghoa.CurrentRow.Cells["MaLoai"].Value.ToString();
            ////combo_maloai.Text = function.GetFieldValues("SELECT TenLoai FROM Loai WHERE MaLoai = N'" + ma + "'");

            //ma = datagridview_hanghoa.CurrentRow.Cells["MaLoai"].Value.ToString();
            //combo_maloai.Text = function.GetFieldValues("SELECT TenLoai FROM Loai WHERE MaLoai = N'" + ma + "'");

            //txt_thuonghieu.Text = datagridview_hanghoa.CurrentRow.Cells["ThuongHieu"].Value.ToString();
            //txt_quocgia.Text = datagridview_hanghoa.CurrentRow.Cells["QuocGia"].Value.ToString();
            //txt_congdung.Text = datagridview_hanghoa.CurrentRow.Cells["CongDung"].Value.ToString();
            //txt_khoiluong.Text = datagridview_hanghoa.CurrentRow.Cells["KhoiLuong"].Value.ToString();
            //txt_sl.Text = datagridview_hanghoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            //txt_dgnhap.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            //txt_dgban.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            //txt_anh.Text = function.GetFieldValues("SELECT Anh FROM Hang WHERE Ma = N'" + txt_mahang.Text + "'");
            //pic.Image = Image.FromFile(txt_anh.Text);
            //txt_ghichu.Text = function.GetFieldValues("SELECT GhiChu FROM Hang WHERE MaHang = N'" + txt_mahang.Text + "'");
            //btn_sua.Enabled = true;
            //btn_xoa.Enabled = true;
            //btn_boqua.Enabled = true;
            string ma, mancc, matt, macn;
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_mahang.Focus();
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            // MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
            txt_mahang.Text = datagridview_hanghoa.CurrentRow.Cells["MaHang"].Value.ToString();
            txt_ten.Text = datagridview_hanghoa.CurrentRow.Cells["TenHang"].Value.ToString();
            ma = datagridview_hanghoa.CurrentRow.Cells["MaLoai"].Value.ToString();
            combo_maloai.Text = function.GetFieldValues("SELECT TenLoai FROM Loai WHERE MaLoai = N'" + ma + "'");
            txt_thuonghieu.Text = datagridview_hanghoa.CurrentRow.Cells["ThuongHieu"].Value.ToString();
            txt_quocgia.Text = datagridview_hanghoa.CurrentRow.Cells["QuocGia"].Value.ToString();
            txt_congdung.Text = datagridview_hanghoa.CurrentRow.Cells["CongDung"].Value.ToString();
            txt_khoiluong.Text = datagridview_hanghoa.CurrentRow.Cells["KhoiLuong"].Value.ToString();
            txt_sl.Text = datagridview_hanghoa.CurrentRow.Cells["SoLuong"].Value.ToString();
            txt_dgnhap.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txt_dgban.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();

            txt_anh.Text = function.GetFieldValues("SELECT Anh FROM Hang WHERE MaHang = N'" + txt_mahang.Text + "'");
            try
            {
                pic.Image = Image.FromFile(txt_anh.Text);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy ảnh", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                pic.Image = null;
            }
            //   txt_ghichu.Text = function.GetFieldValues("SELECT GhiChu FROM Hang WHERE MaNL = N'" + txt_mahang.Text + "'");
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_boqua.Enabled = true;

        }

        private void btn_open_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.InitialDirectory = "D:\\";
            dlgopen.FilterIndex = 3;
            dlgopen.Title = "Hãy chọn hình ảnh để hiển thị";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(dlgopen.FileName);
                txt_anh.Text = dlgopen.FileName;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_boqua.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            txt_mahang.Enabled = true;
            txt_mahang.Focus();
            //// Lấy mã hàng lớn nhất trong bảng hàng
            //if (function.Conn.State == ConnectionState.Closed)
            //{
            //    function.Conn.Open();
            //}
            //string query = "SELECT MAX(MaHang) FROM Hang";
            //SqlCommand command = new SqlCommand(query, function.Conn);
            //object result = command.ExecuteScalar();
            //if (result != DBNull.Value)
            //{
            //    int maxMH = Convert.ToInt32(result);
            //    // Tăng mã hàng lên 1 và hiển thị trong txtmh
            //    txt_mahang.Text = (maxMH + 1).ToString();
            //}
            //else
            //{
            //    // Nếu không có hàng nào trong bảng, gán mã hàng mặc định là 1
            //    txt_mahang.Text = "1";
            //}
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txt_mahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_mahang.Focus();
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (combo_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                combo_maloai.Focus();
                return;
            }
            // (MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
            if (txt_thuonghieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thương hiệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_thuonghieu.Focus();
                return;
            }
            if (txt_quocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quốc gia", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_quocgia.Focus();
                return;
            }
            if (txt_congdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_congdung.Focus();
                return;
            }
            if (txt_khoiluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập khối lượng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_khoiluong.Focus();
                return;
            }
            if (txt_sl.Text=="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng hàng ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_thuonghieu.Focus();
                return;
            }
            if (txt_dgnhap.Text == "0")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_dgnhap.Focus();
                return;
            }
            if (txt_dgban.Text == "0")
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_dgban.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_anh.Focus();
                return;
            }
           
            sql = "SELECT Mahang FROM Hang WHERE Mahang=N'" + txt_mahang.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mahang.Focus();
                txt_mahang.Text = "";
                return;
            }
            //sql =   "INSERT INTO Hang(MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) VALUES(N'" + txt_mahang.Text.Trim() +
            //        "',N'" + txt_ten.Text.Trim() + "',N'" + combo_maloai.SelectedValue.ToString() + "',N'" + txt_thuonghieu.Text.Trim() + "',N'" + txt_quocgia.Text + "',N'" + txt_congdung.Text +
            //        "',N'" + txt_khoiluong.Text + "',N'" + txt_sl.Text.Trim() + "',N'" + txt_dgnhap.Text.Trim() + "',N'" + txt_dgban.Text.Trim() + ",'" + txt_anh.Text + "',N'" + txt_ghichu.Text.Trim()+"')";
            //
            sql = " INSERT INTO Hang(MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) VALUES(N'" +
                   txt_mahang.Text.Trim() + "', N'" + txt_ten.Text.Trim() + "', N'" + combo_maloai.SelectedValue.ToString() + "', N'" +
               txt_thuonghieu.Text.Trim() + "', N'" + txt_quocgia.Text + "', N'" + txt_congdung.Text + "', N'" + txt_khoiluong.Text.Trim() +
               "', N'" + txt_sl.Text.Trim() + "', " + txt_dgnhap.Text.Trim() + ", " + txt_dgban.Text.Trim() +
               ", '" + txt_anh.Text.Trim() + "', N'" + txt_ghichu.Text.Trim() + "')";

            function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_boqua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (txt_mahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Hang WHERE MaHang=N'" + txt_mahang.Text + "'";
                function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //  (MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
            string sql;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                return;
            }
            if (txt_mahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (txt_ten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (combo_maloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại hàng", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                combo_maloai.Focus();
                return;
            }
            if (txt_thuonghieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thương hiệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
           
            if (txt_quocgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quốc gia", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_quocgia.Focus();
                return;
            }
            if (txt_congdung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập công dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_congdung.Focus();
                return;
            }
            if (txt_khoiluong.Text=="")
            {
                MessageBox.Show("Bạn phải nhập khối lượng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_khoiluong.Focus();
                return;
            }
            if (txt_sl.Text=="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng hàng ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_thuonghieu.Focus();
                return;
            }
            if (txt_dgnhap.Text=="0")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_dgnhap.Focus();
                return;
            }
            if (txt_dgban.Text == "0")
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_dgban.Focus();
                return;
            }
            if (txt_anh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_anh.Focus();
                return;
            }
            // MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, CongDung, KhoiLuong,SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu
            sql = "UPDATE Hang SET TenHang=N'" + txt_ten.Text.Trim().ToString() +
                "',MaLoai=N'" + combo_maloai.SelectedValue.ToString() +
                "',ThuongHieu=N'" + txt_thuonghieu.Text+
                "',QuocGia=N'" + txt_quocgia.Text +
                "',CongDung=N'" + txt_congdung.Text +
                "',KhoiLuong=N'" + txt_khoiluong.Text +
                "',SoLuong=N'" + txt_sl.Text +
                "',DonGiaNhap=N'" + txt_dgnhap.Text +
                "',DonGiaBan=N'" + txt_dgban.Text +
                "',Anh='" + txt_anh.Text +
                "',Ghichu=N'" + txt_ghichu.Text + "' WHERE MaHang=N'" + txt_mahang.Text + "'";
            function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btn_boqua.Enabled = false;

        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            //string sql;
            ////  tìm theo MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, , ,, DonGiaNhap, DonGiaBan, , 
            //if ((txt_mahang.Text == "") && (txt_ten.Text == "") && (combo_maloai.Text == "") && (txt_thuonghieu.Text == "") && (txt_quocgia.Text == "") && (txt_dgnhap.Text == "") && (txt_dgban.Text == ""))
            //{
            //    MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    return;
            //}
            //sql = "SELECT * FROM Hang WHERE 1=1";
            //if (txt_mahang.Text != "")
            //    sql = sql + " AND MaHang Like N'%" + txt_mahang.Text + "%'";
            //if (txt_ten.Text != "")
            //    sql = sql + " AND TenHang Like N'%" + txt_ten.Text + "%'";
            //if (combo_maloai.Text != "")
            //    sql = sql + " AND MaLoai Like N'%" + combo_maloai.SelectedValue + "%'";
            //if (txt_thuonghieu.Text != "")
            //    sql = sql + " AND ThuongHieu Like N'%" + txt_thuonghieu.Text + "%'";
            //if (txt_quocgia.Text != "")
            //    sql = sql + " AND QuocGia Like N'%" + txt_quocgia.Text + "%'";
            //if (txt_dgnhap.Text != "")
            //    sql = sql + " AND DonGiaNhap Like N'%" + txt_dgnhap.Text + "%'";
            //if (txt_dgban.Text != "")
            //  sql = sql + " AND DonGiaBan Like N'%" + txt_dgban.Text + "%'";
            //dt = function.GetDataToTable(sql);
            //if (dt.Rows.Count == 0)
            //    MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //else
            //    MessageBox.Show("Có " + dt.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //datagridview_hanghoa.DataSource = dt;
            //ResetValues();
            //btn_boqua.Enabled = true;
            string sql;

            // Tìm kiếm theo nhiều trường: MaHang, TenHang, MaLoai, ThuongHieu, QuocGia, DonGiaNhap, DonGiaBan
            if (txt_tk.Text == "Nhập từ khóa để tìm kiếm")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_tk.Focus();
                return;
            }

            sql = "SELECT * FROM Hang as a join Loai as b on a.MaLoai=b.MaLoai WHERE 1=1 ";

            if (txt_tk.Text != "Nhập từ khóa để tìm kiếm")
            {
                string[] searchKeys = txt_tk.Text.Trim().Split(' '); // Chia nhỏ từ khóa thành các từ riêng lẻ

                foreach (string searchKey in searchKeys)
                {
                    if (!string.IsNullOrEmpty(searchKey))
                    {
                        sql += " AND (a.MaHang LIKE N'%" + searchKey + "%' OR a.CongDung LIKE N'%" + searchKey+ "%' OR a.TenHang LIKE N'%" + searchKey + "%' OR b.TenLoai LIKE N'%" + searchKey + "%' OR a.ThuongHieu LIKE N'%" + searchKey + "%' OR a.QuocGia LIKE N'%" + searchKey + "%' OR a.DonGiaNhap LIKE N'%" + searchKey + "%' OR a.DonGiaBan LIKE N'%" + searchKey + "%')";
                    }
                }
            }

            dt = function.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Có " + dt.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            datagridview_hanghoa.DataSource = dt;
            ResetValues();
            btn_boqua.Enabled = true;



        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_boqua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            txt_mahang.Enabled = false;
            Load_DataGridView();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát form Hàng hóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
        }

       

        private void txt_mahang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_ten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void combo_maloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_thuonghieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_quocgia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_congdung_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_khoiluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_anh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void combox_sx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_sl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_dgnhap_KeyUp(object sender, KeyEventArgs e)
        {
            // tính giá bán là 110% giá nhập rồi hiển thị lên txt_dgban
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_dgnhap.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_dgnhap.Focus();
                    return;
                }
                else
                {
                    double gianhap, giaban;
                    gianhap = Convert.ToDouble(txt_dgnhap.Text);
                    giaban = gianhap * 1.1;
                    txt_dgban.Text = giaban.ToString();
                }
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_dgban_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        //private void combox_sx_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.combox_sx.SelectedItem != null)
        //    {
        //        // Lấy giá trị được chọn trong ComboBox
        //        string selectedItem = this.combox_sx.SelectedItem.ToString();

        //        // Sắp xếp dữ liệu trong DataGridView theo giá trị được chọn
        //        switch (selectedItem)
        //        {
        //            //   txt_dgban.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
        //            case "Mã hàng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["MaHang"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            //case "Giá":
        //            //    this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["Giá"], ListSortDirection.Ascending);
        //            //    break;

        //            case "Số lượng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["SoLuong"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Khối lượng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["KhoiLuong"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Đơn giá nhập":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaNhap"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Đơn giá bán":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaBan"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            default:
        //                // Xử lý trường hợp không có giá trị nào được chọn
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        // Hiển thị thông báo yêu cầu người dùng chọn item
        //        MessageBox.Show("Vui lòng chọn item trong ComboBox trước khi sắp xếp!");
        //    }
        //}

      

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txt_tk.Text == "Nhập từ khóa để tìm kiếm")
            {
                txt_tk.Text = "";
                txt_tk.ForeColor = Color.Gray; // Đặt màu chữ khi nhập
            }
        }

        private void btn_sx_Click_1(object sender, EventArgs e)
        {
            
            if (this.combox_sx.SelectedItem != null)
            {
                // Lấy giá trị được chọn trong ComboBox
                string selectedItem = this.combox_sx.SelectedItem.ToString();

                // Sắp xếp dữ liệu trong DataGridView theo giá trị được chọn
                switch (selectedItem)
                {
                    //   txt_dgban.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
                    case "Mã hàng":
                        this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["MaHang"], ListSortDirection.Ascending);
                        MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    //case "Giá":
                    //    this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["Giá"], ListSortDirection.Ascending);
                    //    break;

                    case "Số lượng":
                        this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["SoLuong"], ListSortDirection.Ascending);
                        MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    case "Khối lượng":
                        this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["KhoiLuong"], ListSortDirection.Ascending);
                        MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    
                    case "Đơn giá bán":
                        this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaBan"], ListSortDirection.Ascending);
                        MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    case "Đơn giá nhập ":
                        this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaNhap"], ListSortDirection.Ascending);
                        MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        break;
                    default:
                        // Xử lý trường hợp không có giá trị nào được chọn
                        break;
                }
            }
            else
            {
                // Hiển thị thông báo yêu cầu người dùng chọn item
                MessageBox.Show("Vui lòng chọn item trong ComboBox trước khi sắp xếp!");
            }

        }

        private void combox_sx_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        //private void btn_sx_Click(object sender, EventArgs e)
        //{
        //    if (this.combox_sx.SelectedItem != null)
        //    {
        //        // Lấy giá trị được chọn trong ComboBox
        //        string selectedItem = this.combox_sx.SelectedItem.ToString();

        //        // Sắp xếp dữ liệu trong DataGridView theo giá trị được chọn
        //        switch (selectedItem)
        //        {
        //            //   txt_dgban.Text = datagridview_hanghoa.CurrentRow.Cells["DonGiaBan"].Value.ToString();
        //            case "Mã hàng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["MaHang"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            //case "Giá":
        //            //    this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["Giá"], ListSortDirection.Ascending);
        //            //    break;

        //            case "Số lượng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["SoLuong"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Khối lượng":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["KhoiLuong"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Đơn giá nhập":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaNhap"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            case "Đơn giá bán":
        //                this.datagridview_hanghoa.Sort(this.datagridview_hanghoa.Columns["DonGiaBan"], ListSortDirection.Ascending);
        //                MessageBox.Show("Sắp xếp thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //                break;
        //            default:
        //                // Xử lý trường hợp không có giá trị nào được chọn
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        // Hiển thị thông báo yêu cầu người dùng chọn item
        //        MessageBox.Show("Vui lòng chọn item trong ComboBox trước khi sắp xếp!");
        //    }
        //}
    }
}
