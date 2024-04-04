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
    public partial class FTrangChu : Form
    {
        public FTrangChu()
        {
            InitializeComponent();
        }
        private void FTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void ucChonKS2_Click(object sender, EventArgs e)
        {
            FKhachSan fkhachsan = new FKhachSan();
            fkhachsan.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FKhachSan fkhachsan = new FKhachSan();
            fkhachsan.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuRating4_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }

        private void bunifuRating3_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {

        }
    }
}
