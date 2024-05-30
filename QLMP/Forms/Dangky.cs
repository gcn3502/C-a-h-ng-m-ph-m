using QLMP.Forms;
using System;
using System.Windows.Forms;

namespace QLMP.FORMS
{
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

       

        private void btn_dky_Click(object sender, EventArgs e)
        {
            login dn = new login();
            dn.ShowDialog();
        }
    }
}
