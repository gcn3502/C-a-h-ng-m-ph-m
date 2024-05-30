namespace QLMP.Forms
{
    partial class login
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
            this.linklb_taotk = new System.Windows.Forms.LinkLabel();
            this.chbox_hienthi = new System.Windows.Forms.CheckBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.lb_mk = new System.Windows.Forms.Label();
            this.lb_tk = new System.Windows.Forms.Label();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new RJButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linklb_taotk
            // 
            this.linklb_taotk.AutoSize = true;
            this.linklb_taotk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklb_taotk.LinkColor = System.Drawing.Color.Red;
            this.linklb_taotk.Location = new System.Drawing.Point(104, 486);
            this.linklb_taotk.Name = "linklb_taotk";
            this.linklb_taotk.Size = new System.Drawing.Size(193, 22);
            this.linklb_taotk.TabIndex = 32;
            this.linklb_taotk.TabStop = true;
            this.linklb_taotk.Text = "Bạn chưa có tài khoản?";
            this.linklb_taotk.Click += new System.EventHandler(this.linklb_taotk_Click_1);
            // 
            // chbox_hienthi
            // 
            this.chbox_hienthi.AutoSize = true;
            this.chbox_hienthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_hienthi.Location = new System.Drawing.Point(177, 353);
            this.chbox_hienthi.Name = "chbox_hienthi";
            this.chbox_hienthi.Size = new System.Drawing.Size(169, 26);
            this.chbox_hienthi.TabIndex = 30;
            this.chbox_hienthi.Text = "Hiển thị mật khẩu";
            this.chbox_hienthi.UseVisualStyleBackColor = true;
            this.chbox_hienthi.Click += new System.EventHandler(this.chbox_hienthi_Click_1);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(165, 305);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(181, 22);
            this.txt_mk.TabIndex = 29;
            this.toolTip2.SetToolTip(this.txt_mk, "Vui lòng nhập mật khẩu");
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(165, 250);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(181, 22);
            this.txt_tk.TabIndex = 28;
            this.toolTip1.SetToolTip(this.txt_tk, "Vui lòng nhập tên tài khoản");
            this.txt_tk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tk_KeyUp);
            // 
            // lb_mk
            // 
            this.lb_mk.AutoSize = true;
            this.lb_mk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mk.Location = new System.Drawing.Point(38, 305);
            this.lb_mk.Name = "lb_mk";
            this.lb_mk.Size = new System.Drawing.Size(88, 22);
            this.lb_mk.TabIndex = 27;
            this.lb_mk.Text = "Mật khẩu:";
            // 
            // lb_tk
            // 
            this.lb_tk.AutoSize = true;
            this.lb_tk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tk.Location = new System.Drawing.Point(38, 250);
            this.lb_tk.Name = "lb_tk";
            this.lb_tk.Size = new System.Drawing.Size(94, 22);
            this.lb_tk.TabIndex = 26;
            this.lb_tk.Text = "Tài khoản:";
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(142, 109);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(135, 38);
            this.lb_welcome.TabIndex = 25;
            this.lb_welcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLMP.Properties.Resources.mypham3;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(426, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 666);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Blue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(95, 417);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(202, 47);
            this.btn_login.TabIndex = 31;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 666);
            this.Controls.Add(this.linklb_taotk);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.chbox_hienthi);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.lb_mk);
            this.Controls.Add(this.lb_tk);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklb_taotk;
        private RJButton btn_login;
        private System.Windows.Forms.CheckBox chbox_hienthi;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label lb_mk;
        private System.Windows.Forms.Label lb_tk;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}