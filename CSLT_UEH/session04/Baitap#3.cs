using System;
using System.Collections.Generic;
using System.Text;

    internal class Baitap_3
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Ex1();
            Ex_2a();
            Ex_2b();
            Ex_2c();
            Ex_2d();
        }
        static void Ex1()
        {
            Console.Write("Nhập a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình có nghiệm x = {x}");
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
            }
        }
        static void Ex_2a()
        {
            Console.Write("Nhập một số: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Số chẵn.");
            else
                Console.WriteLine("Số lẻ.");
        }
        static void Ex_2b()
        {
            Console.Write("Nhập số thứ nhất: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ ba: ");
            double c = double.Parse(Console.ReadLine());

            double max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            Console.WriteLine($"Số lớn nhất là: {max}");
        }
        static void Ex_2c()
        {
            Console.Write("Nhập cạnh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Không phải tam giác.");
            }
            else if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Không phải tam giác.");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tam giác cân.");
            }
            else
            {
                Console.WriteLine("Tam giác thường.");
            }
        }
        static void Ex_2d()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhập y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong góc phần tư thứ nhất");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong góc phần tư thứ hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong góc phần tư thứ ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong góc phần tư thứ tư");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Điểm nằm tại gốc tọa độ");
            }
            else
            {
                Console.WriteLine("Điểm nằm trên trục tọa độ.");
            }
        }

}