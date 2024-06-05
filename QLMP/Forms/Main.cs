using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            showSideMenu(0, 1);
            showSideMenu(0, 2);
            showSideMenu(0, 3);

        }
        public Main(int role)
        {
            InitializeComponent();
            showSideMenu(0, 1);
            showSideMenu(0, 2);
            showSideMenu(0, 3);
        }

        // show
        private void showSideMenu(int isOpen, int menuNumber)
        {
            if (menuNumber == 1)
            {
                panel_QuanlySubMenu.Visible = isOpen == 1 ? true : false;
            }
            else if( menuNumber ==2)
            {
                panel_hoadonSubMenu.Visible = isOpen == 1 ? true : false;
            }
            else
            {
                panel_tksubmenu.Visible = isOpen == 1 ? true : false;
            }

        }
        // ân
        private void HideMenu()
        {
            if (panel_QuanlySubMenu.Visible == true)
            {
                panel_QuanlySubMenu.Visible = false;
            }
            if (panel_hoadonSubMenu.Visible == true)
            {
                panel_hoadonSubMenu.Visible = false;
            }
            if (panel_tksubmenu.Visible == true)
            {
                panel_tksubmenu.Visible = false;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_QuanlySubMenu);
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

        private void btn_hd_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_hoadonSubMenu);
        }
        // mở form con
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

        private void btn_hh_Click(object sender, EventArgs e)
        {
            openPanelchild(new Hanghoa(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(0, 3);
        }


        private void btn_cv_Click(object sender, EventArgs e)
        {

            openPanelchild(new Congviec(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(0, 3);
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {

            openPanelchild(new Nhanvien(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(0, 3);
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {

            openPanelchild(new Khachhang(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(0, 3);
        }

        private void btn_ncc_Click(object sender, EventArgs e)
        {

            openPanelchild(new NhaCungCap(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(0, 3);
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {

            openPanelchild(new Doanhthu(), sender);
            showSideMenu(1, 1); // hiện
            showSideMenu(0, 3);
            showSideMenu(0, 2); // k hiện
        }

        private void btn_hdn_Click(object sender, EventArgs e)
        {

            openPanelchild(new frmHoaDonNhap(), sender);
            showSideMenu(0, 1); // hiện
            showSideMenu(1, 2); // k hiện
            showSideMenu(0, 3);
        }

        private void btn_hdb_Click(object sender, EventArgs e)
        {

            openPanelchild(new Hoadonban(), sender);
            showSideMenu(0, 1); // hiện
            showSideMenu(1, 2); // k hiện
            showSideMenu(0, 3);

        }

        private void btn_pl_Click(object sender, EventArgs e)
        {
            HideMenu();
            openPanelchild(new Phanloai(), sender);
        }

        private void btn_dx_Click_1(object sender, EventArgs e)
        {
            HideMenu();
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                login login = new login();
                login.Show();
            }
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_tksubmenu);
        }

        private void btn_tkhdn_Click(object sender, EventArgs e)
        {
            openPanelchild(new TimHDNhap(), sender);
            showSideMenu(0, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(1, 3);
        }

        private void btn_tkhdb_Click(object sender, EventArgs e)
        {
          
            openPanelchild(new TKHDB(), sender);
            showSideMenu(0, 1); // hiện
            showSideMenu(0, 2); // k hiện
            showSideMenu(1, 3);
        }
    }
}

