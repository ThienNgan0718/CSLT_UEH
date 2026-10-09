using System;
using System.Collections.Generic;
using System.Text;

    internal class Baitap_7
    {
        static void Main()
        {
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
            Bai11();
            Bai12();
            Bai13();
        }

        // Bai 1: to input a string and print it.
        static void Bai1()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi vua nhap: {s}");
        }

        // Bai 2: to find the length of a string without using a library function.
        static void Bai2()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            int dem = 0;

            foreach (char c in s)
                dem++;

            Console.WriteLine($"Do dai chuoi: {dem}");
        }

        // Bai 3: to separate individual characters from a string.
        static void Bai3()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
        }

        // Bai 4: to print individual characters of the string in reverse order.
        static void Bai4()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write(s[i]);

            Console.WriteLine();
        }

        // Bai 5: to count the number of words in a string.
        static void Bai5()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            int dem = 0;
            bool trongTu = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    if (!trongTu)
                    {
                        dem++;
                        trongTu = true;
                    }
                }
                else
                    trongTu = false;
            }

            Console.WriteLine("So tu: " + dem);
        }

        // Bai 6: to compare two strings without using a string library functions.
        static void Bai6()
        {
            Console.Write("Nhap chuoi 1: ");
            string s1 = Console.ReadLine();

            Console.Write("Nhap chuoi 2: ");
            string s2 = Console.ReadLine();

            int i = 0;
            bool bangNhau = true;

            while (i < s1.Length && i < s2.Length)
            {
                if (s1[i] != s2[i])
                {
                    bangNhau = false;
                    break;
                }
                i++;
            }

            if (i != s1.Length || i != s2.Length)
                bangNhau = false;

            if (bangNhau)
                Console.WriteLine("Hai chuoi bang nhau");
            else
                Console.WriteLine("Hai chuoi khac nhau");
        }

        // Bai 7: to count the number of alphabets, digits, and special characters in a string
        static void Bai7()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int chu = 0, so = 0, dacBiet = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'A' && s[i] <= 'Z') ||
                    (s[i] >= 'a' && s[i] <= 'z'))
                    chu++;
                else if (s[i] >= '0' && s[i] <= '9')
                    so++;
                else
                    dacBiet++;
            }

            Console.WriteLine($"So chu cai: {chu}");
            Console.WriteLine($"So chu so: {so}");
            Console.WriteLine($"So ky tu dac biet: {dacBiet}");
        }

        // Bai 8: to count the number of vowels and consonants in a string
        static void Bai8()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            int nguyenAm = 0, phuAm = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c >= 'A' && c <= 'Z')
                    c = (char)(c + 32);

                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'a' || c == 'e' || c == 'i' ||
                        c == 'o' || c == 'u')
                        nguyenAm++;
                    else
                        phuAm++;
                }
            }

            Console.WriteLine("So nguyen am: " + nguyenAm);
            Console.WriteLine("So phu am: " + phuAm);
        }

        // Bai 9: to check whether a given substring is present in the given string.
        static void Bai9()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            bool timThay = false;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int j = 0;

                while (j < sub.Length && s[i + j] == sub[j])
                    j++;

                if (j == sub.Length)
                {
                    timThay = true;
                    break;
                }
            }

            if (timThay)
                Console.WriteLine("Co chua chuoi con");
            else
                Console.WriteLine("Khong chua chuoi con");
        }

        // Bai 10: to search for the position of a substring within a string.
        static void Bai10()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            int viTri = -1;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int j = 0;

                while (j < sub.Length && s[i + j] == sub[j])
                    j++;

                if (j == sub.Length)
                {
                    viTri = i;
                    break;
                }
            }

            Console.WriteLine("Vi tri: " + viTri);
        }

        // Bai 11: to check whether a character is an alphabet and not and if so, check for the case.
        static void Bai11()
        {
            Console.Write("Nhap mot ky tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (c >= 'A' && c <= 'Z')
                Console.WriteLine("La chu cai in hoa");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine("La chu cai in thuong");
            else
                Console.WriteLine("Khong phai chu cai tieng Anh");
        }

        // Bai 12: to find the number of times a substring appears in a given string.
        static void Bai12()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi con: ");
            string sub = Console.ReadLine();

            int dem = 0;

            if (sub.Length > 0)
            {
                for (int i = 0; i <= s.Length - sub.Length; i++)
                {
                    int j = 0;

                    while (j < sub.Length && s[i + j] == sub[j])
                        j++;

                    if (j == sub.Length)
                        dem++;
                }
            }

            Console.WriteLine("So lan xuat hien: " + dem);
        }

        // Bai 13: to insert a substring before the first occurrence of a string.
        static void Bai13()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.Write("Nhap chuoi can tim: ");
            string sub = Console.ReadLine();

            Console.Write("Nhap chuoi can chen: ");
            string chen = Console.ReadLine();

            int viTri = -1;

            for (int i = 0; i <= s.Length - sub.Length; i++)
            {
                int j = 0;

                while (j < sub.Length && s[i + j] == sub[j])
                    j++;

                if (j == sub.Length)
                {
                    viTri = i;
                    break;
                }
            }

            if (viTri == -1)
            {
                Console.WriteLine("Khong tim thay chuoi can tim");
            }
            else
            {
                string ketQua = "";

                for (int i = 0; i < viTri; i++)
                    ketQua += s[i];

                ketQua += chen;

                for (int i = viTri; i < s.Length; i++)
                    ketQua += s[i];

                Console.WriteLine($"Chuoi sau khi chen: {ketQua}");
            }
        }
    }
