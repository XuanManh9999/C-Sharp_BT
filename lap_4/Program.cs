using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap_4
{
    class Nguoi
    {
        public string Hoten { get; set; }
        public string cmnd { get; set; }
        public string queQuan { get; set; }
        public string GhiChu { get; set; }
        // nạp chồng tostring
        public string toString()
        {
            return $"Họ Tên: {Hoten} CMND: {cmnd} Quê Quán: {queQuan} Ghi Chú: {GhiChu} + \n ";
        }

    }
    class SinhVien1 : Nguoi
    {
        public string maSv { get; set; }
        // hiển thị thông tin
        public string Sv1_in()
        {
            return $"Mã Sinh Viên: {maSv} {toString()} ";
        }
    }
    class SinhVien2
    {
        public Nguoi ketTapNguoi { get; set; }// thuộc tính
        public string maSV { get; set; }
        public string caNhan { get; set; }
        public string sv2_in()
        {
            return $"Mã Sinh Viên {maSV} \n Cá Nhân {caNhan} \n  {ketTapNguoi.toString()}";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var sv1 = new SinhVien1
            {
                Hoten = "Nguyễn Xuân Mạnh",
                cmnd = "001203031721",
                queQuan = "Ba Vì Hà Nội",
                GhiChu = "ABC",
                maSv = "20210794",
            };
            Console.WriteLine(sv1.Sv1_in());
            var sv2 = new SinhVien2
            {
                ketTapNguoi = new Nguoi
                {
                    Hoten = "Nguyễn Xuân Mạnh",
                    cmnd = "001203031721",
                    GhiChu = "Ahihi",
                    queQuan = "Ba Vì Hà"
                },
                maSV = "20210794",
                caNhan = "Nguyễn Xuân Mạnh"
            };
            Console.WriteLine(sv2.sv2_in());

        }
    }
}
