namespace QLMP.Forms
{
    partial class Nhanvien
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
            this.chknam = new System.Windows.Forms.CheckBox();
            this.chknu = new System.Windows.Forms.CheckBox();
            this.grpgioitinh = new System.Windows.Forms.GroupBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.dgridnhanvien = new System.Windows.Forms.DataGridView();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskngayvaolam = new System.Windows.Forms.MaskedTextBox();
            this.cbotaikhoan = new System.Windows.Forms.ComboBox();
            this.cbocongviec = new System.Windows.Forms.ComboBox();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblngayvaolam = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lblcongviec = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picanh = new System.Windows.Forms.PictureBox();
            this.gplnhanvien = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpgioitinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).BeginInit();
            this.gplnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.SystemColors.Window;
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(89, 848);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(296, 30);
            this.txttimkiem.TabIndex = 60;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            this.txttimkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyUp);
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknam.Location = new System.Drawing.Point(106, 35);
            this.chknam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(73, 26);
            this.chknam.TabIndex = 29;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            this.chknam.CheckedChanged += new System.EventHandler(this.chknam_CheckedChanged);
            // 
            // chknu
            // 
            this.chknu.AutoSize = true;
            this.chknu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknu.Location = new System.Drawing.Point(236, 35);
            this.chknu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chknu.Name = "chknu";
            this.chknu.Size = new System.Drawing.Size(61, 26);
            this.chknu.TabIndex = 30;
            this.chknu.Text = "Nữ";
            this.chknu.UseVisualStyleBackColor = true;
            this.chknu.CheckedChanged += new System.EventHandler(this.chknu_CheckedChanged);
            // 
            // grpgioitinh
            // 
            this.grpgioitinh.Controls.Add(this.chknam);
            this.grpgioitinh.Controls.Add(this.chknu);
            this.grpgioitinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpgioitinh.Location = new System.Drawing.Point(89, 265);
            this.grpgioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpgioitinh.Name = "grpgioitinh";
            this.grpgioitinh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpgioitinh.Size = new System.Drawing.Size(325, 78);
            this.grpgioitinh.TabIndex = 59;
            this.grpgioitinh.TabStop = false;
            this.grpgioitinh.Text = "Giới tính";
            this.grpgioitinh.Enter += new System.EventHandler(this.grpgioitinh_Enter);
            // 
            // btndong
            // 
            this.btndong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Location = new System.Drawing.Point(1104, 780);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(115, 42);
            this.btndong.TabIndex = 58;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(912, 780);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(115, 42);
            this.btnboqua.TabIndex = 57;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(391, 841);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(115, 42);
            this.btntimkiem.TabIndex = 56;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(706, 780);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(115, 42);
            this.btnluu.TabIndex = 55;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(493, 780);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(115, 42);
            this.btnxoa.TabIndex = 54;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(287, 780);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(115, 42);
            this.btnsua.TabIndex = 53;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(89, 780);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 42);
            this.btnthem.TabIndex = 52;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttennhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.Location = new System.Drawing.Point(1032, 329);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(187, 30);
            this.txttennhanvien.TabIndex = 51;
            this.txttennhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttennhanvien.TextChanged += new System.EventHandler(this.txttennhanvien_TextChanged);
            // 
            // txtmanv
            // 
            this.txtmanv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtmanv.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmanv.Location = new System.Drawing.Point(1049, 282);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(146, 30);
            this.txtmanv.TabIndex = 50;
            this.txtmanv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmanv.TextChanged += new System.EventHandler(this.txtmanv_TextChanged);
            // 
            // txtanh
            // 
            this.txtanh.BackColor = System.Drawing.SystemColors.Menu;
            this.txtanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanh.Location = new System.Drawing.Point(684, 289);
            this.txtanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(275, 30);
            this.txtanh.TabIndex = 48;
            this.txtanh.TextChanged += new System.EventHandler(this.txtanh_TextChanged);
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(585, 282);
            this.btnopen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(93, 42);
            this.btnopen.TabIndex = 47;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // dgridnhanvien
            // 
            this.dgridnhanvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgridnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridnhanvien.Location = new System.Drawing.Point(32, 44);
            this.dgridnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgridnhanvien.Name = "dgridnhanvien";
            this.dgridnhanvien.RowHeadersWidth = 62;
            this.dgridnhanvien.RowTemplate.Height = 28;
            this.dgridnhanvien.Size = new System.Drawing.Size(1074, 321);
            this.dgridnhanvien.TabIndex = 46;
            this.dgridnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridnhanvien_CellContentClick);
            this.dgridnhanvien.Click += new System.EventHandler(this.dgridnhanvien_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(684, 90);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(275, 30);
            this.txtdiachi.TabIndex = 45;
            this.txtdiachi.TextChanged += new System.EventHandler(this.txtdiachi_TextChanged);
            this.txtdiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiachi_KeyUp);
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskngaysinh.Location = new System.Drawing.Point(684, 204);
            this.mskngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(275, 30);
            this.mskngaysinh.TabIndex = 44;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            this.mskngaysinh.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskngaysinh_MaskInputRejected);
            this.mskngaysinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskngaysinh_KeyUp);
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdienthoai.Location = new System.Drawing.Point(684, 142);
            this.mskdienthoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(275, 30);
            this.mskdienthoai.TabIndex = 43;
            this.mskdienthoai.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskdienthoai_MaskInputRejected);
            this.mskdienthoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskdienthoai_KeyUp);
            // 
            // mskngayvaolam
            // 
            this.mskngayvaolam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskngayvaolam.Location = new System.Drawing.Point(217, 207);
            this.mskngayvaolam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskngayvaolam.Mask = "00/00/0000";
            this.mskngayvaolam.Name = "mskngayvaolam";
            this.mskngayvaolam.Size = new System.Drawing.Size(204, 30);
            this.mskngayvaolam.TabIndex = 42;
            this.mskngayvaolam.ValidatingType = typeof(System.DateTime);
            this.mskngayvaolam.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskngayvaolam_MaskInputRejected);
            this.mskngayvaolam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskngayvaolam_KeyUp);
            // 
            // cbotaikhoan
            // 
            this.cbotaikhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotaikhoan.FormattingEnabled = true;
            this.cbotaikhoan.Location = new System.Drawing.Point(217, 93);
            this.cbotaikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbotaikhoan.Name = "cbotaikhoan";
            this.cbotaikhoan.Size = new System.Drawing.Size(204, 30);
            this.cbotaikhoan.TabIndex = 41;
            this.cbotaikhoan.SelectedIndexChanged += new System.EventHandler(this.cbotaikhoan_SelectedIndexChanged);
            this.cbotaikhoan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbotaikhoan_KeyUp);
            // 
            // cbocongviec
            // 
            this.cbocongviec.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocongviec.FormattingEnabled = true;
            this.cbocongviec.Location = new System.Drawing.Point(217, 150);
            this.cbocongviec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbocongviec.Name = "cbocongviec";
            this.cbocongviec.Size = new System.Drawing.Size(204, 30);
            this.cbocongviec.TabIndex = 40;
            this.cbocongviec.SelectedIndexChanged += new System.EventHandler(this.cbocongviec_SelectedIndexChanged);
            this.cbocongviec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbocongviec_KeyUp);
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.Location = new System.Drawing.Point(590, 207);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(88, 22);
            this.lblngaysinh.TabIndex = 39;
            this.lblngaysinh.Text = "Ngày sinh";
            this.lblngaysinh.Click += new System.EventHandler(this.lblngaysinh_Click);
            // 
            // lblngayvaolam
            // 
            this.lblngayvaolam.AutoSize = true;
            this.lblngayvaolam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngayvaolam.Location = new System.Drawing.Point(82, 207);
            this.lblngayvaolam.Name = "lblngayvaolam";
            this.lblngayvaolam.Size = new System.Drawing.Size(119, 22);
            this.lblngayvaolam.TabIndex = 38;
            this.lblngayvaolam.Text = "Ngày vào làm";
            this.lblngayvaolam.Click += new System.EventHandler(this.lblngayvaolam_Click);
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.Location = new System.Drawing.Point(586, 93);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(68, 22);
            this.lbldiachi.TabIndex = 37;
            this.lbldiachi.Text = "Địa chỉ";
            this.lbldiachi.Click += new System.EventHandler(this.lbldiachi_Click);
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.Location = new System.Drawing.Point(586, 150);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(92, 22);
            this.lbldienthoai.TabIndex = 36;
            this.lbldienthoai.Text = "Điện thoại";
            this.lbldienthoai.Click += new System.EventHandler(this.lbldienthoai_Click);
            // 
            // lblcongviec
            // 
            this.lblcongviec.AutoSize = true;
            this.lblcongviec.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcongviec.Location = new System.Drawing.Point(80, 150);
            this.lblcongviec.Name = "lblcongviec";
            this.lblcongviec.Size = new System.Drawing.Size(90, 22);
            this.lblcongviec.TabIndex = 35;
            this.lblcongviec.Text = "Công việc";
            this.lblcongviec.Click += new System.EventHandler(this.lblcongviec_Click);
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaikhoan.Location = new System.Drawing.Point(82, 96);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(88, 22);
            this.lbltaikhoan.TabIndex = 34;
            this.lbltaikhoan.Text = "Tài khoản";
            this.lbltaikhoan.Click += new System.EventHandler(this.lbltaikhoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picanh
            // 
            this.picanh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picanh.Location = new System.Drawing.Point(1032, 90);
            this.picanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picanh.Name = "picanh";
            this.picanh.Size = new System.Drawing.Size(187, 178);
            this.picanh.TabIndex = 49;
            this.picanh.TabStop = false;
            this.picanh.Click += new System.EventHandler(this.picanh_Click);
            // 
            // gplnhanvien
            // 
            this.gplnhanvien.Controls.Add(this.dgridnhanvien);
            this.gplnhanvien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplnhanvien.Location = new System.Drawing.Point(89, 379);
            this.gplnhanvien.Name = "gplnhanvien";
            this.gplnhanvien.Size = new System.Drawing.Size(1132, 387);
            this.gplnhanvien.TabIndex = 61;
            this.gplnhanvien.TabStop = false;
            this.gplnhanvien.Text = "Thông tin nhân viên";
            this.gplnhanvien.Enter += new System.EventHandler(this.gplnhanvien_Enter);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 924);
            this.Controls.Add(this.gplnhanvien);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.grpgioitinh);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.picanh);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.mskngayvaolam);
            this.Controls.Add(this.cbotaikhoan);
            this.Controls.Add(this.cbocongviec);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lblngayvaolam);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lblcongviec);
            this.Controls.Add(this.lbltaikhoan);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.grpgioitinh.ResumeLayout(false);
            this.grpgioitinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).EndInit();
            this.gplnhanvien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.CheckBox chknam;
        private System.Windows.Forms.CheckBox chknu;
        private System.Windows.Forms.GroupBox grpgioitinh;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.PictureBox picanh;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.DataGridView dgridnhanvien;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.MaskedTextBox mskngayvaolam;
        private System.Windows.Forms.ComboBox cbotaikhoan;
        private System.Windows.Forms.ComboBox cbocongviec;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblngayvaolam;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lblcongviec;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gplnhanvien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}