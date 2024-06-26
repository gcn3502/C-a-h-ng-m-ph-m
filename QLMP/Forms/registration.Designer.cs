﻿namespace QLMP.Forms
{
    partial class registration
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
            this.components = new System.ComponentModel.Container();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.Panel();
            this.linklb_dacotk = new System.Windows.Forms.LinkLabel();
            this.txt_xacnhan = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.chbox_hienthi = new System.Windows.Forms.CheckBox();
            this.lb_xacnhanmk = new System.Windows.Forms.Label();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_dky = new QLMP.Forms.RJButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(103, 67);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(111, 31);
            this.lb_welcome.TabIndex = 25;
            this.lb_welcome.Text = "Welcome";
            // 
            // pic
            // 
            this.pic.BackgroundImage = global::QLMP.Properties.Resources.mypham3;
            this.pic.Location = new System.Drawing.Point(314, -1);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(347, 472);
            this.pic.TabIndex = 24;
            // 
            // linklb_dacotk
            // 
            this.linklb_dacotk.AutoSize = true;
            this.linklb_dacotk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_dacotk.LinkColor = System.Drawing.Color.Red;
            this.linklb_dacotk.Location = new System.Drawing.Point(86, 430);
            this.linklb_dacotk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linklb_dacotk.Name = "linklb_dacotk";
            this.linklb_dacotk.Size = new System.Drawing.Size(137, 19);
            this.linklb_dacotk.TabIndex = 23;
            this.linklb_dacotk.TabStop = true;
            this.linklb_dacotk.Text = "Bạn đã có tài khoản?";
            this.linklb_dacotk.Click += new System.EventHandler(this.linklb_dacotk_Click);
            // 
            // txt_xacnhan
            // 
            this.txt_xacnhan.Location = new System.Drawing.Point(164, 244);
            this.txt_xacnhan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_xacnhan.Name = "txt_xacnhan";
            this.txt_xacnhan.PasswordChar = '*';
            this.txt_xacnhan.Size = new System.Drawing.Size(138, 20);
            this.txt_xacnhan.TabIndex = 20;
            this.toolTip4.SetToolTip(this.txt_xacnhan, "Vui lòng nhập lại mật khẩu");
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(164, 194);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(138, 20);
            this.txt_mk.TabIndex = 19;
            this.toolTip3.SetToolTip(this.txt_mk, "Vui lòng nhập mật khẩu");
            this.txt_mk.TextChanged += new System.EventHandler(this.txt_mk_TextChanged);
            this.txt_mk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mk_KeyUp);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(164, 142);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(138, 20);
            this.txt_tk.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txt_tk, "Vui lòng nhập tên tài khoản");
            this.txt_tk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tk_KeyUp);
            // 
            // chbox_hienthi
            // 
            this.chbox_hienthi.AutoSize = true;
            this.chbox_hienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_hienthi.Location = new System.Drawing.Point(164, 332);
            this.chbox_hienthi.Margin = new System.Windows.Forms.Padding(2);
            this.chbox_hienthi.Name = "chbox_hienthi";
            this.chbox_hienthi.Size = new System.Drawing.Size(133, 23);
            this.chbox_hienthi.TabIndex = 17;
            this.chbox_hienthi.Text = "Hiển thị mật khẩu";
            this.chbox_hienthi.UseVisualStyleBackColor = true;
            this.chbox_hienthi.Click += new System.EventHandler(this.chbox_hienthi_Click_1);
            // 
            // lb_xacnhanmk
            // 
            this.lb_xacnhanmk.AutoSize = true;
            this.lb_xacnhanmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xacnhanmk.Location = new System.Drawing.Point(17, 244);
            this.lb_xacnhanmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_xacnhanmk.Name = "lb_xacnhanmk";
            this.lb_xacnhanmk.Size = new System.Drawing.Size(145, 19);
            this.lb_xacnhanmk.TabIndex = 15;
            this.lb_xacnhanmk.Text = "Xác nhận lại mật khẩu:";
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.Location = new System.Drawing.Point(17, 194);
            this.lb_mk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(70, 19);
            this.lb_mk.TabIndex = 14;
            this.lb_mk.Text = "Mật khẩu:";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(17, 142);
            this.lb_ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(94, 19);
            this.lb_ten.TabIndex = 13;
            this.lb_ten.Text = "Tên tài khoản:";
            // 
            // btn_dky
            // 
            this.btn_dky.BackColor = System.Drawing.Color.Blue;
            this.btn_dky.FlatAppearance.BorderSize = 0;
            this.btn_dky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dky.ForeColor = System.Drawing.Color.White;
            this.btn_dky.Location = new System.Drawing.Point(90, 378);
            this.btn_dky.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dky.Name = "btn_dky";
            this.btn_dky.Size = new System.Drawing.Size(112, 32);
            this.btn_dky.TabIndex = 22;
            this.btn_dky.Text = "Đăng ký";
            this.btn_dky.UseVisualStyleBackColor = false;
            this.btn_dky.Click += new System.EventHandler(this.btn_dky_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 288);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quyền:";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.linklb_dacotk);
            this.Controls.Add(this.btn_dky);
            this.Controls.Add(this.txt_xacnhan);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.chbox_hienthi);
            this.Controls.Add(this.lb_xacnhanmk);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_ten);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registration";
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Panel pic;
        private System.Windows.Forms.LinkLabel linklb_dacotk;
        private RJButton btn_dky;
        private System.Windows.Forms.TextBox txt_xacnhan;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.CheckBox chbox_hienthi;
        private System.Windows.Forms.Label lb_xacnhanmk;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}