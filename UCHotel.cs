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
    public partial class UCHotel : UserControl
    {
        public UCHotel()
        {
            InitializeComponent();
            this.MouseMove += UCHotel_MouseMove;
            this.MouseLeave += UCHotel_MouseLeave;
            this.Click += UCHotel_Click;
        }

        private void UCHotel_Click(object sender, EventArgs e)
        {
            FSuaThongTinKS fKS = new FSuaThongTinKS();
            fKS.ShowDialog();
        }

        private void UCHotel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void UCHotel_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Turquoise;
        }

    }
}
