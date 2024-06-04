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
    public partial class TimkiemHD : Form
    {
        private string mahd;
        public TimkiemHD(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;

        }

        private void TimkiemHD_Load(object sender, EventArgs e)
        {
            
        }
    }
}
