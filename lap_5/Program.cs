using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_5
{
        // bai_1
        public class PhanSo
        {
            public int tuSo { get; set; }
            public int mauSo { get; set; }

            public PhanSo(int tuSo, int mauSo)
            {
                this.tuSo = tuSo;
                this.mauSo = mauSo;
            }
            public static PhanSo operator + (PhanSo ps1, PhanSo ps2)
            {
                int tuSoMoi = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
                int mauSoMoi = ps1.mauSo * ps2.mauSo;
                return new PhanSo(tuSoMoi, mauSoMoi);
            }

            public static PhanSo operator - (PhanSo ps1, PhanSo ps2)
            {
                int tuSoMoi = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
                int mauSoMoi = ps1.mauSo * ps2.mauSo;
                return new PhanSo(tuSoMoi, mauSoMoi);
            }

            public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
            {
                int tuSoMoi = ps1.tuSo * ps2.tuSo;
                int mauSoMoi = ps1.mauSo * ps2.mauSo;
                return new PhanSo(tuSoMoi, mauSoMoi);
            }

            public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
            {
                int tuSoMoi = ps1.tuSo * ps2.mauSo;
                int mauSoMoi = ps1.mauSo * ps2.tuSo;
                return new PhanSo(tuSoMoi, mauSoMoi);
            }
        }
         // bai 2
        public class So
        {
            public double giaTri { get; set; }
            public So(double giaTri)
             {
                this.giaTri = giaTri;
            }
            // nạp chồng toán tử
            public static So operator + (So a, So b)
            {
                double tong = a.giaTri + b.giaTri;
                return new So(tong);
            }
                public static So operator -(So a, So b)
                {
                    double tong = a.giaTri - b.giaTri;
                    return new So(tong);
                }
                public static So operator *(So a, So b)
                {
                    double tong = a.giaTri * b.giaTri;
                    return new So(tong);
                }
                public static So operator /(So a, So b)
                {
                    double tong = a.giaTri / b.giaTri;
                    return new So(tong);
                }
                // phương thức xét số nguyên tố chẵn lẻ
                public  bool check_chan_le (double giaTri)
                {   
                        if (giaTri % 2 == 0)
                        {
                            return true;
                        }else
                        {
                             return false;
                        }
                }
                public bool check_nguyenTo(double giaTri)
                {
                    if (giaTri < 2) return false;
                    for (int i = 2; i <= Math.Sqrt(giaTri); i++)
                    {
                        if (giaTri % 2 == 0) return false;
                        else return false;
                    }
                         return true;
                        
                }


    }
   // bài 3
    class HangHoa
    {
        public int maHang { get; set; }
        public string tenHang { get; set; }
        public double gia { get; set; }

    }
    class KhachHang
    {
        public int maKhach { get; set; }
        public string tenKhach { get; set; }
        public string diaChi { get; set; }
    }
    // lớp hóa đơn kết tập hàng hóa và khác hàng
    class HoaDon
    {
        // kết tập
        private List<HangHoa> danhSachHangHoa;
        private KhachHang KhachHang;
        // constructor
        public HoaDon(List<HangHoa> danhSachHangHoa, KhachHang KhachHang)
        {
            this.danhSachHangHoa = danhSachHangHoa;
            this.KhachHang = KhachHang;
        }
        public void them (HangHoa hangHoa)
        {
            danhSachHangHoa.Add(hangHoa);
        }
        public void xoa (HangHoa hangHoa)
        {
            danhSachHangHoa.Remove(hangHoa);

        }
        public double TongTien()
        {
            double tongTien = 0;
            foreach (HangHoa hangHoa in danhSachHangHoa)
            {
                tongTien += hangHoa.gia;
            }
            return tongTien;
        }
        // tìm kiếm giá trị cao nhất rồi hiển thị ra màn hình
        public HangHoa TimHangHoaGiaCaoNhat()
        {
            HangHoa hangHoaGiaCaoNhat = null;
            double giaCaoNhat = 0;
            foreach (HangHoa hangHoa in danhSachHangHoa)
            {
                if (hangHoa.gia > giaCaoNhat)
                {
                    giaCaoNhat = hangHoa.gia;
                    hangHoaGiaCaoNhat = hangHoa;
                }
            }
            return hangHoaGiaCaoNhat;
        }
        public void InHoaDon()
        {
            Console.WriteLine("Mã khách hàng: " + KhachHang.maKhach);
            Console.WriteLine("Tên khách hàng: " + KhachHang.tenKhach);
            Console.WriteLine("Địa chỉ: " + KhachHang.diaChi);
            Console.WriteLine("Danh sách hàng hóa:");
            foreach (HangHoa hangHoa in danhSachHangHoa)
            {
                Console.WriteLine("- " + hangHoa.tenHang + " (" + hangHoa.gia + " đồng)");
            }
            Console.WriteLine("Tổng tiền: " + TongTien() + " đồng");
        }
    }

    internal class Program
    {
          static void Main(string[] args)
          {
            Console.OutputEncoding = Encoding.UTF8;
            string tenHang = Console.ReadLine();
                HangHoa hang_hoa_01 = new HangHoa { 
                tenHang = "Bim Bim",
                gia = 2000.0,
                maHang = 01
                };
            List<HangHoa> hang_hoa = new List<HangHoa>();
            hang_hoa.Add(hang_hoa_01);
            KhachHang khanh_hang = new KhachHang
            {
                tenKhach = "Nguyễn Quốc Khánh",
                maKhach = 01,
                diaChi = "Hưng Yên"
            };
            HoaDon hoadon_1 = new HoaDon(hang_hoa, khanh_hang);
            hoadon_1.InHoaDon();
          }
    }
}

        
