using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLMP.FORMS;

namespace QLMP.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void linklb_acc_Click(object sender, EventArgs e)
        {
            dangky DK = new dangky();
            DK.Show();
            this.Close();
        }

        private void linklb_taotk_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            registration dky = new registration();
            dky.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1BG474C;Initial Catalog=.net;Integrated Security=True;Encrypt=False");
            con.Open();
            string sql;
            sql = "SELECT * FROM TaiKhoan WHERE TenTk=@Username AND MatKhau=@Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Username", txt_tk.Text);
            cmd.Parameters.AddWithValue("@Password", txt_mk.Text);

            // lấy bản ghi từ câu lệnh select
            SqlDataReader dta = cmd.ExecuteReader();

            if (dta.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                // lấy column role từ bảng tài khoản
                int role = (int)dta["role"];
                if(role == 0) role = 0;
                Home h = new Home(role);
                h.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_tk.Text = "";
                txt_mk.Text = "";
                txt_tk.Focus();
            }

        }

        private void chbox_hienthi_Click_1(object sender, EventArgs e)
        {
            if (chbox_hienthi.Checked)
            {
                txt_mk.PasswordChar = (char)0;
            }
            else
            {
                txt_mk.PasswordChar = '*';
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_tk.Focus();
            txt_mk.Focus();
        }

        private void txt_tk_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
