using Bunifu.UI.WinForms;
using DoAnLTW.DAL;
using DoAnLTW.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace DoAnLTW
{
    public partial class FThongTinKhachSan : Form
    {
        string filesText = "";
        string tienNghi = "";
        private List<Image> images = new List<Image>();
        private int currentIndex = 0;
        KhachSanDAO khachSanDAO = new KhachSanDAO();
        KhachSan ks;
        public FThongTinKhachSan()
        {
            InitializeComponent();
            LayThongTinKS();
        }
        public void LayThongTinKS()
        {
            // Lấy thông tin khách sạn
            ks = khachSanDAO.LayThongTinRieng(BienDungChung.idNguoiDung.Khachsanid);
            txtLoaiKS.Text = ks.Loai;
            txtTenKhachSan.Text = ks.TenKhachSan;
            txtDiaChi.Text = ks.DiaChi;
            txtMoTa.Text = ks.TongQuan;
            rDanhGia.Value = ks.Sao;
            tienNghi = ks.TienNghi;
            CheckItemsFromString(tienNghi);
            filesText = ks.HinhAnh;
            HienThiAnh(filesText);
            cbHinhThucThanhToan.SelectedItem = ks.HinhThucThanhToan;
            txtTinh.Text = ks.Tinh;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                tienNghi = GetCheckedValuesAsString();
                KhachSan ks = new KhachSan(BienDungChung.idNguoiDung.Khachsanid, txtTenKhachSan.Text, txtDiaChi.Text
                    , txtMoTa.Text, rDanhGia.Value, tienNghi, filesText, cbHinhThucThanhToan.Text, txtLoaiKS.Text, txtTinh.Text);
                if (khachSanDAO.CapNhat(ks))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private string GetCheckedValuesAsString()
        {
            // Tạo một chuỗi để lưu trữ các giá trị của các ô đã được chọn, cách nhau bởi dấu phẩy
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

        private void CheckItemsFromString(string checkedValuesString)
        {
            // Phân tách chuỗi vào các giá trị bằng dấu phẩy
            string[] fileArray = tienNghi.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            // Duyệt qua tất cả các mục trong CheckedListBox
            for (int i = 0; i < clbTienNghi.Items.Count; i++)
            {
                string itemName = clbTienNghi.Items[i].ToString();
                if (fileArray.Contains(itemName))
                {
                    // Nếu giá trị của mục đó có trong fileArray, đánh dấu nó trong CheckedListBox
                    clbTienNghi.SetItemChecked(i, true);
                }
            }
            // Kiểm tra xem giá trị của mục thứ i có trong danh sách giá trị đã phân tách không

        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            filesText = "";
            images.Clear();
            currentIndex = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    // Lấy tên của tệp
                    string fileName = Path.GetFileName(filePath);

                    // Tìm vị trí của dấu "." cuối cùng trong tên tệp
                    int lastDotIndex = fileName.LastIndexOf('.');
                    if (lastDotIndex != -1)
                    {
                        // Cắt chuỗi từ đầu đến vị trí của dấu "."
                        string trimmedFileName = fileName.Substring(0, lastDotIndex);

                        // Thêm vào chuỗi chứa tên các tệp (đã được cắt bỏ phần sau dấu ".")
                        filesText += trimmedFileName + ",";
                    }
                    else
                    {
                        // Nếu không tìm thấy dấu ".", thêm tên tệp nguyên thủy vào chuỗi
                        filesText += fileName + ",";
                    }

                }
                MessageBox.Show("Thêm ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dấu phẩy cuối cùng nếu có
                if (!string.IsNullOrEmpty(filesText))
                {
                    filesText = filesText.Remove(filesText.Length - 1);
                }
                HienThiAnh(filesText);
            }
        }

        private void btnChuyenTrai_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowCurrentImage();
            }         
        }
        private void btnChuyenPhai_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                currentIndex++;
                ShowCurrentImage();
            }
        }
        private void ShowCurrentImage()
        {        
            pictureBox1.Image = images[currentIndex];
        }
        private void HienThiAnh(string danhSachAnh)
        {
            ResourceManager resourceManager = new ResourceManager("DoAnLTW.Properties.Resources", typeof(DoAnLTW.Properties.Resources).Assembly);
            string[] fileArray = danhSachAnh.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string fileName in fileArray)
            {
                // Kiểm tra xem tệp có tồn tại không
                if (resourceManager.GetObject(fileName) != null)
                {
                    images.Add((Image)Properties.Resources.ResourceManager.GetObject(fileName));
                }
                else
                {
                    MessageBox.Show($"File {fileName} không tồn tại hoặc không có PictureBox khả dụng.");
                }
            }
            ShowCurrentImage();
        }
    }
}
