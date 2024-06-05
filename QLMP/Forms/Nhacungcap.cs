using QLMP.Class;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLMP.Forms
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NCungCap_Load(object sender, EventArgs e)
        {
            function.Connect();
            txt_mancc.Enabled = false;
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            Load_DataGridView();
           
          
            ResetValues();
        }
        DataTable dt;
        private void Load_DataGridView()
        {
            // MaNCC, TenNCC,DiaChi,Sodienthoai,Email,Ghichu
            string sql;
            sql = "SELECT MaNCC, TenNCC, DiaChi, SDT FROM NhaCungCap";
            dt = function.GetDataToTable(sql);
            datagridview_nhacungcap.DataSource = dt;
            datagridview_nhacungcap.Columns[0].HeaderText = "Mã nhà cung cấp";
            datagridview_nhacungcap.Columns[1].HeaderText = "Tên nhà cung cấp";
            datagridview_nhacungcap.Columns[2].HeaderText = "Địa chỉ";
            datagridview_nhacungcap.Columns[3].HeaderText = "Số điện thoại";
           
            datagridview_nhacungcap.AllowUserToAddRows = false;
            // auto size datagridview
            datagridview_nhacungcap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridview_nhacungcap.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            
            txt_tenncc.Text = "";
            txt_dc.Text = "";
            mtxt_sdt.Text = "(   )    -";
        }

        private void datagridview_nhacungcap_Click(object sender, EventArgs e)
        {
            string ma, mancc, matt, macn;
            if (btn_them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_mancc.Focus();
                return;
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // MaNCC, TenNCC,DiaChi,Sodienthoai,Email,Ghichu
            txt_mancc.Text = datagridview_nhacungcap.CurrentRow.Cells["MaNCC"].Value.ToString();
            txt_tenncc.Text = datagridview_nhacungcap.CurrentRow.Cells["TenNCC"].Value.ToString();
            txt_dc.Text = datagridview_nhacungcap.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtxt_sdt.Text = datagridview_nhacungcap.CurrentRow.Cells["SDT"].Value.ToString();
           
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_huy.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            ResetValues();
            //  txt_manl.Enabled = true;
            txt_mancc.Focus();
            // Lấy mã sản phẩm lớn nhất trong bảng sản phẩm
            if (function.Conn.State == ConnectionState.Closed)
            {
                function.Conn.Open();
            }
            string query = "SELECT count(*) FROM NhaCungCap";
            SqlCommand command = new SqlCommand(query, function.Conn);
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int maxMLSP = Convert.ToInt32(result);
                // Tăng mã sản phẩm lên 1 và hiển thị trong txtmasp
                txt_mancc.Text = ("NCC" + (maxMLSP + 1)).ToString();
            }
            else
            {
                // Nếu không có sản phẩm nào trong bảng, gán mã sản phẩm mặc định là 1
                txt_mancc.Text = "1";
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string sql;
            //if (txt_mancc.Text == "")
            //{
            //    MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    txt_mancc.Focus();
            //    return;
            //}
            
            if (txt_tenncc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txt_tenncc.Focus();
                return;
            }

            if (txt_dc.Text.Trim() == "0")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_dc.Focus();
                return;
            }

            if (mtxt_sdt.Text.Trim() == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxt_sdt.Focus();
                return;
            }


            //mtxt_sdt.Text = "(   )    -";


            // MaNCC, TenNCC,DiaChi,Sodienthoai,Email,Ghichu, NhaCungCap

            sql = "SELECT MaNCC FROM NhaCungCap WHERE MaNCC=N'" + txt_mancc.Text.Trim() + "'";
            if (function.CheckKey(sql))
            {
                MessageBox.Show("Mã này đã tồn tại, vui lòng nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mancc.Focus();
                txt_mancc.Text = "";
                return;
            }


            sql = "INSERT INTO NhaCungCap (MaNCC,TenNCC,DiaChi,SDT) " +
                "VALUES('" + txt_mancc.Text.Trim() + "',N'" + txt_tenncc.Text.Trim() + "',N'" +
                txt_dc.Text.Trim() + "','" + new string(mtxt_sdt.Text.Where(char.IsDigit).ToArray()) + "')";

            function.ExecuteQuery(sql);
            Load_DataGridView();
            ResetValues();
            btn_xoa.Enabled = true;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txt_mancc.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            if (txt_mancc.Text == "")
            {
                MessageBox.Show("bạn chưa chọn bản ghi nào", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                return;
            }
            string sql;

            string sdt = mtxt_sdt.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");


            sql = "UPDATE NhaCungCap SET TenNCC=N'" + txt_tenncc.Text.Trim().ToString() +
                "',DiaChi=N'" + txt_dc.Text.Trim().ToString() + "',SDT=N'" +
                sdt + "' WHERE MaNCC=N'" + txt_mancc.Text + "'";


            function.ExecuteQuery(sql);
            Load_DataGridView();
            ResetValues();

            btn_huy.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txt_mancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhaCungCap WHERE MaNCC=N'" + txt_mancc.Text + "'";
                function.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();

            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_huy.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_luu.Enabled = false;
            txt_mancc.Enabled = false;
            Load_DataGridView();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            string sql;
            //if ((txt_mancc.Text == "") && (txt_tenncc.Text == "") && (txt_dc.Text == "") && (txt_email.Text == "") )
            //{
            //    MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    return;
            //}
            // MaNCC, TenNCC,DiaChi,Sodienthoai,Email,Ghichu, NhaCungCap
            sql = "SELECT * FROM NhaCungCap WHERE 1=1";
            if (txt_mancc.Text != "")
                sql = sql + " AND MaNCC Like N'%" + txt_mancc.Text + "%'";

            if (txt_tenncc.Text != "")
                sql = sql + " AND TenNCC Like N'%" + txt_tenncc.Text + "%'";
            if (txt_dc.Text != "")
                sql = sql + " AND DiaChi Like N'%" + txt_dc.Text + "%'";
            if (mtxt_sdt.Text != "(   )    -")
            {
                // Chuyển đổi masktextbox về chuỗi bình thương(loại bỏ kí tự của masktextbox phone)
                string sdt = mtxt_sdt.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                sql = sql + " AND Sodienthoai Like N'%" + sdt + "%'";
            }
            dt = function.GetDataToTable(sql);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + dt.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            datagridview_nhacungcap.DataSource = dt;
            ResetValues();
            btn_huy.Enabled = true;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát form Nhà cung cấp?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void txt_mancc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_tenncc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_dc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mtxt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void txt_email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
