#define PI
using System;
using System.Text;
namespace lap_3
{
    // bai 1
    class So
    {
        public static int cong(int a, int b)
        {
            return a + b;
        }
        public static double cong(double a, double b)
        {
            return a + b;
        }
        // tru
        public static int tru(int a, int b)
        {
            return a - b;
        }
        public static double tru(double a, double b)
        {
            return a - b;
        }
        public static int nhap(int a, int b)
        {
            return a * b;
        }
        public static double nhan(double a, double b)
        {
            return a * b;
        }
        //chia
        public static double chia(double a, double b)
        {
            return a / b;
        }
    }
    // bai 2 

    class TamGiac
    {
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        public TamGiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int chuVi()
        {
            return a + b + c;
        }
        public double dienTich(double chieuDai, double chieuCao)
        {
            return 0.5 * chieuCao * chieuDai;
        }
        public string kiemTraTamGiac()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    return "Tam Giác Đều";

                }
                else if (a == b || b == c || c == a)
                {
                    return "Tam Giác Cân";
                }
                else
                {
                    return "Tam Giác Lệch";
                }
            }
            else
            {
                return "Không Phải Là Tam Giác";
            }
        }
    }
    // bai3
    class SinhVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }

        public SinhVien(string hoTen, int tuoi, string lop, string khoa)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            Lop = lop;
            Khoa = khoa;
        }

        public void HienThi()
        {
            Console.WriteLine("+---------+---------+---------+---------+");
            Console.WriteLine("|   Họ Tên   |   Tuổi   |   Lớp    |   Khoa   |");
            Console.WriteLine("+---------+---------+---------+---------+");
            Console.WriteLine("| {0,-10} | {1,-7} | {2,-8} | {3,-7} |", HoTen, Tuoi, Lop, Khoa);
            Console.WriteLine("+---------+---------+---------+---------+");
        }
    }
    // bai 4
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point otherPoint)
        {
            int xDiff = X - otherPoint.X;
            int yDiff = Y - otherPoint.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }





    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // bai 1
            Console.WriteLine(So.cong(2, 3));
            Console.WriteLine(So.tru(2, 3));
            Console.WriteLine(So.nhan(2, 3));
            Console.WriteLine(So.chia(2, 3));
            // bai 2
            TamGiac tamgiac = new TamGiac(2, 2, 2);
            Console.WriteLine(tamgiac.kiemTraTamGiac());
            // bai 3
            SinhVien sv1 = new SinhVien("Nguyễn Xuân Mạnh", 20, "DCCNTT12.10.3", "Công Nghệ Thông Tin");
            sv1.HienThi();
            // bai 4
            Console.ReadLine();
        }
    }

}

