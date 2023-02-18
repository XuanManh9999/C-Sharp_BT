using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_6_bai2
{
    internal class HangHoa
    {
        public HangHoa() { 
        
        
        }
        public string TenHang { get; set; }
        public string MaHang { get; set; }
        public double GiaHang { get; set; }
        public HangHoa(string TenHang, string MaHang, double GiaHang) { 
            
            this.TenHang = TenHang;
            this.MaHang = MaHang;
            this.GiaHang = GiaHang;
        }
    }
  

}
