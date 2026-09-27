using System;

class Baitap_6b
{
    static void BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }

    static bool LinearSearch(string sentence, string word)
    {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Equals(word, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    public static void Main()
    {
        int[] a = new int[10];

        Console.WriteLine("Nhap 10 so nguyen:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nMang ban dau:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        BubbleSort(a);

        Console.WriteLine("\n\nMang sau khi sap xep:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }


        Console.WriteLine("\n\n Nhap mot cau:");
        string sentence = Console.ReadLine();

        Console.Write("Nhap tu can tim: ");
        string word = Console.ReadLine();

        if (LinearSearch(sentence, word))
            Console.WriteLine("Tim thay tu trong cau.");
        else
            Console.WriteLine("Khong tim thay tu trong cau.");
    }
}