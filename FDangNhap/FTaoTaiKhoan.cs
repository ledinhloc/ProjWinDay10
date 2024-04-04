using DoAnLTW.DAL;
using DoAnLTW.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTW
{
    public partial class FTaoTaiKhoan : Form
    {
        public FTaoTaiKhoan()
        {
            InitializeComponent();
        }
        string image = "";
        NguoiDung nd;
        NguoiDungDAO nguoiDao = new NguoiDungDAO();
        KhachSanDAO khachSanDao = new KhachSanDAO();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image = openFile.FileName;
                picNguoiDung.Image = Image.FromFile(image);
            }
        }
        private void CopyImageToFolder(string sourceFilePath)
        {
            try
            {
                // Kiểm tra xem đường dẫn nguồn có tồn tại không.
                if (File.Exists(sourceFilePath))
                {
                    // Lấy tên tệp từ đường dẫn nguồn.
                    string fileName = Path.GetFileName(sourceFilePath);

                    // Kết hợp đường dẫn của thư mục đích với tên tệp.
                    string pathImage = Path.Combine(pathPro(), "Resources");
                    string fileInImage = Path.Combine(pathImage, fileName);

                    // Sao chép tệp từ đường dẫn nguồn đến đường dẫn đích.
                    if (!File.Exists(fileInImage))
                        File.Copy(sourceFilePath, fileInImage, true);
                }
                else
                {
                    MessageBox.Show("Đường dẫn nguồn không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string pathPro()
        {
            // Lấy đối tượng Assembly của assembly hiện tại
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Lấy đường dẫn đầy đủ của file thực thi (bao gồm cả tên file)
            string assemblyLocation = assembly.Location;

            // Lấy đường dẫn thư mục cha của file thực thi
            string debug = Path.GetDirectoryName(assemblyLocation);
            string bin = Path.GetDirectoryName(debug);
            string proj = Path.GetDirectoryName(bin);
            return proj;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (!string.IsNullOrEmpty(image))
            {
                CopyImageToFolder(image);
                fileName = Path.GetFileName(image);
            }

            if (checkBoxKS.Checked == false)
            {
                string idKhach = nguoiDao.LayIDTiepTheo();
                string gioiTinh = rbtNam.Checked == true ? "Nam" : "Nu";
                nd = new NguoiDung(idKhach, txtHovaTen.Text, txtCMND.Text, dtpNgaySinh.Value, gioiTinh, txtDiaChi.Text, txtDienThoai.Text,
                    txtEmail.Text, txtTenDN.Text, txtMatKhau.Text, fileName, null);
            }
            else
            {
                string idKhach = nguoiDao.LayIDTiepTheo();
                string idKS = khachSanDao.LayIDTiepTheo();
                khachSanDao.ThemKhachSanID(idKS);
                string gioiTinh = rbtNam.Checked == true ? "Nam" : "Nu";
                nd = new NguoiDung(idKhach, txtHovaTen.Text, txtCMND.Text, dtpNgaySinh.Value, gioiTinh, txtDiaChi.Text, txtDienThoai.Text,
                    txtEmail.Text, txtTenDN.Text, txtMatKhau.Text, fileName, idKS);
            }
            bool kq = nguoiDao.Them(nd);
            if (kq == true)
            {
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }
    }
}
