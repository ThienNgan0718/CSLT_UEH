using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n---- MENU ----");
            Console.WriteLine("1. session 1");
            Console.WriteLine("2. session 2");
            Console.WriteLine("3. session 3");
            Console.WriteLine("4. session 4");
            Console.WriteLine("5. session 5");
            Console.WriteLine("0. Thoat");

            Console.Write("Chon bai: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BT_01.Run();
                    break;

                case 2:
                    Baitap_1.Run();
                    break; 

                case 3:
                    Baitap_2.Run();
                    break;

                case 4:
                    Baitap_3.Run();
                    break;

                case 5:
                    Baitap_5.Run();
                    break;

                case 0:
                    Console.WriteLine("Thoat!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

        } while (choice != 0);
    }
}