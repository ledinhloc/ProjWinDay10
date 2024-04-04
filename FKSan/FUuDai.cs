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

namespace DoAnLTW.FKSan
{
    public partial class FUuDai : Form
    {
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        List<UCUuDai> listUCUd = new List<UCUuDai>();
        public FUuDai()
        {
            InitializeComponent();
            LayThongTin();
        }
        public void LayThongTin()
        {
            foreach (UuDai ud in uuDaiDAO.LayUDTheoKS(BienDungChung.idKSChon.KhachSanID))
            {
                UCUuDai uCUuDai = new UCUuDai();
                uCUuDai.lblUuDai.Text = "Giảm Đến" + ud.PhanTram;
                uCUuDai.lblHSD.Text = ud.HSD + "";
                uCUuDai.lblMa.Text = ud.MaUuDai + "";
                listUCUd.Add(uCUuDai);               
                pnlUuDai.Controls.Add(uCUuDai);
            }
        }
    }
}
