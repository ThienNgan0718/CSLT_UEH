using System;

class Program
{
    static int[,] CreateMatrix(int n, int m)
    {
        Random random = new Random();

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }

        return matrix;
    }


    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }


    static void PrintRow(int[,] matrix, int i)
    {
        int m = matrix.GetLength(1);

        Console.Write("Dong " + i + ": ");

        for (int j = 0; j < m; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }

        Console.WriteLine();
    }


    static void PrintColumn(int[,] matrix, int i)
    {
        int n = matrix.GetLength(0);

        Console.Write("Cot " + i + ": ");

        for (int j = 0; j < n; j++)
        {
            Console.Write(matrix[j, i] + " ");
        }

        Console.WriteLine();
    }


    static int FindMax(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int max = matrix[0, 0];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > max)
                    max = matrix[i, j];
            }
        }

        return max;
    }


    static int FindMinRow(int[,] matrix, int i)
    {
        int m = matrix.GetLength(1);

        int min = matrix[i, 0];

        for (int j = 1; j < m; j++)
        {
            if (matrix[i, j] < min)
                min = matrix[i, j];
        }

        return min;
    }


    static int FindMinColumn(int[,] matrix, int i)
    {
        int n = matrix.GetLength(0);

        int min = matrix[0, i];

        for (int j = 1; j < n; j++)
        {
            if (matrix[j, i] < min)
                min = matrix[j, i];
        }

        return min;
    }


    static int[,] Transpose(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        int[,] result = new int[m, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }


    static void PrintMainDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.Write("Duong cheo chinh: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, i] + " ");
        }

        Console.WriteLine();
    }


    static void PrintSecondaryDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        Console.Write("Duong cheo phu: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, n - 1 - i] + " ");
        }

        Console.WriteLine();
    }


    static void Main()
    {
        Console.Write("Nhap so dong N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot M: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = CreateMatrix(n, m);

        Console.WriteLine("\nMa tran:");
        PrintMatrix(matrix);


        Console.Write("\nNhap i de in dong: ");
        int i = int.Parse(Console.ReadLine());

        if (i >= 0 && i < n)
        {
            PrintRow(matrix, i);
            Console.WriteLine("Min dong " + i + " = " +
                              FindMinRow(matrix, i));
        }
        else
        {
            Console.WriteLine("Chi so dong khong hop le.");
        }

        Console.Write("\nNhap i de in cot: ");
        i = int.Parse(Console.ReadLine());

        if (i >= 0 && i < m)
        {
            PrintColumn(matrix, i);
            Console.WriteLine("Min cot " + i + " = " +
                              FindMinColumn(matrix, i));
        }
        else
        {
            Console.WriteLine("Chi so cot khong hop le.");
        }
         
        Console.WriteLine("\nMax cua ma tran = " + FindMax(matrix));

        int[,] transpose = Transpose(matrix);

        Console.WriteLine("\nMa tran chuyen vi:");
        PrintMatrix(transpose);


        if (n == m)
        {
            Console.WriteLine();
            PrintMainDiagonal(matrix);
            PrintSecondaryDiagonal(matrix);
        }
        else
        {
            Console.WriteLine(
                "\nMa tran khong vuong nen khong in duoc duong cheo.");
        }
    }
}