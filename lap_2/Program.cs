using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bai 1
            Console.OutputEncoding = Encoding.UTF8;
            /*
              int n;
             Console.WriteLine("Nhập n: ");
             n = int.Parse(Console.ReadLine());
             int sum = 0;
             for (int i = 0; i <= n; i+= 2)
             {
                 sum += i;
             }
             Console.WriteLine(sum);
              // bài 2
                int n;
                Console.WriteLine("Nhập n: ");
                n = int.Parse(Console.ReadLine());
                double sum = 0;
                for (double i = 1; i <= n; i++)
                {
                    sum += 1 / i;
                }
                Console.WriteLine(sum);
            // bai 3: kt số nguyên tố
            int n;
            Console.WriteLine("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int dem_uoc = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem_uoc++;
                }
            }
            if (dem_uoc == 2)
            {
                Console.WriteLine("Đây là số nguyên tố");
            }else
            {
                Console.WriteLine("Đây không phải số nguyên tố");
            }
             // bai 4
            int a, b, c;
            Console.WriteLine("Nhập Cạnh 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Cạnh 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Cạnh 3: ");
            c = int.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > c))
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam Giác Đều");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Tam Giác Cân");
                }
                else
                {
                    Console.WriteLine("Tam Giác Thường");
                }
            }
            else
            {
                Console.WriteLine("Đây Không Phải Tam Giác");
            }
            // in ra dãy số pibolaci
            int n;
            Console.WriteLine("Nhập n: ");
            n = int.Parse(Console.ReadLine());
            int luu = 0, f0 = 0, f1 = 1;
            for (int i = 1; i < n; i++)
            {
                luu = f0 + f1;
                Console.Write(luu + " ");
                f0 = f1;
                f1 = luu;
            }
            Console.WriteLine();
             */
           
        }
    }
}
