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
    public partial class UCHotelAdmin : UserControl
    {
        public UCHotelAdmin()
        {
            InitializeComponent();
            for(int i = 0; i < 15; i++)
            {
                panel.Controls.Add(new UCHotel());
            }
            UCHotel uCHotel = new UCHotel();
            panel.Controls.Add(uCHotel);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
