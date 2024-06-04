namespace QLMP.Forms
{
    partial class Khachhang
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
            this.btndong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridkhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblmakhach = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridkhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(1285, 793);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(108, 47);
            this.btndong.TabIndex = 43;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(637, 55);
            this.label6.TabIndex = 36;
            this.label6.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridkhachhang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(78, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1358, 418);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị danh sách";
            // 
            // dgridkhachhang
            // 
            this.dgridkhachhang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgridkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridkhachhang.Location = new System.Drawing.Point(24, 43);
            this.dgridkhachhang.Name = "dgridkhachhang";
            this.dgridkhachhang.RowHeadersWidth = 72;
            this.dgridkhachhang.RowTemplate.Height = 31;
            this.dgridkhachhang.Size = new System.Drawing.Size(1306, 358);
            this.dgridkhachhang.TabIndex = 0;
            this.dgridkhachhang.Click += new System.EventHandler(this.dgridkhachhang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskdienthoai);
            this.groupBox1.Controls.Add(this.txttenkhach);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtmakhach);
            this.groupBox1.Controls.Add(this.lbltenkhach);
            this.groupBox1.Controls.Add(this.lbldienthoai);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.lblmakhach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1358, 168);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdienthoai.Location = new System.Drawing.Point(755, 113);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(356, 29);
            this.mskdienthoai.TabIndex = 8;
            this.mskdienthoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskdienthoai_KeyUp);
            // 
            // txttenkhach
            // 
            this.txttenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkhach.Location = new System.Drawing.Point(168, 113);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(356, 29);
            this.txttenkhach.TabIndex = 7;
            this.txttenkhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttenkhach_KeyUp);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(755, 44);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(356, 29);
            this.txtdiachi.TabIndex = 5;
            this.txtdiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiachi_KeyUp);
            // 
            // txtmakhach
            // 
            this.txtmakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakhach.Location = new System.Drawing.Point(168, 47);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(356, 29);
            this.txtmakhach.TabIndex = 4;
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhach.Location = new System.Drawing.Point(42, 108);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(105, 25);
            this.lbltenkhach.TabIndex = 3;
            this.lbltenkhach.Text = "Tên khách";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.Location = new System.Drawing.Point(647, 108);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(99, 25);
            this.lbldienthoai.TabIndex = 2;
            this.lbldienthoai.Text = "Điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(647, 47);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(71, 25);
            this.lbldiachi.TabIndex = 1;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblmakhach
            // 
            this.lblmakhach.AutoSize = true;
            this.lblmakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhach.Location = new System.Drawing.Point(42, 47);
            this.lblmakhach.Name = "lblmakhach";
            this.lblmakhach.Size = new System.Drawing.Size(98, 25);
            this.lblmakhach.TabIndex = 0;
            this.lblmakhach.Text = "Mã khách";
            // 
            // btntimkiem
            // 
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(1300, 107);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(155, 37);
            this.btntimkiem.TabIndex = 40;
            this.btntimkiem.Text = "  Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(685, 112);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(593, 32);
            this.txttimkiem.TabIndex = 39;
            this.txttimkiem.Text = "Nhập từ khoá tìm kiếm...";
            this.txttimkiem.Click += new System.EventHandler(this.txttimkiem_Click);
            this.txttimkiem.Enter += new System.EventHandler(this.txttimkiem_Enter);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 38;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(310, 793);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 47);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(568, 793);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(108, 47);
            this.btnsua.TabIndex = 35;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(817, 793);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(108, 47);
            this.btnluu.TabIndex = 34;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(1065, 793);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(108, 47);
            this.btnboqua.TabIndex = 33;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(78, 793);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(108, 47);
            this.btnthem.TabIndex = 32;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 897);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnthem);
            this.Name = "Khachhang";
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridkhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgridkhachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblmakhach;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthem;
    }
}