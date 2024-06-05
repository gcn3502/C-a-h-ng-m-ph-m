namespace QLMP.Forms
{
    partial class NhaCungCap
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
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.mtxt_sdt = new System.Windows.Forms.MaskedTextBox();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.datagridview_nhacungcap = new System.Windows.Forms.DataGridView();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_tk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_nhacungcap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxt_sdt
            // 
            this.mtxt_sdt.Location = new System.Drawing.Point(554, 32);
            this.mtxt_sdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxt_sdt.Mask = "(999) 000-0000";
            this.mtxt_sdt.Name = "mtxt_sdt";
            this.mtxt_sdt.Size = new System.Drawing.Size(212, 26);
            this.mtxt_sdt.TabIndex = 22;
            this.toolTip4.SetToolTip(this.mtxt_sdt, "Hãy nhập vào trường này");
            this.mtxt_sdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtxt_sdt_KeyUp);
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(110, 112);
            this.txt_dc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(231, 26);
            this.txt_dc.TabIndex = 19;
            this.toolTip3.SetToolTip(this.txt_dc, "Hãy nhập vào trường này");
            this.txt_dc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dc_KeyUp);
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(110, 74);
            this.txt_tenncc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.Size = new System.Drawing.Size(231, 26);
            this.txt_tenncc.TabIndex = 18;
            this.toolTip2.SetToolTip(this.txt_tenncc, "Hãy nhập vào trường này");
            this.txt_tenncc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_tenncc_KeyUp);
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(110, 32);
            this.txt_mancc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(231, 26);
            this.txt_mancc.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txt_mancc, "Hãy nhập vào trường này");
            this.txt_mancc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_mancc_KeyUp);
            // 
            // datagridview_nhacungcap
            // 
            this.datagridview_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_nhacungcap.Location = new System.Drawing.Point(0, 23);
            this.datagridview_nhacungcap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagridview_nhacungcap.Name = "datagridview_nhacungcap";
            this.datagridview_nhacungcap.RowHeadersWidth = 51;
            this.datagridview_nhacungcap.RowTemplate.Height = 24;
            this.datagridview_nhacungcap.Size = new System.Drawing.Size(796, 263);
            this.datagridview_nhacungcap.TabIndex = 0;
            this.datagridview_nhacungcap.Click += new System.EventHandler(this.datagridview_nhacungcap_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = global::QLMP.Properties.Resources.icons8_skip_40;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(594, 617);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(98, 42);
            this.btn_huy.TabIndex = 27;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::QLMP.Properties.Resources.icons8_add_40;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(40, 617);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 42);
            this.btn_them.TabIndex = 23;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_tk
            // 
            this.btn_tk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.Image = global::QLMP.Properties.Resources.icons8_search_40;
            this.btn_tk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tk.Location = new System.Drawing.Point(719, 617);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(117, 42);
            this.btn_tk.TabIndex = 28;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tk.UseVisualStyleBackColor = false;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(216, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagridview_nhacungcap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(796, 290);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hiển thị";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::QLMP.Properties.Resources.icons8_delete_40;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(307, 617);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 42);
            this.btn_xoa.TabIndex = 25;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::QLMP.Properties.Resources.icons8_fix_30;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(170, 617);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(91, 42);
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::QLMP.Properties.Resources.icons8_save_40;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(450, 617);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(104, 42);
            this.btn_luu.TabIndex = 26;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên NCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã NCC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxt_sdt);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.txt_tenncc);
            this.groupBox1.Controls.Add(this.txt_mancc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(796, 156);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(876, 667);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.NCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_nhacungcap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView datagridview_nhacungcap;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.MaskedTextBox mtxt_sdt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}