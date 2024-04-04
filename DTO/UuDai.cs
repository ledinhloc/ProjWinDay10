using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTW.DTO
{
    public class UuDai
    {
        private string khachSanID;
        private string maUuDai;
        private decimal phanTram;
        private int hSD;

        public UuDai(string khachSanID, string maUuDai, decimal phanTram, int hSD)
        {
            this.KhachSanID = khachSanID;
            this.MaUuDai = maUuDai;
            this.PhanTram = phanTram;
            this.HSD = hSD;
        }

        public string KhachSanID { get => khachSanID; set => khachSanID = value; }
        public string MaUuDai { get => maUuDai; set => maUuDai = value; }
        public decimal PhanTram { get => phanTram; set => phanTram = value; }
        public int HSD { get => hSD; set => hSD = value; }
    }
}
