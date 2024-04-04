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

namespace DoAnLTW.FQuanLyKS
{
    public partial class FThemUuDai : Form
    {
        DbConnection dbConnection = new DbConnection();
        UuDaiDAO uuDaiDAO = new UuDaiDAO();
        public FThemUuDai()
        {
            InitializeComponent();
        }

        private void FThemUuDai_Load(object sender, EventArgs e)
        {
            dtUuDai.DataSource = dbConnection.Load("SELECT* FROM UuDai");
        }

        private void dtUuDai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtUuDai.Rows[e.RowIndex];
            txtMaUuDai.Text = selectedRow.Cells["MaUuDai"].Value.ToString();
            txtPhanTram.Text = selectedRow.Cells["PhanTram"].Value.ToString();
            txtHSD.Text = selectedRow.Cells["HSD"].Value.ToString();
        }

        private void btnThemUD_Click(object sender, EventArgs e)
        {
            try
            {
                UuDai ud = new UuDai(BienDungChung.idNguoiDung.Khachsanid, txtMaUuDai.Text,
                    Convert.ToDecimal(txtPhanTram.Text), Convert.ToInt32(txtHSD.Text));
                if (uuDaiDAO.Them(ud))
                {
                    MessageBox.Show("Thêm thành công");
                    FThemUuDai_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                UuDai ud = new UuDai(BienDungChung.idNguoiDung.Khachsanid, txtMaUuDai.Text,
                    Convert.ToDecimal(txtPhanTram.Text), Convert.ToInt32(txtHSD.Text));
                if (uuDaiDAO.Sua(ud))
                {
                    MessageBox.Show("Sửa thành công");
                    FThemUuDai_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (uuDaiDAO.Xoa(txtMaUuDai.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    FThemUuDai_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
