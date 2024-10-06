using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // ----------BAI 1: VIET CHUONG TRINH GIAI TIM TONG HAI SO, TICH HAI SO, HIEU HAI SO--------------
            /*
            const int hangSo1 = 10;
            const int hangSo2 = 5;
            int tong = hangSo1 + hangSo2;
            int hieu = hangSo1 - hangSo2; 
            int tich = hangSo1 * hangSo2;
            Console.WriteLine("Tong la: {0} + {1} = {2}", hangSo1, hangSo2, tong);
            Console.WriteLine("Hieu la: {0} - {1} = {2}", hangSo1, hangSo2, hieu);
            Console.WriteLine("Tich la: {0} * {1} = {2}", hangSo1, hangSo2, tich);
            */

            // ------------BAI 2-1: VIET CHUONG TRINH GIAI PHUONG TRINH BAC MOT AX + B = 0--------------------
            /*
            float a, b, c, x;
            Console.WriteLine("Xin moi nhap so a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Xin moi nhap so b: ");
            b = float.Parse(Console.ReadLine());  
            if (a != 0) 
            {
                x = (-b) / a;
                Console.WriteLine("Phuong trinh bac nhat {0}x + {1} = 0 co nghiem x la: {2}", a, b, x);
            }
            else if (a == 0 && b != 0) 
            {
                Console.WriteLine("Phuong trinh bac nhat {0}x + {1} = 0 vo nghiem", a, b);
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh bac nhat {0}x + {1} = 0 co nghiem dung voi moi x", a, b);
            }
            else 
            {
                console.Writeline("Khong ton tai truong hop nay !");
            }
            */

            // -----------BAI 2-2: VIET CHUONG TRINH GIAI PHUONG TRINH BAC HAI (2X2 + 3X + 1 = 0)---------------
            /*
            int a = 2, b = 3, c = 1;
            double delta, x1, x2;
            delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh {0}x2 + {1}x + {2} = 0 vo nghiem", a, b, c);
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Phuong trinh {0}x2 + {1}x + {2} = 0 co nghiem kep x1 = x2 = {3}", a, b, c, x1);
            }
            else if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("Phuong trinh {0}x2 + {1}x + {2} = 0 co hai nghiem la x1 = {3} va x2 = {4}", a, b, c, x1, x2);
            }
            else if (a + b + c == 0)
            {
                x1 = 1;
                x2 = c / a;
                Console.WriteLine("Phuong trinh {0}x2 + {1}x + {2} = 0 co x1 = {3} va x2 = {4}", a, b, c, x1, x2);
            }
            else if (a - b + c == 0)
            {
                x1 = -1;
                x2 = -c / a;
                Console.WriteLine("Phuong trinh {0}x2 + {1}x + {2} = 0 co x1 = {3} va x2 = {4}", a, b, c, x1, x2);
            }
            else 
            {
                Console.WriteLine("Khong ton tai truong hop nay !");
            }
            */

            // ---------------------------BAI 3: DOI DO C SANG DO K VA DO F------------------------------
            /*
            Console.WriteLine("Xin hay nhap vao do C");
            double doC = double.Parse(Console.ReadLine());
            double doK = doC + 273;
            double doF = doC * 1.8 + 32;
            Console.WriteLine("{0} do C bang {1} do K va {2} do F", doC, doK, doF);
            */

            // -----------------------BAI 4: TINH GIAI THUA CUA MOT SO----------------------------
            /*
            int giaiThua = 1;
            int n;
            Console.WriteLine("Moi nhap vao mot so tu nhien");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;               
            }
            Console.WriteLine("{0}! = {1}", n, giaiThua);
            */


            Console.ReadKey();
        }
    }
}
