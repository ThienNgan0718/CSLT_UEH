using System;
using System.Collections.Generic;
using System.Text;

    internal class Baitap_8
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
            Bai14();
            Bai15();
        }

        // Bai 1: to create a blank file on the disk.
        static void Bai1()
        {
            string path = "test.txt";

            using (File.Create(path)) { }

            Console.WriteLine("Da tao file rong");
        }

        // Bai 2: to remove a file from the disk.
        static void Bai2()
        {
            string path = "test.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Da xoa file");
            }
            else
                Console.WriteLine("File khong ton tai");
        }

        // Bai 3: to create a file and add some text.
        static void Bai3()
        {
            string path = "test.txt";

            File.WriteAllText(path, "Xin chao C#");

            Console.WriteLine("Da ghi noi dung vao file");
        }

        // Bai 4: create a text file and read it.
        static void Bai4()
        {
            string path = "test.txt";

            File.WriteAllText(path, "Dong 1\nDong 2\nDong 3");

            string noiDung = File.ReadAllText(path);

            Console.WriteLine(noiDung);
        }

        // Bai 5: to create a file and write an array of strings to the file.
        static void Bai5()
        {
            string path = "test.txt";

            string[] ds = { "Dong 1", "Dong 2", "Dong 3" };

            File.WriteAllLines(path, ds);

            Console.WriteLine("Da ghi mang chuoi vao file");
        }

        // Bai 6: to append some text to an existing file.
        static void Bai6()
        {
            string path = "test.txt";

            File.AppendAllText(path, "\nNoi dung duoc them");

            Console.WriteLine("Da them noi dung");
        }

        // Bai 7: to create and copy the file to another name and display the content.
        static void Bai7()
        {
            string source = "test.txt";
            string destination = "copy.txt";

            File.WriteAllText(source, "Noi dung file goc");

            File.Copy(source, destination, true);

            Console.WriteLine(File.ReadAllText(destination));
        }

        // Bai 8: create a file and move it into the same directory with another name.
        static void Bai8()
        {
            string oldPath = "test.txt";
            string newPath = "newtest.txt";

            File.WriteAllText(oldPath, "Noi dung file");

            if (File.Exists(newPath))
                File.Delete(newPath);

            File.Move(oldPath, newPath);

            Console.WriteLine("Da doi ten file");
        }

        // Bai 9: read the first line of a file.
        static void Bai9()
        {
            string path = "test.txt";

            File.WriteAllLines(path,
                new string[] { "Dong 1", "Dong 2", "Dong 3" });

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadLine());
            }
        }

        // Bai 10: to create and read the last line of a file.
        static void Bai10()
        {
            string path = "test.txt";

            File.WriteAllLines(path,
                new string[] { "Dong 1", "Dong 2", "Dong 3" });

            string[] lines = File.ReadAllLines(path);

            if (lines.Length > 0)
                Console.WriteLine(lines[lines.Length - 1]);
            else
                Console.WriteLine("File rong");
        }

        // Bai 11: create and read the last n lines of a file.
        static void Bai11()
        {
            string path = "test.txt";

            File.WriteAllLines(path,
                new string[]
                {
            "Dong 1", "Dong 2", "Dong 3",
            "Dong 4", "Dong 5"
                });

            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            string[] lines = File.ReadAllLines(path);

            int start = lines.Length - n;

            if (start < 0)
                start = 0;

            for (int i = start; i < lines.Length; i++)
                Console.WriteLine(lines[i]);
        }

        // Bai 12: to read a specific line from a file.
        static void Bai12()
        {
            string path = "test.txt";

            File.WriteAllLines(path,
                new string[] { "Dong 1", "Dong 2", "Dong 3" });

            Console.Write("Nhap dong can doc: ");
            int n = int.Parse(Console.ReadLine());

            string[] lines = File.ReadAllLines(path);

            if (n >= 1 && n <= lines.Length)
                Console.WriteLine(lines[n - 1]);
            else
                Console.WriteLine("So dong khong hop le");
        }

        // Bai 13: to count the number of lines in a file
        static void Bai13()
        {
            string path = "test.txt";

            File.WriteAllLines(path,
                new string[] { "Dong 1", "Dong 2", "Dong 3" });

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("So dong: " + lines.Length);
        }

        // Bai 14: To print the structure of specific folder (include files)
        static void Bai14()
        {
            Console.Write("Nhap duong dan thu muc: ");
            string path = Console.ReadLine();

            if (Directory.Exists(path))
                InThuMuc(path, 0);
            else
                Console.WriteLine("Thu muc khong ton tai");
        }

        static void InThuMuc(string path, int cap)
        {
            string ten = new DirectoryInfo(path).Name;
            Console.WriteLine($"{new string(' ', cap * 4)}[D] {ten}");

            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine($"{new string(' ', (cap + 1)*4)}[F] {Path.GetFileName(file)}");
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                InThuMuc(dir, cap + 1);
            }
        }

        // Bai 15: Read a text file, then calculate the statistics of the appearance of characters and numbers.
        static void Bai15()
        {
            string path = "test.txt";

            Console.Write("Nhap noi dung file: ");
            string noiDung = Console.ReadLine();

            File.WriteAllText(path, noiDung);

            string[] lines = File.ReadAllLines(path);

            int soDong = lines.Length;
            int soCot = 0;

            for (int i = 0; i < soDong; i++)
            {
                if (lines[i].Length > soCot)
                    soCot = lines[i].Length;
            }

            char[,] a = new char[soDong, soCot];

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                    a[i, j] = lines[i][j];
            }

            int[] dem = new int[65536]; // Mang dem ky tu, kich thuoc 2 mũ 16 = 65536 de bao dam luu duoc tat ca cac ky tu

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    char c = a[i, j];
                    dem[c]++;
                }
            }

            Console.WriteLine("Thong ke ky tu:");

            for (int c = 0; c < dem.Length; c++)
            {
                if (dem[c] > 0)
                {
                    if (char.IsLetter((char)c))
                        Console.WriteLine($"Chu cai '{(char)c}': {dem[c]} lan");
                    else if (char.IsDigit((char)c))
                        Console.WriteLine($"Chu so '{(char)c}': {dem[c]} lan");
                    else
                        Console.WriteLine($"Ky tu '{(char)c}': {dem[c]} lan");
                }
            }
        }

}
