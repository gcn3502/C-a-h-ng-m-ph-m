using QLMP.Forms;
using System;
using System.Windows.Forms;

namespace QLMP.FORMS
{
    public partial class Home : Form
    {
        private int role;

        public Home(int role)
        {
            InitializeComponent();
            showSideMenu(1, 1);
            showSideMenu(1, 2);
        }

        public Home()
        {
            InitializeComponent();
            showSideMenu(1, 1);
            showSideMenu(1, 2);
        }
        // form home nhấn x  thì  đóng hoàn toàn
        // form home nhấn dxuat thì đóng form home -> dnhap
        // nhấn thoát thì đóng hoàn toàn
        bool isExit = true;
        private void btn_dx_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            dnhap dnhap = new dnhap();
            dnhap.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {

        //        login dnhap = new login();
        //        dnhap.Show();
        //    }
        //}

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_quanly_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_QuanlySubMenu);

        }
        private void showSideMenu(int isOpen, int menuNumber)
        {
            if (menuNumber == 1)
            {
                panel_QuanlySubMenu.Visible = isOpen == 1 ? false : true;

            }
            else
            {
                panel_HdSideMenu.Visible = isOpen == 1 ? false : true;
            }

        }
        private void HideMenu()
        {
            if (panel_QuanlySubMenu.Visible == true)
            {
                panel_QuanlySubMenu.Visible = false;
            }
            if (panel_HdSideMenu.Visible == true)
            {
                panel_HdSideMenu.Visible = false;
            }


        }
        private void ShowMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openPanelchild(new Hanghoa(), sender);
            showSideMenu(0, 1);
            showSideMenu(1, 2);
            // string show;
            //HideMenu();
            //   Hanghoa hh = new Hanghoa();
            //   hh.ShowDialog();
            //panel_main.Controls.Add(hh);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSideMenu(0, 1);
            showSideMenu(1, 2);
            openPanelchild(new Nhanvien(), sender);
            //HideMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HideMenu();
        }





        private void btn_hdn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang phát triển");
            openPanelchild(new frmHoaDonNhap(), sender);
            showSideMenu(1, 1);
            showSideMenu(0, 2);
            //HideMenu();

        }

        private void btn_hdb_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang phát triển");
            openPanelchild(new Hoadonban(), sender);
            showSideMenu(1, 1);
            showSideMenu(0, 2);
            //HideMenu();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_HdSideMenu);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        //private void btn_login_Click(object sender, EventArgs e)
        //{
        //    openPanelchild(new login(), sender);
        //}

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Show();
            }
        }
        // hàm mở panel con
        private Form activeForm = null;

        private void openPanelchild(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_child.Controls.Add(childForm);
            this.panel_child.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void panelSidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Ncc_Click(object sender, EventArgs e)
        {

        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            //openPanelchild(new Khachhang(), sender);
        }
    }
}
