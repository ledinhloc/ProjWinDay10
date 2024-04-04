using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DoAnLTW.DTO;
using DoAnLTW.DAL;

namespace DoAnLTW
{
    public partial class FPhong : Form
    {
        PhongDAO phongDAO = new PhongDAO();
        DbConnection dbConnection = new DbConnection();
        string fileAnh = "";
        string tienNghi = "";
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;
        public FPhong()
        {
            InitializeComponent();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                tienNghi = GetCheckedValuesAsString();
                Phong PhongNew = new Phong(txtIDPhong.Text, BienDungChung.idNguoiDung.Khachsanid, txtMoTa.Text, txtLoaiPhong.Text, tienNghi, Int32.Parse(txtGia.Text),
                         Decimal.Parse(txtDienTich.Text), Int32.Parse(ucNguoiLon.txtDem.Text), Int32.Parse(ucTreEm.txtDem.Text), 
                         Int32.Parse(ucGiuongLon.txtDem.Text), Int32.Parse(ucGiuongNho.txtDem.Text), fileAnh, Convert.ToInt32(txtSoPhong.Text));
                if (phongDAO.Them(PhongNew))
                {
                    MessageBox.Show("Thêm thành công");
                    FPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm thất bại");
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
                if (phongDAO.Xoa(txtIDPhong.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    FPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại");
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
                tienNghi = GetCheckedValuesAsString();
                Phong PhongNew = new Phong(txtIDPhong.Text, BienDungChung.idNguoiDung.Khachsanid, txtMoTa.Text, txtLoaiPhong.Text, tienNghi, Int32.Parse(txtGia.Text),
                         Decimal.Parse(txtDienTich.Text), Int32.Parse(ucNguoiLon.txtDem.Text), 
                         Int32.Parse(ucTreEm.txtDem.Text), Int32.Parse(ucGiuongLon.txtDem.Text), Int32.Parse(ucGiuongNho.txtDem.Text), fileAnh, Convert.ToInt32(txtSoPhong.Text));
                if (phongDAO.CapNhat(PhongNew))
                {
                    MessageBox.Show("Sửa thành công");
                    FPhong_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void FPhong_Load(object sender, EventArgs e)
        {
            dtPhong.DataSource = dbConnection.Load("SELECT* FROM PHONG");
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            images.Clear();
            currentIndex = 0;
            fileAnh = ThaoTacAnh.ThemAnh();
            images = ThaoTacAnh.TachAnh(fileAnh);
            HienThiAnh();
        }
        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                HienThiAnh();
            }
        }
        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                currentIndex++;
                HienThiAnh();
            }
        }
        private void HienThiAnh()
        {
            pic1.Image = images[currentIndex];
        }
       
        private void CheckItemsFromString(string checkedValuesString)
        {        
            string[] fileArray = tienNghi.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < clbTienNghi.Items.Count; i++)
            {
                string itemName = clbTienNghi.Items[i].ToString();
                if (fileArray.Contains(itemName))
                {
                    clbTienNghi.SetItemChecked(i, true);
                }
            }
        }
        private string GetCheckedValuesAsString()
        {

            string checkedValuesString = "";

            // Duyệt qua tất cả các mục trong CheckedListBox
            for (int i = 0; i < clbTienNghi.Items.Count; i++)
            {
                // Kiểm tra xem mục thứ i có được chọn không
                if (clbTienNghi.GetItemChecked(i))
                {
                    // Nếu được chọn, thêm giá trị của mục này vào chuỗi
                    checkedValuesString += clbTienNghi.Items[i].ToString() + ",";
                }
            }

            // Kiểm tra xem chuỗi có dài hơn 0 ký tự không
            if (!string.IsNullOrEmpty(checkedValuesString))
            {
                // Loại bỏ dấu phẩy cuối cùng nếu có
                checkedValuesString = checkedValuesString.Remove(checkedValuesString.Length - 1);
            }

            // Trả về chuỗi kết quả
            return checkedValuesString;

        }

        private void dtPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dtPhong.Rows[e.RowIndex];
            txtIDPhong.Text = selectedRow.Cells["PhongID"].Value.ToString();
            txtLoaiPhong.Text = selectedRow.Cells["PhanLoai"].Value.ToString();
            txtDienTich.Text = selectedRow.Cells["DienTich"].Value.ToString();
            txtGia.Text = selectedRow.Cells["Gia"].Value.ToString();
            txtSoPhong.Text = selectedRow.Cells["SoPhong"].Value.ToString();
        }
    }
}
