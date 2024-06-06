namespace QLMP.Forms
{
    partial class Hoadonban
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
            this.cbomahoadon = new System.Windows.Forms.ComboBox();
            this.lblmahd = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.cbomahang = new System.Windows.Forms.ComboBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtchietkhau = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtbangchu = new System.Windows.Forms.TextBox();
            this.lblbangchu = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgridhoadonban = new System.Windows.Forms.DataGridView();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.lblchietkhau = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lbldongia = new System.Windows.Forms.Label();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.lblmahang = new System.Windows.Forms.Label();
            this.grpttchung = new System.Windows.Forms.GroupBox();
            this.dtngayban = new System.Windows.Forms.DateTimePicker();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.cbomanhanvien = new System.Windows.Forms.ComboBox();
            this.cbomakhachhang = new System.Windows.Forms.ComboBox();
            this.msksdt = new System.Windows.Forms.MaskedTextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbltenkhachhang = new System.Windows.Forms.Label();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lbltennhanvien = new System.Windows.Forms.Label();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lblngayban = new System.Windows.Forms.Label();
            this.lblmahoadon = new System.Windows.Forms.Label();
            this.lblHDBanHang = new System.Windows.Forms.Label();
            this.grpttmh = new System.Windows.Forms.GroupBox();
            this.btnboqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridhoadonban)).BeginInit();
            this.grpttchung.SuspendLayout();
            this.grpttmh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnboqua
            // 
            this.btnboqua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(831, 828);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(135, 54);
            this.btnboqua.TabIndex = 36;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // cbomahoadon
            // 
            this.cbomahoadon.FormattingEnabled = true;
            this.cbomahoadon.Location = new System.Drawing.Point(153, 405);
            this.cbomahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomahoadon.Name = "cbomahoadon";
            this.cbomahoadon.Size = new System.Drawing.Size(289, 30);
            this.cbomahoadon.TabIndex = 35;
            this.cbomahoadon.DropDown += new System.EventHandler(this.cbomahoadon_DropDown);
            // 
            // lblmahd
            // 
            this.lblmahd.AutoSize = true;
            this.lblmahd.Location = new System.Drawing.Point(24, 405);
            this.lblmahd.Name = "lblmahd";
            this.lblmahd.Size = new System.Drawing.Size(115, 22);
            this.lblmahd.TabIndex = 34;
            this.lblmahd.Text = "Mã hóa đơn:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.Location = new System.Drawing.Point(751, 408);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(90, 22);
            this.lbltongtien.TabIndex = 14;
            this.lbltongtien.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(868, 402);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(183, 30);
            this.txttongtien.TabIndex = 33;
            // 
            // cbomahang
            // 
            this.cbomahang.FormattingEnabled = true;
            this.cbomahang.Location = new System.Drawing.Point(106, 33);
            this.cbomahang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomahang.Name = "cbomahang";
            this.cbomahang.Size = new System.Drawing.Size(224, 30);
            this.cbomahang.TabIndex = 32;
            this.cbomahang.SelectedIndexChanged += new System.EventHandler(this.cbomahang_SelectedIndexChanged);
            this.cbomahang.TextChanged += new System.EventHandler(this.cbomahang_TextChanged);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(837, 77);
            this.txtthanhtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(211, 30);
            this.txtthanhtien.TabIndex = 24;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(837, 33);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(211, 30);
            this.txtdongia.TabIndex = 23;
            // 
            // txtchietkhau
            // 
            this.txtchietkhau.Location = new System.Drawing.Point(502, 85);
            this.txtchietkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchietkhau.Name = "txtchietkhau";
            this.txtchietkhau.Size = new System.Drawing.Size(188, 30);
            this.txtchietkhau.TabIndex = 22;
            this.txtchietkhau.TextChanged += new System.EventHandler(this.txtchietkhau_TextChanged);
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(106, 85);
            this.txttenhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(224, 30);
            this.txttenhang.TabIndex = 21;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(502, 36);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(188, 30);
            this.txtsoluong.TabIndex = 20;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // txtbangchu
            // 
            this.txtbangchu.Location = new System.Drawing.Point(153, 451);
            this.txtbangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbangchu.Name = "txtbangchu";
            this.txtbangchu.Size = new System.Drawing.Size(504, 30);
            this.txtbangchu.TabIndex = 19;
            // 
            // lblbangchu
            // 
            this.lblbangchu.AutoSize = true;
            this.lblbangchu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangchu.Location = new System.Drawing.Point(24, 459);
            this.lblbangchu.Name = "lblbangchu";
            this.lblbangchu.Size = new System.Drawing.Size(90, 22);
            this.lblbangchu.TabIndex = 8;
            this.lblbangchu.Text = "Bằng chữ:";
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(1002, 828);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(122, 54);
            this.btndong.TabIndex = 18;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnin
            // 
            this.btnin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.Location = new System.Drawing.Point(645, 828);
            this.btnin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(155, 54);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "In hóa đơn";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(479, 399);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(128, 41);
            this.btntimkiem.TabIndex = 17;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(439, 828);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(144, 54);
            this.btnhuy.TabIndex = 16;
            this.btnhuy.Text = "Hủy hóa đơn";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(230, 828);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(124, 54);
            this.btnluu.TabIndex = 15;
            this.btnluu.Text = "Lưu hóa đơn";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(24, 828);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(146, 54);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm hóa đơn";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgridhoadonban
            // 
            this.dgridhoadonban.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgridhoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridhoadonban.Location = new System.Drawing.Point(21, 135);
            this.dgridhoadonban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridhoadonban.Name = "dgridhoadonban";
            this.dgridhoadonban.RowHeadersWidth = 62;
            this.dgridhoadonban.RowTemplate.Height = 28;
            this.dgridhoadonban.Size = new System.Drawing.Size(1030, 239);
            this.dgridhoadonban.TabIndex = 3;
            this.dgridhoadonban.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridhoadonban_CellDoubleClick);
            this.dgridhoadonban.Click += new System.EventHandler(this.dgridhoadonban_Click);
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(743, 85);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(98, 22);
            this.lblthanhtien.TabIndex = 13;
            this.lblthanhtien.Text = "Thành tiền:";
            // 
            // lblchietkhau
            // 
            this.lblchietkhau.AutoSize = true;
            this.lblchietkhau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchietkhau.Location = new System.Drawing.Point(396, 88);
            this.lblchietkhau.Name = "lblchietkhau";
            this.lblchietkhau.Size = new System.Drawing.Size(99, 22);
            this.lblchietkhau.TabIndex = 12;
            this.lblchietkhau.Text = "Chiết khấu:";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.Location = new System.Drawing.Point(396, 36);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(88, 22);
            this.lblsoluong.TabIndex = 11;
            this.lblsoluong.Text = "Số lượng:";
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.Location = new System.Drawing.Point(743, 39);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(79, 22);
            this.lbldongia.TabIndex = 10;
            this.lbldongia.Text = "Đơn giá:";
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenhang.Location = new System.Drawing.Point(6, 93);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(87, 22);
            this.lbltenhang.TabIndex = 9;
            this.lbltenhang.Text = "Tên hàng:";
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahang.Location = new System.Drawing.Point(17, 39);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(83, 22);
            this.lblmahang.TabIndex = 8;
            this.lblmahang.Text = "Mã hàng:";
            // 
            // grpttchung
            // 
            this.grpttchung.BackColor = System.Drawing.SystemColors.Control;
            this.grpttchung.Controls.Add(this.dtngayban);
            this.grpttchung.Controls.Add(this.txtmahoadon);
            this.grpttchung.Controls.Add(this.cbomanhanvien);
            this.grpttchung.Controls.Add(this.cbomakhachhang);
            this.grpttchung.Controls.Add(this.msksdt);
            this.grpttchung.Controls.Add(this.txttennhanvien);
            this.grpttchung.Controls.Add(this.txttenkhachhang);
            this.grpttchung.Controls.Add(this.txtdiachi);
            this.grpttchung.Controls.Add(this.lblsdt);
            this.grpttchung.Controls.Add(this.lbldiachi);
            this.grpttchung.Controls.Add(this.lbltenkhachhang);
            this.grpttchung.Controls.Add(this.lblmakhachhang);
            this.grpttchung.Controls.Add(this.lbltennhanvien);
            this.grpttchung.Controls.Add(this.lblmanhanvien);
            this.grpttchung.Controls.Add(this.lblngayban);
            this.grpttchung.Controls.Add(this.lblmahoadon);
            this.grpttchung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpttchung.Location = new System.Drawing.Point(24, 52);
            this.grpttchung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpttchung.Name = "grpttchung";
            this.grpttchung.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpttchung.Size = new System.Drawing.Size(1100, 229);
            this.grpttchung.TabIndex = 4;
            this.grpttchung.TabStop = false;
            this.grpttchung.Text = "Thông tin chung";
            // 
            // dtngayban
            // 
            this.dtngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayban.Location = new System.Drawing.Point(143, 90);
            this.dtngayban.Name = "dtngayban";
            this.dtngayban.Size = new System.Drawing.Size(281, 30);
            this.dtngayban.TabIndex = 36;
            this.dtngayban.Value = new System.DateTime(2024, 6, 6, 0, 0, 0, 0);
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(143, 43);
            this.txtmahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(281, 30);
            this.txtmahoadon.TabIndex = 35;
            // 
            // cbomanhanvien
            // 
            this.cbomanhanvien.FormattingEnabled = true;
            this.cbomanhanvien.Location = new System.Drawing.Point(143, 141);
            this.cbomanhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomanhanvien.Name = "cbomanhanvien";
            this.cbomanhanvien.Size = new System.Drawing.Size(281, 30);
            this.cbomanhanvien.TabIndex = 34;
            this.cbomanhanvien.TextChanged += new System.EventHandler(this.cbomanhanvien_TextChanged);
            // 
            // cbomakhachhang
            // 
            this.cbomakhachhang.FormattingEnabled = true;
            this.cbomakhachhang.Location = new System.Drawing.Point(728, 43);
            this.cbomakhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomakhachhang.Name = "cbomakhachhang";
            this.cbomakhachhang.Size = new System.Drawing.Size(313, 30);
            this.cbomakhachhang.TabIndex = 32;
            this.cbomakhachhang.TextChanged += new System.EventHandler(this.cbomakhachhang_TextChanged);
            // 
            // msksdt
            // 
            this.msksdt.Location = new System.Drawing.Point(728, 178);
            this.msksdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msksdt.Mask = "(999) 000-0000";
            this.msksdt.Name = "msksdt";
            this.msksdt.Size = new System.Drawing.Size(313, 30);
            this.msksdt.TabIndex = 29;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(145, 186);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(281, 30);
            this.txttennhanvien.TabIndex = 28;
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(728, 93);
            this.txttenkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(313, 30);
            this.txttenkhachhang.TabIndex = 27;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(728, 135);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(313, 30);
            this.txtdiachi.TabIndex = 26;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.Location = new System.Drawing.Point(557, 186);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(120, 22);
            this.lblsdt.TabIndex = 7;
            this.lblsdt.Text = "Số điện thoại:";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(557, 139);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(165, 22);
            this.lbldiachi.TabIndex = 6;
            this.lbldiachi.Text = "Địa chỉ khách hàng:";
            // 
            // lbltenkhachhang
            // 
            this.lbltenkhachhang.AutoSize = true;
            this.lbltenkhachhang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhachhang.Location = new System.Drawing.Point(557, 96);
            this.lbltenkhachhang.Name = "lbltenkhachhang";
            this.lbltenkhachhang.Size = new System.Drawing.Size(137, 22);
            this.lbltenkhachhang.TabIndex = 5;
            this.lbltenkhachhang.Text = "Tên khách hàng:";
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhachhang.Location = new System.Drawing.Point(557, 46);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(133, 22);
            this.lblmakhachhang.TabIndex = 4;
            this.lblmakhachhang.Text = "Mã khách hàng:";
            // 
            // lbltennhanvien
            // 
            this.lbltennhanvien.AutoSize = true;
            this.lbltennhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennhanvien.Location = new System.Drawing.Point(17, 191);
            this.lbltennhanvien.Name = "lbltennhanvien";
            this.lbltennhanvien.Size = new System.Drawing.Size(126, 22);
            this.lbltennhanvien.TabIndex = 3;
            this.lbltennhanvien.Text = "Tên nhân viên:";
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanhanvien.Location = new System.Drawing.Point(17, 144);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(122, 22);
            this.lblmanhanvien.TabIndex = 2;
            this.lblmanhanvien.Text = "Mã nhân viên:";
            // 
            // lblngayban
            // 
            this.lblngayban.AutoSize = true;
            this.lblngayban.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngayban.Location = new System.Drawing.Point(17, 95);
            this.lblngayban.Name = "lblngayban";
            this.lblngayban.Size = new System.Drawing.Size(90, 22);
            this.lblngayban.TabIndex = 1;
            this.lblngayban.Text = "Ngày bán:";
            // 
            // lblmahoadon
            // 
            this.lblmahoadon.AutoSize = true;
            this.lblmahoadon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahoadon.Location = new System.Drawing.Point(17, 46);
            this.lblmahoadon.Name = "lblmahoadon";
            this.lblmahoadon.Size = new System.Drawing.Size(110, 22);
            this.lblmahoadon.TabIndex = 0;
            this.lblmahoadon.Text = "Mã hóa đơn:";
            // 
            // lblHDBanHang
            // 
            this.lblHDBanHang.AutoSize = true;
            this.lblHDBanHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDBanHang.Location = new System.Drawing.Point(339, 9);
            this.lblHDBanHang.Name = "lblHDBanHang";
            this.lblHDBanHang.Size = new System.Drawing.Size(390, 41);
            this.lblHDBanHang.TabIndex = 3;
            this.lblHDBanHang.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // grpttmh
            // 
            this.grpttmh.Controls.Add(this.cbomahoadon);
            this.grpttmh.Controls.Add(this.lblmahd);
            this.grpttmh.Controls.Add(this.lbltongtien);
            this.grpttmh.Controls.Add(this.txttongtien);
            this.grpttmh.Controls.Add(this.cbomahang);
            this.grpttmh.Controls.Add(this.txtthanhtien);
            this.grpttmh.Controls.Add(this.txtdongia);
            this.grpttmh.Controls.Add(this.txtchietkhau);
            this.grpttmh.Controls.Add(this.txttenhang);
            this.grpttmh.Controls.Add(this.txtsoluong);
            this.grpttmh.Controls.Add(this.txtbangchu);
            this.grpttmh.Controls.Add(this.lblbangchu);
            this.grpttmh.Controls.Add(this.btntimkiem);
            this.grpttmh.Controls.Add(this.dgridhoadonban);
            this.grpttmh.Controls.Add(this.lblthanhtien);
            this.grpttmh.Controls.Add(this.lblchietkhau);
            this.grpttmh.Controls.Add(this.lblsoluong);
            this.grpttmh.Controls.Add(this.lbldongia);
            this.grpttmh.Controls.Add(this.lbltenhang);
            this.grpttmh.Controls.Add(this.lblmahang);
            this.grpttmh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpttmh.Location = new System.Drawing.Point(24, 285);
            this.grpttmh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpttmh.Name = "grpttmh";
            this.grpttmh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpttmh.Size = new System.Drawing.Size(1100, 512);
            this.grpttmh.TabIndex = 5;
            this.grpttmh.TabStop = false;
            this.grpttmh.Text = "Thông tin các mặt hàng";
            // 
            // btnboqua
            // 
            this.btnboqua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(1107, 1210);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(165, 64);
            this.btnboqua.TabIndex = 36;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // Hoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 913);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.grpttchung);
            this.Controls.Add(this.lblHDBanHang);
            this.Controls.Add(this.grpttmh);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btndong);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Hoadonban";
            this.Text = "Hoadonban";
            this.Load += new System.EventHandler(this.Hoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridhoadonban)).EndInit();
            this.grpttchung.ResumeLayout(false);
            this.grpttchung.PerformLayout();
            this.grpttmh.ResumeLayout(false);
            this.grpttmh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbomahoadon;
        private System.Windows.Forms.Label lblmahd;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.ComboBox cbomahang;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtchietkhau;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtbangchu;
        private System.Windows.Forms.Label lblbangchu;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgridhoadonban;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label lblchietkhau;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label lbltenhang;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.GroupBox grpttchung;
        public System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.ComboBox cbomanhanvien;
        private System.Windows.Forms.MaskedTextBox msksdt;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbltenkhachhang;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lbltennhanvien;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lblngayban;
        private System.Windows.Forms.Label lblmahoadon;
        private System.Windows.Forms.Label lblHDBanHang;
        private System.Windows.Forms.GroupBox grpttmh;
        private System.Windows.Forms.DateTimePicker dtngayban;
        private System.Windows.Forms.ComboBox cbomakhachhang;
    }
}