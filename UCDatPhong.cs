using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class UCDatPhong : UserControl
    {
        public UCDatPhong()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            FDatPhong fDatPhong = new FDatPhong();
            fDatPhong.ShowDialog();
        }
    }
}
