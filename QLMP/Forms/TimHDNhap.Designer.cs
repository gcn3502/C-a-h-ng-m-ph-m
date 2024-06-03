namespace QLMP.Forms
{
    partial class TimHDNhap
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
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridtimkiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblngay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblthang = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtncc = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridtimkiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(1233, 907);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(217, 66);
            this.btndong.TabIndex = 11;
            this.btndong.Text = "Đóng";
            this.btndong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndong.UseVisualStyleBackColor = true;
            // 
            // btntimlai
            // 
            this.btntimlai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.Location = new System.Drawing.Point(795, 907);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(217, 66);
            this.btntimlai.TabIndex = 10;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(373, 907);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(217, 66);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(91, 483);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1546, 316);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiển thị";
            // 
            // dgridtimkiem
            // 
            this.dgridtimkiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgridtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridtimkiem.Location = new System.Drawing.Point(23, 68);
            this.dgridtimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgridtimkiem.Name = "dgridtimkiem";
            this.dgridtimkiem.RowHeadersWidth = 51;
            this.dgridtimkiem.RowTemplate.Height = 24;
            this.dgridtimkiem.Size = new System.Drawing.Size(1493, 225);
            this.dgridtimkiem.TabIndex = 0;
            this.dgridtimkiem.DoubleClick += new System.EventHandler(this.dgridtimkiem_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmanhanvien);
            this.groupBox1.Controls.Add(this.txtncc);
            this.groupBox1.Controls.Add(this.txtthang);
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.txtngay);
            this.groupBox1.Controls.Add(this.lblthang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblngay);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.txtsohd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(91, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1546, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(1197, 256);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Multiline = true;
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(297, 37);
            this.txttongtien.TabIndex = 14;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // txtsohd
            // 
            this.txtsohd.Location = new System.Drawing.Point(282, 80);
            this.txtsohd.Margin = new System.Windows.Forms.Padding(4);
            this.txtsohd.Multiline = true;
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(297, 37);
            this.txtsohd.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(966, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã nhà cung cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(966, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN NHẬP";
            // 
            // lblngay
            // 
            this.lblngay.AutoSize = true;
            this.lblngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngay.Location = new System.Drawing.Point(73, 156);
            this.lblngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblngay.Name = "lblngay";
            this.lblngay.Size = new System.Drawing.Size(73, 33);
            this.lblngay.TabIndex = 19;
            this.lblngay.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 33);
            this.label7.TabIndex = 20;
            this.label7.Text = "Năm";
            // 
            // lblthang
            // 
            this.lblthang.AutoSize = true;
            this.lblthang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthang.Location = new System.Drawing.Point(400, 156);
            this.lblthang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthang.Name = "lblthang";
            this.lblthang.Size = new System.Drawing.Size(84, 33);
            this.lblthang.TabIndex = 21;
            this.lblthang.Text = "Tháng";
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(282, 152);
            this.txtngay.Margin = new System.Windows.Forms.Padding(4);
            this.txtngay.Multiline = true;
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(58, 37);
            this.txtngay.TabIndex = 24;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(704, 152);
            this.txtnam.Margin = new System.Windows.Forms.Padding(4);
            this.txtnam.Multiline = true;
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(100, 37);
            this.txtnam.TabIndex = 25;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(502, 152);
            this.txtthang.Margin = new System.Windows.Forms.Padding(4);
            this.txtthang.Multiline = true;
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(61, 37);
            this.txtthang.TabIndex = 26;
            // 
            // txtncc
            // 
            this.txtncc.Location = new System.Drawing.Point(1197, 80);
            this.txtncc.Margin = new System.Windows.Forms.Padding(4);
            this.txtncc.Multiline = true;
            this.txtncc.Name = "txtncc";
            this.txtncc.Size = new System.Drawing.Size(297, 37);
            this.txtncc.TabIndex = 27;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(282, 252);
            this.txtmanhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanhanvien.Multiline = true;
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(297, 37);
            this.txtmanhanvien.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(108, 838);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(579, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kích đúp một hoá đơn để hiển thị thông tin chi tiết";
            // 
            // TimHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 1108);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TimHDNhap";
            this.Text = "TimHDNhap";
            this.Load += new System.EventHandler(this.TimHDNhap_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridtimkiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgridtimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.Label lblthang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblngay;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtncc;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label3;
    }
}