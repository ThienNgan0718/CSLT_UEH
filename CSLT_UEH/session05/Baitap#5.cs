using System;
using System.Collections.Generic;
using System.Text;

    class Baitap_5
    {
        // BÀI 1: TÍNH TỔNG HAI SỐ NGUYÊN

        static int TinhTong(int a, int b)
        {
            return a + b;
        }


        // BÀI 2: KIỂM TRA SỐ CHẴN LẺ

        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }


        // BÀI 3: TÌM SỐ LỚN NHẤT TRONG BA SỐ

        static int TimMax(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            return max;
        }


        // BÀI 4: TÍNH GIAI THỪA

        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;

            for (int i = 1; i <= n; i++)
            {
                ketQua = ketQua * i;
            }

            return ketQua;
        }


        // BÀI 5: ĐẢO NGƯỢC CHUỖI

        static string DaoNguocChuoi(string input)
        {
            char[] mang = input.ToCharArray();

            Array.Reverse(mang);

            return new string(mang);
        }


        // BÀI 6: KIỂM TRA SỐ NGUYÊN TỐ

        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        // BÀI 7: IN DÃY FIBONACCI

        static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }


        // BÀI 8: ĐẾM SỐ LƯỢNG NGUYÊN ÂM

        static int DemNguyenAm(string s)
        {
            int dem = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = char.ToLower(s[i]);

                if (c == 'a' || c == 'e' || c == 'i' ||
                    c == 'o' || c == 'u')
                {
                    dem++;
                }
            }

            return dem;
        }


        // BÀI 9: TÍNH LŨY THỪA

        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;

            for (int i = 1; i <= y; i++)
            {
                ketQua = ketQua * x;
            }

            return ketQua;
        }


        // BÀI 10: TÍNH ĐIỂM TRUNG BÌNH CỦA MẢNG

        static double TinhTrungBinh(int[] arr)
        {
            int tong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tong = tong + arr[i];
            }

            return (double)tong / arr.Length;
        }


        // BÀI 11: KIỂM TRA CHUỖI ĐỐI XỨNG

        static bool KiemTraDoiXung(string s)
        {
            int trai = 0;
            int phai = s.Length - 1;

            while (trai < phai)
            {
                if (s[trai] != s[phai])
                {
                    return false;
                }

                trai++;
                phai--;
            }

            return true;
        }


        // BÀI 12: CHUYỂN ĐỔI NHIỆT ĐỘ

        static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }


        // BÀI 13: TÌM GIÁ TRỊ NHỎ NHẤT TRONG MẢNG

        static int TimMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }


        // BÀI 14: TÍNH TỔNG CÁC CHỮ SỐ

        static int TongCacChuSo(int n)
        {
            int tong = 0;

            while (n > 0)
            {
                int chuSo = n % 10;

                tong = tong + chuSo;

                n = n / 10;
            }

            return tong;
        }


        // BÀI 15: SẮP XẾP MẢNG TĂNG DẦN
        static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }


        // BÀI 16: XÓA KÝ TỰ TRÙNG LẶP
        static string XoaTrungLap(string s)
        {
            string ketQua = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!ketQua.Contains(s[i]))
                {
                    ketQua = ketQua + s[i];
                }
            }

            return ketQua;
        }


        // BÀI 17: TÌM ƯỚC CHUNG LỚN NHẤT
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }


        // BÀI 18: CHUYỂN THẬP PHÂN SANG NHỊ PHÂN

        static string DecimalToBinary(int n)
        {
            if (n == 0)
            {
                return "0";
            }

            string ketQua = "";

            while (n > 0)
            {
                int du = n % 2;

                ketQua = du + ketQua;

                n = n / 2;
            }

            return ketQua;
        }

        // BÀI 19: KIỂM TRA NĂM NHUẬN

        static bool KiemTraNamNhuan(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }

            if (year % 100 == 0)
            {
                return false;
            }

            if (year % 4 == 0)
            {
                return true;
            }

            return false;
        }


        // BÀI 20: ĐẾM SỐ TỪ TRONG CÂU

        static int DemSoTu(string sentence)
        {
            string[] mangTu = sentence.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            return mangTu.Length;
        }

        public static void Run()
        {
            int chon;

            do
            {
                Console.Clear();
                Console.WriteLine("       CHUONG TRINH 20 BAI TAP C#");

                Console.WriteLine(" 1. Tinh tong hai so");
                Console.WriteLine(" 2. Kiem tra so chan le");
                Console.WriteLine(" 3. Tim so lon nhat trong ba so");
                Console.WriteLine(" 4. Tinh giai thua");
                Console.WriteLine(" 5. Dao nguoc chuoi");
                Console.WriteLine(" 6. Kiem tra so nguyen to");
                Console.WriteLine(" 7. In day Fibonacci");
                Console.WriteLine(" 8. Dem so luong nguyen am");
                Console.WriteLine(" 9. Tinh luy thua");
                Console.WriteLine("10. Tinh diem trung binh cua mang");
                Console.WriteLine("11. Kiem tra chuoi doi xung");
                Console.WriteLine("12. Chuyen Celsius sang Fahrenheit");
                Console.WriteLine("13. Tim gia tri nho nhat trong mang");
                Console.WriteLine("14. Tinh tong cac chu so");
                Console.WriteLine("15. Sap xep mang tang dan");
                Console.WriteLine("16. Xoa ky tu trung lap");
                Console.WriteLine("17. Tim UCLN");
                Console.WriteLine("18. Chuyen thap phan sang nhi phan");
                Console.WriteLine("19. Kiem tra nam nhuan");
                Console.WriteLine("20. Dem so tu trong cau");
                Console.WriteLine(" 0. Thoat");

                Console.Write("Chon bai: ");

                chon = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap a: ");
                        int a1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap b: ");
                        int b1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Tong = {TinhTong(a1, b1)}");
                        break;

                    case 2:
                        Console.Write("Nhap n: ");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        if (KiemTraChan(n2))
                            Console.WriteLine($"{n2} la so chan.");
                        else
                            Console.WriteLine($"{n2} la so le.");
                        break;

                    case 3:
                        Console.Write("Nhap a: ");
                        int a3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap b: ");
                        int b3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap c: ");
                        int c3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"So lon nhat = {TimMax(a3, b3, c3)}");
                        break;

                    case 4:
                        Console.Write("Nhap n: ");
                        int n4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"{n4}! = {TinhGiaiThua(n4)}");
                        break;

                    case 5:
                        Console.Write("Nhap chuoi: ");
                        string chuoi5 = Console.ReadLine();

                        Console.WriteLine($"Chuoi dao nguoc: {DaoNguocChuoi(chuoi5)}");
                        break;

                    case 6:
                        Console.Write("Nhap n: ");
                        int n6 = Convert.ToInt32(Console.ReadLine());

                        if (KiemTraNguyenTo(n6))
                            Console.WriteLine($"{n6} la so nguyen to.");
                        else
                            Console.WriteLine($"{n6} khong phai la so nguyen to.");
                        break;

                    case 7:
                        Console.Write("Nhap n: ");
                        int n7 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Day Fibonacci: ");
                        InFibonacci(n7);
                        break;

                    case 8:
                        Console.Write("Nhap chuoi: ");
                        string chuoi8 = Console.ReadLine();

                        Console.WriteLine($"So luong nguyen am = {DemNguyenAm(chuoi8)}");
                        break;

                    case 9:
                        Console.Write("Nhap x: ");
                        double x9 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nhap y: ");
                        int y9 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Ket qua = {TinhLuyThua(x9, y9)}");
                        break;

                    case 10:
                        Console.Write("Nhap so phan tu cua mang: ");
                        int n10 = Convert.ToInt32(Console.ReadLine());

                        int[] arr10 = new int[n10];

                        for (int i = 0; i < arr10.Length; i++)
                        {
                            Console.Write($"arr[{i}] = ");
                            arr10[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine($"Trung binh = {TinhTrungBinh(arr10)}");
                        break;

                    case 11:
                        Console.Write("Nhap chuoi: ");
                        string s11 = Console.ReadLine();

                        if (KiemTraDoiXung(s11))
                            Console.WriteLine("Chuoi doi xung.");
                        else
                            Console.WriteLine("Chuoi khong doi xung.");
                        break;

                    case 12:
                        Console.Write("Nhap nhiet do Celsius: ");
                        double c12 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(
                            $"Nhiet do Fahrenheit = {CelsiusToFahrenheit(c12)}"
                        );
                        break;

                    case 13:
                        Console.Write("Nhap so phan tu cua mang: ");
                        int n13 = Convert.ToInt32(Console.ReadLine());

                        int[] arr13 = new int[n13];

                        for (int i = 0; i < arr13.Length; i++)
                        {
                            Console.Write($"arr[{i}] = ");
                            arr13[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine($"Gia tri nho nhat = {TimMin(arr13)}");
                        break;

                    case 14:
                        Console.Write("Nhap so nguyen: ");
                        int n14 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Tong cac chu so = {TongCacChuSo(n14)}");
                        break;

                    case 15:
                        Console.Write("Nhap so phan tu cua mang: ");
                        int n15 = Convert.ToInt32(Console.ReadLine());

                        int[] arr15 = new int[n15];

                        for (int i = 0; i < arr15.Length; i++)
                        {
                            Console.Write($"arr[{i}] = ");
                            arr15[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.Write("Mang sau khi sap xep: ");
                        SapXepMang(arr15);
                        break;

                    case 16:
                        Console.Write("Nhap chuoi: ");
                        string s16 = Console.ReadLine();

                        Console.WriteLine(
                            "Chuoi sau khi xoa trung lap: {XoaTrungLap(s16)}"
                        );
                        break;

                    case 17:
                        Console.Write("Nhap a: ");
                        int a17 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap b: ");
                        int b17 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"UCLN = {UCLN(a17, b17)}");
                        break;

                    case 18:
                        Console.Write("Nhap so thap phan: ");
                        int n18 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"So nhi phan = {DecimalToBinary(n18)}");
                        break;

                    case 19:
                        Console.Write("Nhap nam: ");
                        int year19 = Convert.ToInt32(Console.ReadLine());

                        if (KiemTraNamNhuan(year19))
                            Console.WriteLine($"{year19} la nam nhuan.");
                        else
                            Console.WriteLine($"{year19} khong phai la nam nhuan.");
                        break;

                    case 20:
                        Console.Write("Nhap cau: ");
                        string sentence20 = Console.ReadLine();

                        Console.WriteLine($"So tu trong cau = {DemSoTu(sentence20)}");
                        break;

                    case 0:
                        Console.WriteLine("Da thoat chuong trinh!");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }

                if (chon != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Nhan phim bat ky de quay lai menu...");
                    Console.ReadKey();
                }

            } while (chon != 0);
        }
}