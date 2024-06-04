namespace QLMP.Forms
{
    partial class Congviec
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnđong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridcongviec = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtmucluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridcongviec)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(260, 119);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(511, 27);
            this.txttimkiem.TabIndex = 19;
            this.txttimkiem.Enter += new System.EventHandler(this.txttimkiem_Enter);
            this.txttimkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyUp);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            // 
            // btnđong
            // 
            this.btnđong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnđong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnđong.ForeColor = System.Drawing.Color.Black;
            this.btnđong.Image = global::QLMP.Properties.Resources.icons8_close_40;
            this.btnđong.Location = new System.Drawing.Point(1001, 606);
            this.btnđong.Name = "btnđong";
            this.btnđong.Size = new System.Drawing.Size(120, 51);
            this.btnđong.TabIndex = 25;
            this.btnđong.Text = "  Đóng";
            this.btnđong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnđong.UseVisualStyleBackColor = false;
            this.btnđong.Click += new System.EventHandler(this.btnđong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridcongviec);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(71, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 215);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiển thị";
            // 
            // dgridcongviec
            // 
            this.dgridcongviec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgridcongviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridcongviec.Location = new System.Drawing.Point(20, 38);
            this.dgridcongviec.Name = "dgridcongviec";
            this.dgridcongviec.RowHeadersWidth = 51;
            this.dgridcongviec.RowTemplate.Height = 24;
            this.dgridcongviec.Size = new System.Drawing.Size(1018, 160);
            this.dgridcongviec.TabIndex = 0;
            this.dgridcongviec.Click += new System.EventHandler(this.dgridcongviec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txtmucluong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttencv);
            this.groupBox1.Controls.Add(this.txtmacv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 174);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(703, 115);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(197, 27);
            this.txtmota.TabIndex = 8;
            this.txtmota.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmota_KeyUp);
            // 
            // txtmucluong
            // 
            this.txtmucluong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmucluong.Location = new System.Drawing.Point(703, 58);
            this.txtmucluong.Name = "txtmucluong";
            this.txtmucluong.Size = new System.Drawing.Size(197, 27);
            this.txtmucluong.TabIndex = 7;
            this.txtmucluong.TextChanged += new System.EventHandler(this.txtmucluong_TextChanged);
            this.txtmucluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmucluong_KeyPress);
            this.txtmucluong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmucluong_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mức lương";
            // 
            // txttencv
            // 
            this.txttencv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttencv.Location = new System.Drawing.Point(168, 118);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(181, 27);
            this.txttencv.TabIndex = 4;
            this.txttencv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttencv_KeyPress);
            this.txttencv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttencv_KeyUp);
            // 
            // txtmacv
            // 
            this.txtmacv.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmacv.Location = new System.Drawing.Point(168, 54);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.Size = new System.Drawing.Size(181, 27);
            this.txtmacv.TabIndex = 3;
            this.txtmacv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmacv_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH MỤC CÔNG VIỆC";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.Color.Black;
            this.btntimkiem.Image = global::QLMP.Properties.Resources.icons8_search_40;
            this.btntimkiem.Location = new System.Drawing.Point(77, 106);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(147, 46);
            this.btntimkiem.TabIndex = 21;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Image = global::QLMP.Properties.Resources.icons8_skip_40;
            this.btnhuy.Location = new System.Drawing.Point(813, 606);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(115, 51);
            this.btnhuy.TabIndex = 24;
            this.btnhuy.Text = "  Hủy";
            this.btnhuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Image = global::QLMP.Properties.Resources.icons8_save_40;
            this.btnluu.Location = new System.Drawing.Point(631, 606);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(125, 51);
            this.btnluu.TabIndex = 23;
            this.btnluu.Text = "  Lưu";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::QLMP.Properties.Resources.icons8_delete_40;
            this.btnxoa.Location = new System.Drawing.Point(446, 606);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(124, 51);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "  Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Image = global::QLMP.Properties.Resources.icons8_fix_40;
            this.btnsua.Location = new System.Drawing.Point(269, 606);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(124, 51);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "  Sửa";
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Image = global::QLMP.Properties.Resources.icons8_add_40;
            this.btnthem.Location = new System.Drawing.Point(77, 606);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(126, 51);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = " Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Congviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 679);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnđong);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Congviec";
            this.Text = "Congviec";
            this.Load += new System.EventHandler(this.Congviec_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridcongviec)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnđong;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgridcongviec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtmucluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}