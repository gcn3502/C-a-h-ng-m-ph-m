namespace QLMP.Forms
{
    partial class Phanloai
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
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnđong = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridphanloai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridphanloai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(245, 161);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(511, 22);
            this.txttimkiem.TabIndex = 17;
            this.txttimkiem.Enter += new System.EventHandler(this.txttimkiem_Enter);
            this.txttimkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyUp);
            this.txttimkiem.Leave += new System.EventHandler(this.txttimkiem_Leave);
            this.txttimkiem.MouseEnter += new System.EventHandler(this.txttimkiem_MouseEnter);
            this.txttimkiem.MouseLeave += new System.EventHandler(this.txttimkiem_MouseLeave);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.btntimkiem.ForeColor = System.Drawing.Color.Black;
            this.btntimkiem.Location = new System.Drawing.Point(95, 153);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 38);
            this.btntimkiem.TabIndex = 20;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnđong
            // 
            this.btnđong.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnđong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnđong.ForeColor = System.Drawing.Color.Black;
            this.btnđong.Location = new System.Drawing.Point(1001, 605);
            this.btnđong.Name = "btnđong";
            this.btnđong.Size = new System.Drawing.Size(120, 51);
            this.btnđong.TabIndex = 19;
            this.btnđong.Text = "Đóng";
            this.btnđong.UseVisualStyleBackColor = false;
            this.btnđong.Click += new System.EventHandler(this.btnđong_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.Black;
            this.btnhuy.Location = new System.Drawing.Point(813, 605);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(115, 51);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(631, 605);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(125, 51);
            this.btnluu.TabIndex = 16;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(446, 605);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(124, 51);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Black;
            this.btnsua.Location = new System.Drawing.Point(269, 605);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(124, 51);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(77, 605);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(126, 51);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridphanloai);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(81, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 172);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiển thị";
            // 
            // dgridphanloai
            // 
            this.dgridphanloai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgridphanloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridphanloai.Location = new System.Drawing.Point(14, 34);
            this.dgridphanloai.Name = "dgridphanloai";
            this.dgridphanloai.RowHeadersWidth = 51;
            this.dgridphanloai.RowTemplate.Height = 24;
            this.dgridphanloai.Size = new System.Drawing.Size(961, 132);
            this.dgridphanloai.TabIndex = 0;
            this.dgridphanloai.Click += new System.EventHandler(this.dgridphanloai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttenloai);
            this.groupBox1.Controls.Add(this.txtmaloai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 159);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(188, 105);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(203, 27);
            this.txttenloai.TabIndex = 6;
            this.txttenloai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttenloai_KeyPress);
            this.txttenloai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttenloai_KeyUp);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(188, 53);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(203, 27);
            this.txtmaloai.TabIndex = 5;
            this.txtmaloai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmaloai_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(340, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHÂN LOẠI SẢN PHẨM";
            // 
            // Phanloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 724);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnđong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Phanloai";
            this.Text = "Phanloai";
            this.Load += new System.EventHandler(this.Phanloai_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridphanloai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnđong;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgridphanloai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}