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

namespace DoAnLTW
{
    public partial class FYeuCauDonDat : Form
    {
        DbConnection dbConnection = new DbConnection();
        DatPhongDAO datPhongDAO = new DatPhongDAO();
        PhongDAO phongDAO = new PhongDAO();
        public FYeuCauDonDat()
        {
            InitializeComponent();
        }

        private void FYeuCauDonDat_Load(object sender, EventArgs e)
        {
            dtDonDat.DataSource = dbConnection.Load("SELECT* FROM DatPhong");
        }

        private void dtDonDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtDonDat.Rows[e.RowIndex];
            txtMaDat.Text = selectedRow.Cells["DatPhongID"].Value.ToString();
            txtMaPhong.Text = selectedRow.Cells["PhongID"].Value.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            datPhongDAO.CapNhatTrangThai(txtMaDat.Text, "Hoàn Tất");
            FYeuCauDonDat_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            datPhongDAO.CapNhatTrangThai(txtMaDat.Text, "Không Hoàn Tất");
            phongDAO.CapNhatTangSoPhong(txtMaPhong.Text);
            FYeuCauDonDat_Load(sender, e);
        }
    }
}
