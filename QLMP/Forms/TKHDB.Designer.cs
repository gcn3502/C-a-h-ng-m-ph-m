﻿namespace QLMP.Forms
{
    partial class TKHDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridtkhdb = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridtkhdb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txtthang);
            this.groupBox1.Controls.Add(this.txtnam);
            this.groupBox1.Controls.Add(this.txtmahd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1073, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttong
            // 
            this.txttong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(801, 120);
            this.txttong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(227, 35);
            this.txttong.TabIndex = 14;
            this.txttong.TextChanged += new System.EventHandler(this.txttong_TextChanged);
            this.txttong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttong_KeyPress);
            this.txttong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttong_KeyUp);
            // 
            // txtmakh
            // 
            this.txtmakh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(801, 58);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(227, 35);
            this.txtmakh.TabIndex = 13;
            this.txtmakh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmakh_KeyUp);
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(171, 171);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(409, 35);
            this.txtmanv.TabIndex = 12;
            this.txtmanv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmanv_KeyUp);
            // 
            // txtthang
            // 
            this.txtthang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthang.Location = new System.Drawing.Point(171, 112);
            this.txtthang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(139, 35);
            this.txtthang.TabIndex = 11;
            this.txtthang.TextChanged += new System.EventHandler(this.txtthang_TextChanged);
            this.txtthang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtthang_KeyPress);
            this.txtthang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtthang_KeyUp);
            // 
            // txtnam
            // 
            this.txtnam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnam.Location = new System.Drawing.Point(449, 112);
            this.txtnam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(131, 35);
            this.txtnam.TabIndex = 10;
            this.txtnam.Click += new System.EventHandler(this.txtnam_Click);
            this.txtnam.TextChanged += new System.EventHandler(this.txtnam_TextChanged);
            this.txtnam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnam_KeyPress);
            this.txtnam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnam_KeyUp);
            // 
            // txtmahd
            // 
            this.txtmahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahd.Location = new System.Drawing.Point(171, 58);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(409, 35);
            this.txtmahd.TabIndex = 9;
            this.txtmahd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmahd_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(635, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridtkhdb);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 374);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1073, 391);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiển thị";
            // 
            // dgridtkhdb
            // 
            this.dgridtkhdb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgridtkhdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridtkhdb.Location = new System.Drawing.Point(22, 41);
            this.dgridtkhdb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgridtkhdb.Name = "dgridtkhdb";
            this.dgridtkhdb.RowHeadersWidth = 51;
            this.dgridtkhdb.RowTemplate.Height = 24;
            this.dgridtkhdb.Size = new System.Drawing.Size(1016, 322);
            this.dgridtkhdb.TabIndex = 0;
            this.dgridtkhdb.DoubleClick += new System.EventHandler(this.dgridtkhdb_DoubleClick);
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Image = global::QLMP.Properties.Resources.icons8_close_40;
            this.btndong.Location = new System.Drawing.Point(781, 795);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(179, 71);
            this.btndong.TabIndex = 5;
            this.btndong.Text = "Đóng";
            this.btndong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.Image = global::QLMP.Properties.Resources.icons8_return_40;
            this.btntimlai.Location = new System.Drawing.Point(462, 795);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(179, 71);
            this.btntimlai.TabIndex = 4;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = global::QLMP.Properties.Resources.icons8_search_40;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btntimkiem.Location = new System.Drawing.Point(143, 795);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(179, 71);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // TKHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 925);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TKHDB";
            this.Load += new System.EventHandler(this.TKHDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridtkhdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.TextBox txtnam;
        public System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgridtkhdb;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btndong;
    }
}