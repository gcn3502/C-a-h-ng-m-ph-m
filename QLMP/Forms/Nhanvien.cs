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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            function.Connect();
            btnthem.Size = new Size(80, 30);
            btnxoa.Size = new Size(80, 30);
            btnluu.Size = new Size(80, 30);
            btnsua.Size = new Size(80, 30);
            btntimkiem.Size = new Size(100, 30);
            btndong.Size = new Size(80, 30);
            btnboqua.Size = new Size(90, 30);

            DatThuocTinhChoNnut(btnthem, Properties.Resources.add_icon);
            DatThuocTinhChoNnut(btnxoa, Properties.Resources.icons8_delete_20);
            DatThuocTinhChoNnut(btnluu, Properties.Resources.icons8_save_16);
            DatThuocTinhChoNnut(btnsua, Properties.Resources.sua_icon);
            DatThuocTinhChoNnut(btntimkiem, Properties.Resources.icons8_search_20);
            DatThuocTinhChoNnut(btnboqua, Properties.Resources.boqua_icon);
            DatThuocTinhChoNnut(btndong, Properties.Resources.dong_icon);
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            load_datagridview();
            function.Fillcombo("Select MaCV,TenCV from CongViec", cbocongviec, "MaCV", "TenCV");
            cbocongviec.SelectedIndex = -1;
            function.Fillcombo("Select MaTK,TenTK from TaiKhoan", cbotaikhoan, "MaTK", "TenTK");
            cbotaikhoan.SelectedIndex = -1;
            ResetValues();
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
        private void ResetValues()
        {
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            cbocongviec.Text = "";
            mskngaysinh.Text = "";
            mskdienthoai.Text = "";
            mskngayvaolam.Text = "";
            chknam.Checked = false;
            chknu.Checked = false;
            chknam.Enabled = true;
            chknu.Enabled = true;
            cbotaikhoan.Text = "";
            txtanh.Text = "";
            picanh.Image = null;
        }

        private void chknam_CheckedChanged(object sender, EventArgs e)
        {
            if (chknam.Checked)
            {
                chknu.Checked = false;
                chknu.Enabled = false;
            }
            else
            {
                chknu.Enabled = true;
            }
        }

        private void chknu_CheckedChanged(object sender, EventArgs e)
        {

            if (chknu.Checked)
            {
                chknam.Checked = false;
                chknam.Enabled = false;
            }
            else
            {
                chknam.Enabled = true;
            }
        }
        DataTable tblnv;
        private void load_datagridview()
        {
            string sql;
            sql = "select MaNV,TenNV,GioiTinh,NgaySinh,NgayVaoLam, DiaChi,SDT, MaCV,MaTK from NhanVien";
            tblnv = function.GetDataToTable(sql);
            dgridnhanvien.DataSource = tblnv;
            dgridnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgridnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgridnhanvien.Columns[2].HeaderText = "Giới tính";
            dgridnhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgridnhanvien.Columns[4].HeaderText = "Ngày vào làm";
            dgridnhanvien.Columns[5].HeaderText = "Địa chỉ";
            dgridnhanvien.Columns[6].HeaderText = "SDT";
            dgridnhanvien.Columns[7].HeaderText = "Mã công việc";
            dgridnhanvien.Columns[8].HeaderText = "Tài khoản";
            dgridnhanvien.Columns[0].Width = 120;
            dgridnhanvien.Columns[1].Width = 120;
            dgridnhanvien.Columns[2].Width = 90;
            dgridnhanvien.Columns[3].Width = 100;
            dgridnhanvien.Columns[4].Width = 130;
            dgridnhanvien.Columns[5].Width = 100;
            dgridnhanvien.Columns[6].Width = 100;
            dgridnhanvien.Columns[7].Width = 120;
            dgridnhanvien.Columns[8].Width = 100;
            dgridnhanvien.AllowUserToAddRows = false;
            dgridnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgridnhanvien_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                return;
            }
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtmanv.Text = dgridnhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
            txttennhanvien.Text = dgridnhanvien.CurrentRow.Cells["TenNV"].Value.ToString();

            mskngaysinh.Text = dgridnhanvien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            mskngayvaolam.Text = dgridnhanvien.CurrentRow.Cells["NgayVaoLam"].Value.ToString();
            txtdiachi.Text = dgridnhanvien.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskdienthoai.Text = dgridnhanvien.CurrentRow.Cells["SDT"].Value.ToString();

            ma = dgridnhanvien.CurrentRow.Cells["MaCV"].Value.ToString();
            cbocongviec.Text = function.GetFieldValues("SELECT TenCV FROM CongViec WHERE MaCV = N'" + ma + "'");

            ma = dgridnhanvien.CurrentRow.Cells["MaTK"].Value.ToString();
            cbotaikhoan.Text = function.GetFieldValues("SELECT TenTK FROM TaiKhoan WHERE MaTK = N'" + ma + "'");

            txtanh.Text = function.GetFieldValues("SELECT Anh FROM NhanVien WHERE MaNV = N'" + txtmanv.Text + "'");
            picanh.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                if (!string.IsNullOrEmpty(txtanh.Text) && System.IO.File.Exists(txtanh.Text))
                {
                    picanh.Image = Image.FromFile(txtanh.Text);
                }
                else
                {
                    picanh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picanh.Image = null;
            }
            string gioitinh = dgridnhanvien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            if (gioitinh == "Nam")
            {
                chknam.Checked = true;
                chknam.Enabled = true;
                chknu.Checked = false;
                chknu.Enabled = false;
            }
            else if (gioitinh == "Nữ")
            {
                chknam.Checked = false;
                chknam.Enabled = false;
                chknu.Checked = true;
                chknu.Enabled = true;
            }

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG| *.jpg|GIF|*.gif|Allfile|*.*";
            ofd.InitialDirectory = "D:\\";
            ofd.FilterIndex = 3;
            ofd.Title = "Hay chon hinh anh de hien thi";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picanh.SizeMode = PictureBoxSizeMode.Zoom;
                picanh.Image = Image.FromFile(ofd.FileName);
                txtanh.Text = ofd.FileName;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = false;
            btnluu.Enabled = true;
            txtmanv.Text = function.CreateKeyNhanVien("NV");
            txtmanv.Enabled = false;
            btnboqua.Enabled = true;
            ResetValues();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtmanv.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }

            if (cbocongviec.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbocongviec.Focus();
                return;
            }

            if (chknam.Checked)
            {
                gt = "Nam";
            }
            else if (chknu.Checked)
            {
                gt = "Nữ";
            }
            else
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }

            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }

            if (mskngaysinh.Text == "   /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }

            if (!function.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }

            if (mskngayvaolam.Text == "   /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }

            if (!function.IsDate(mskngayvaolam.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }

            if (cbocongviec.SelectedValue == null || cbotaikhoan.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải chọn công việc và tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "UPDATE NhanVien SET TenNV = N'" + txttennhanvien.Text.Trim() + "', GioiTinh = N'" + gt + "', NgaySinh = '" + function.ConvertDateTime(mskngaysinh.Text) + "', NgayVaoLam = '" + function.ConvertDateTime(mskngayvaolam.Text) + "', DiaChi = N'" + txtdiachi.Text.Trim() + "', SDT = '" + mskdienthoai.Text.Trim() + "', MaCV = N'" + cbocongviec.SelectedValue + "', MaTK = N'" + cbotaikhoan.SelectedValue + "', Anh = N'" + txtanh.Text.Trim() + "' WHERE MaNV = N'" + txtmanv.Text.Trim() + "'";
            Class.function.RunSql(sql);
            MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            load_datagridview();
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu ở cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete NhanVien where MaNV = N'" + txtmanv.Text + "'";
                function.RunSql(sql);
                load_datagridview();
                ResetValues();
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql, gt;


            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }
            if (cbocongviec.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbocongviec.Focus();
                return;
            }
            if (chknam.Checked)
            {
                gt = "Nam";
            }
            else if (chknu.Checked)
            {
                gt = "Nữ";
            }
            else
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }

            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -   ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (mskngaysinh.Text == "   /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!function.IsDate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (mskngayvaolam.Text == "   /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!function.IsDate(mskngayvaolam.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày vào làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (cbocongviec.SelectedValue == null || cbotaikhoan.SelectedValue == null)
            {
                MessageBox.Show("Bạn phải chọn công việc và tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "INSERT INTO NhanVien(MaNV, TenNV, GioiTinh,NgaySinh, NgayVaoLam, DiaChi, SDT, MaCV, MaTK, Anh) " + "VALUES (N'" + txtmanv.Text.Trim() + "', N'" + txttennhanvien.Text.Trim() + "',N'" + gt + "','" + function.ConvertDateTime(mskngaysinh.Text) + "', '" + function.ConvertDateTime(mskngayvaolam.Text) + "', N'" + txtdiachi.Text.Trim() + "', '" + mskdienthoai.Text.Trim() + "', N'" + cbocongviec.SelectedValue + "', N'" + cbotaikhoan.SelectedValue + "', N'" + txtanh.Text.Trim() + "')";
            function.RunSql(sql);
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            load_datagridview();
            ResetValues();

            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btntimkiem.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
            btnboqua.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {

            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btntimkiem.Enabled = true;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            string sql;
            if (txttimkiem.Text.Trim() == "" || txttimkiem.Text.Trim() == "Hãy nhập từ khóa tìm kiếm")
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "SELECT * FROM NhanVien WHERE 1=1";

            if (!string.IsNullOrEmpty(txttimkiem.Text) && txttimkiem.Text.Trim() != "Hãy nhập từ khóa tìm kiếm")
            {
                sql += " AND (MaNV LIKE N'%" + txttimkiem.Text.Trim() + "%' OR TenNV LIKE N'%" + txttimkiem.Text.Trim() + "%')";
            }

            DataTable tblResult = function.GetDataToTable(sql);
            if (tblResult.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblResult.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgridnhanvien.DataSource = tblResult;
            ResetValues();

        }

        private void mskngayvaolam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void cbotaikhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void cbocongviec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void mskdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void mskngaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void txttimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void grpgioitinh_Enter(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttennhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgridnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskngaysinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskdienthoai_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskngayvaolam_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbotaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbocongviec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void lblngayvaolam_Click(object sender, EventArgs e)
        {

        }

        private void lbldiachi_Click(object sender, EventArgs e)
        {

        }

        private void lbldienthoai_Click(object sender, EventArgs e)
        {

        }

        private void lblcongviec_Click(object sender, EventArgs e)
        {

        }

        private void lbltaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picanh_Click(object sender, EventArgs e)
        {

        }

        private void gplnhanvien_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
