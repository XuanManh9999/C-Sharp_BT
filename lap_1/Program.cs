// Lap 1: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
              // bài 1
            Console.WriteLine("Rằm Tháng Giêng " +
            "\n" + "Rằm xuân lồng lộng trăng soi,"
            +"\n" + "Sông xuân nước lẫn màu trời thêm xuân." 
            + "\n" + "Giữa dòng bàn bạc việc quân"
            + "\n" + "Khuya về bát ngát trăng ngân đẩy thuyền."
            + "\n" + "Hồ Chí Minh.");
            // bài 2
            Console.WriteLine("----------------------------");
            double h, r;
            Console.WriteLine("Nhập vào chiều cao: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào bán kính: ");
            r = double.Parse(Console.ReadLine());
            double dienTichXungQuanh = 2 * Math.PI * r * h;
            double theTich = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("Diện Tích Xung Quanh: {0}", dienTichXungQuanh);
            Console.WriteLine("Thể Tích Hình Tru: {0}", theTich);
            // bài 3
            Console.WriteLine("Nhập Vào Một Số: ");
            int lc = int.Parse(Console.ReadLine());
            string _lc = lc.ToString();
            string res = "";
            for (int i = 0; i < _lc.Length; i++)
            {
                switch (_lc[i])
                {
                    case '0':
                        res += " Không ";
                        break;
                    case '1':
                        res += " Một ";
                        break;
                    case '2':
                        res += " Hai ";
                        break;
                    case '3':
                        res += " Ba ";
                        break;
                    case '4':
                        res += " Bốn ";
                        break;
                    case '5':
                        res += " Năm ";
                        break;
                    case '6':
                        res += " Sáu ";
                        break;
                    case '7':
                        res += " Bảy ";
                        break;
                    case '8':
                        res += " Tám ";
                        break;
                    case '9':
                        res += " Chín ";
                        break;
                    default:
                        Console.WriteLine("ERR");
                        break;
                }
            }
            Console.WriteLine(res);
            Console.ReadLine();
             */
            // bai 4
            int lc;
        back:
            Console.WriteLine("1 tam giác vuông đặc: "
            + "\n" + "2 tam giác vuông rỗng, " +
            "\n" + "3 là hình vuông rỗng. "
            + "\n" + "Nhập Vào Lựa Chọn: ");
            lc = int.Parse(Console.ReadLine());
            switch (lc)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int dem = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            if (i == 0 || i == 1 || i == 4)
                            {
                                Console.Write("*");
                            }
                            else if (i == 2 || i == 3)
                            {
                                if (j == 0 || j == i)
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == 0 || i == 4 || j == 0 || j == 4)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Khong hop le");
                    break;
            }
            Console.ReadLine();
        }
    }
}

