using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DoAnLTW
{
    public class ThaoTacAnh
    {
        static public string ThemAnh()
        {
            string fileAnh = "";

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
                        fileAnh += trimmedFileName + ",";
                    }
                    else
                    {
                        // Nếu không tìm thấy dấu ".", thêm tên tệp nguyên thủy vào chuỗi
                        fileAnh += fileName + ",";
                    }

                }
                MessageBox.Show("Thêm ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dấu phẩy cuối cùng nếu có
                if (!string.IsNullOrEmpty(fileAnh))
                {
                    fileAnh = fileAnh.Remove(fileAnh.Length - 1);
                }
            }
            return fileAnh;
        }
        static public List<Image> TachAnh(string danhSachAnh)
        {
            List<Image> images = new List<Image>();
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
            return images;
        }
    }
}
