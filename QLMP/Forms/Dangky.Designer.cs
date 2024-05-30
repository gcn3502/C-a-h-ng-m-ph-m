using QLMP.Forms;

namespace QLMP.FORMS
{
    partial class dangky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ten = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_xacnhanmk = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Label();
            this.chbox_hienthi = new System.Windows.Forms.CheckBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_xacnhan = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_dky = new QLMP.Forms.RJButton();
            this.linklb_dacotk = new System.Windows.Forms.LinkLabel();
            this.pic = new System.Windows.Forms.Panel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.rjButton1 = new QLMP.Forms.RJButton();
            this.SuspendLayout();
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(20, 163);
            this.lb_ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(94, 19);
            this.lb_ten.TabIndex = 0;
            this.lb_ten.Text = "Tên tài khoản:";
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.Location = new System.Drawing.Point(20, 250);
            this.lb_mk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(70, 19);
            this.lb_mk.TabIndex = 1;
            this.lb_mk.Text = "Mật khẩu:";
            // 
            // lb_xacnhanmk
            // 
            this.lb_xacnhanmk.AutoSize = true;
            this.lb_xacnhanmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xacnhanmk.Location = new System.Drawing.Point(20, 290);
            this.lb_xacnhanmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_xacnhanmk.Name = "lb_xacnhanmk";
            this.lb_xacnhanmk.Size = new System.Drawing.Size(145, 19);
            this.lb_xacnhanmk.TabIndex = 2;
            this.lb_xacnhanmk.Text = "Xác nhận lại mật khẩu:";
            // 
            // btn_email
            // 
            this.btn_email.AutoSize = true;
            this.btn_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.Location = new System.Drawing.Point(20, 206);
            this.btn_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(45, 19);
            this.btn_email.TabIndex = 3;
            this.btn_email.Text = "Email:";
            // 
            // chbox_hienthi
            // 
            this.chbox_hienthi.AutoSize = true;
            this.chbox_hienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_hienthi.Location = new System.Drawing.Point(53, 331);
            this.chbox_hienthi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbox_hienthi.Name = "chbox_hienthi";
            this.chbox_hienthi.Size = new System.Drawing.Size(133, 23);
            this.chbox_hienthi.TabIndex = 4;
            this.chbox_hienthi.Text = "Hiển thị mật khẩu";
            this.chbox_hienthi.UseVisualStyleBackColor = true;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(166, 163);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(138, 20);
            this.txt_ten.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(166, 250);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(138, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_xacnhan
            // 
            this.txt_xacnhan.Location = new System.Drawing.Point(166, 290);
            this.txt_xacnhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_xacnhan.Name = "txt_xacnhan";
            this.txt_xacnhan.Size = new System.Drawing.Size(138, 20);
            this.txt_xacnhan.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(166, 206);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(138, 20);
            this.txt_email.TabIndex = 8;
            // 
            // btn_dky
            // 
            this.btn_dky.BackColor = System.Drawing.Color.Blue;
            this.btn_dky.FlatAppearance.BorderSize = 0;
            this.btn_dky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dky.ForeColor = System.Drawing.Color.White;
            this.btn_dky.Location = new System.Drawing.Point(123, 518);
            this.btn_dky.Name = "btn_dky";
            this.btn_dky.Size = new System.Drawing.Size(150, 40);
            this.btn_dky.TabIndex = 9;
            this.btn_dky.Text = "Đăng ký";
            this.btn_dky.UseVisualStyleBackColor = false;
            this.btn_dky.Click += new System.EventHandler(this.btn_dky_Click);
            // 
            // linklb_dacotk
            // 
            this.linklb_dacotk.AutoSize = true;
            this.linklb_dacotk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_dacotk.LinkColor = System.Drawing.Color.Red;
            this.linklb_dacotk.Location = new System.Drawing.Point(96, 372);
            this.linklb_dacotk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklb_dacotk.Name = "linklb_dacotk";
            this.linklb_dacotk.Size = new System.Drawing.Size(137, 19);
            this.linklb_dacotk.TabIndex = 10;
            this.linklb_dacotk.TabStop = true;
            this.linklb_dacotk.Text = "Bạn đã có tài khoản?";
            // 
            // pic
            // 
            this.pic.BackgroundImage = global::QLMP.Properties.Resources.mypham3;
            this.pic.Location = new System.Drawing.Point(322, 1);
            this.pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(347, 472);
            this.pic.TabIndex = 11;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(94, 68);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(111, 31);
            this.lb_welcome.TabIndex = 12;
            this.lb_welcome.Text = "Welcome";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Blue;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(100, 417);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(131, 31);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.Text = "Đăng ký";
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(669, 473);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.linklb_dacotk);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_xacnhan);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.chbox_hienthi);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.lb_xacnhanmk);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_ten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "dangky";
            this.Text = "dangky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_xacnhanmk;
        private System.Windows.Forms.Label btn_email;
        private System.Windows.Forms.CheckBox chbox_hienthi;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_xacnhan;
        private System.Windows.Forms.TextBox txt_email;
        private RJButton btn_dky;
        private System.Windows.Forms.LinkLabel linklb_dacotk;
        private System.Windows.Forms.Panel pic;
        private System.Windows.Forms.Label lb_welcome;
        private RJButton rjButton1;
    }
}