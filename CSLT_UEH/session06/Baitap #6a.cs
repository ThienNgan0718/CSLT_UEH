using System;

class Baitap_6a
{
    // to calculate the average value of array elements.
    static double Average(int[] a)
    {
        int sum = 0;

        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return (double)sum / a.Length;
    }

    // 2.to test if an array contains a specific value.
    static bool Contains(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
                return true;
        }

        return false;
    }

    // 3. to find the index of an array element.
    static int FindIndex(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
                return i;
        }

        return -1;
    }

    // 4. to remove a specific element from an array.
    static int[] RemoveElement(int[] a, int x)
    {
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != x)
                count++;
        }

        int[] result = new int[count];
        int j = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != x)
            {
                result[j] = a[i];
                j++;
            }
        }

        return result;
    }

    // 5. to find the maximum and minimum value of an array.
    static void FindMaxMin(int[] a, out int max, out int min)
    {
        max = a[0];
        min = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];

            if (a[i] < min)
                min = a[i];
        }
    }

    // 6. to reverse an array of integer values.
    static void ReverseArray(int[] a)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left < right)
        {
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            left++;
            right--;
        }
    }

    // 7. to find duplicate values in an array of values.
    static void FindDuplicates(int[] a)
    {
        Console.WriteLine("Cac gia tri trung:");

        for (int i = 0; i < a.Length; i++)
        {
            bool appearedBefore = false;

            // Kiểm tra a[i] đã xuất hiện trước đó chưa
            for (int j = 0; j < i; j++)
            {
                if (a[i] == a[j])
                {
                    appearedBefore = true;
                    break;
                }
            }

            if (appearedBefore)
                continue;

            // Kiểm tra có xuất hiện lần nữa không
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    Console.Write(a[i] + " ");
                    break;
                }
            }
        }

        Console.WriteLine();
    }

    // 8. to remove duplicate elements from an array.
    static int[] RemoveDuplicates(int[] a)
    {
        int[] temp = new int[a.Length];
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool exists = false;

            for (int j = 0; j < count; j++)
            {
                if (temp[j] == a[i])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                temp[count] = a[i];
                count++;
            }
        }

        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = temp[i];
        }

        return result;
    }

    static void PrintArray(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Main()
    {
        Random random = new Random();

        int[] a = new int[10];

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 11);
        }

        Console.WriteLine("Mang ban dau:");
        PrintArray(a);

        Console.WriteLine("Trung binh = " + Average(a));

        int x = 5;

        Console.WriteLine("Co chua " + x + ": " + Contains(a, x));
        Console.WriteLine("Index cua " + x + ": " + FindIndex(a, x));

        Console.WriteLine("Max va Min:");
        FindMaxMin(a, out int max, out int min);
        Console.WriteLine("Max = " + max);
        Console.WriteLine("Min = " + min);

        FindDuplicates(a);

        int[] noDuplicates = RemoveDuplicates(a);
        Console.WriteLine("Sau khi xoa trung:");
        PrintArray(noDuplicates);

        ReverseArray(a);
        Console.WriteLine("Sau khi dao nguoc:");
        PrintArray(a);
    }
}