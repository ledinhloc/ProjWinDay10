using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;

namespace DoAnLTW
{
    public partial class UCTimDonDat : UserControl
    {
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        public UCTimDonDat()
        {
            InitializeComponent();
        }
        public List<UCTimDonDat> TimPhongDat(string key)
        {
            List<UCTimDonDat> listucPhong = new List<UCTimDonDat>();
            List<DatPhong> dp = datPhongDAO.TimPhongDat(key);
            foreach (DatPhong dp2 in dp)
            {
                UCTimDonDat ucPhong = new UCTimDonDat();
                ucPhong.lblIDdat.Text = dp2.DatPhongID;
                listucPhong.Add(ucPhong);
            }
            return listucPhong;
        }

        private void UCTimDonDat_Click(object sender, EventArgs e)
        {
            BienDungChung.idDatPhong = new DatPhong(this.lblIDdat.Text);
            FChinhSuaPhong fchild = new FChinhSuaPhong();
            fchild.Show();
            this.Hide();
        }
    }
}
