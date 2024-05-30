using QLMP.FORMS;
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
    public partial class dnhap : Form
    {
       
        public dnhap()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.ShowDialog(); 
            // show khác showdialog vì khi dùng show thì nhấn dnhap thì form dnhap vẫn sdung được
            // dùng showdialog thì không thao tác được với form dnhap khi form home hiển thị:v
            this.Hide();// ẩn form đăng nhập
           
        }

        private void linklb_taotk_Click(object sender, EventArgs e)
        {
            dangky dk = new dangky();
            dk.ShowDialog();
            
            this.Hide();
        }

        private void txt_tk_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
