﻿using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLMP.Forms
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void chbox_hienthi_Click_1(object sender, EventArgs e)
        {
            if (chbox_hienthi.Checked)
            {
                txt_mk.PasswordChar = (char)0;
                txt_xacnhan.PasswordChar = (char)0;
            }
            else
            {
                txt_mk.PasswordChar = '*';
                txt_xacnhan.PasswordChar = '*';
            }
        }

        private void linklb_dacotk_Click(object sender, EventArgs e)
        {
            this.Hide();
            login dnhap = new login();
            dnhap.Show();
        }
        private bool IsValidEmail(string email)
        {
            const string regex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            return Regex.Match(email, regex).Success;
        }

        private void btn_dky_Click(object sender, EventArgs e)
        {

            // ktra input nhập vào rỗng?
            if (txt_tk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_tk.Focus();
                return;
            }
            //if (txt_email.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    txt_email.Focus();
            //    return;
            //}
            //// ktra email hợp lệ?
            //string email = txt_email.Text;
            //bool isValid = IsValidEmail(email);

            //if (!isValid)
            //{
            //    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    txt_email.Text = " ";
            //    return;
            //}
            //
            if (txt_mk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_mk.Focus();
                return;
            }
            if (txt_xacnhan.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_xacnhan.Focus();
                return;
            }
            // ktra mk trufg xác nhận mk ?
            if (txt_mk.Text != txt_xacnhan.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txt_mk.Focus();
                txt_mk.Text = " ";
                txt_xacnhan.Text = " ";
                return;
            }



            // mk >8 ký tự tên > 6 ktu
            //if(txt_mk.Text.Length <8 )
            //  {
            //      MessageBox.Show("Mật khẩu phải lớn hơn 8 ký tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //      return;
            //  }
            //if(txt_tk.Text.Length < 6)
            //  {
            //      MessageBox.Show("Tên tài khoản phải lớn hơn 6 ký tự", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //      return;
            //  }

        //// ktra tk đã tồn tại 
       


            else
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-59G1UB6L\\LANANH;Initial Catalog=QLMP;Integrated Security=True;Encrypt=False");
                con.Open();

                //check tk đã tồn tại chưa
                string sql2 = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTK=@Username";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.Parameters.AddWithValue("@Username", txt_tk.Text);
                int count1 = (int)cmd2.ExecuteScalar();
                if (count1 > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    txt_tk.Text = "";
                    txt_tk.Focus();
                    return;
                }

                // hiển thị MessageBox
                

                // lấy số lượng bản ghi từ bảng Tài Khoản và gán vào biến count
                string sql1 = "SELECT COUNT(*) FROM TaiKhoan";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                int count = (int)cmd1.ExecuteScalar();

                string sql;
                sql = "INSERT INTO TaiKhoan (MaTK,TenTK,MatKhau) VALUES(@MATK,@Username,@Password)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Username", txt_tk.Text);
                cmd.Parameters.AddWithValue("@Password", txt_mk.Text);
                cmd.Parameters.AddWithValue("@MATK", count + 1);
           //     cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Hide();
                login dnhap = new login();
                dnhap.ShowDialog();
                
                return;
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            txt_tk.Focus();
            txt_mk.Focus();
       //     txt_email.Focus();
            txt_xacnhan.Focus();

        }

        private void txt_tk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_mk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
