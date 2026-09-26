using System;
    class Baitap_1
    {
        public static void Main()
        {
            //1.to Add / Sum Two Numbers.
            int a = 6, b = 7;
            int sum = a + b;
            Console.WriteLine($"Sum {a} + {b} = {sum}");

            //2.to Swap Values of Two Variables.
            Console.WriteLine($"Before swapping: a= {a}, b= {b}");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swapping: a= {a}, b= {b}");

            //3.to Multiply two Floating Point Numbers
            float a2 = 1.5f;
            float b2 = 7.5f;
            float product = a2 * b2;
            Console.WriteLine($"Product {a2} * {b2} = {product}");

            //4.to convert feet to meter
            float feet = 10f;
            float meters = feet * 0.3048f;
            Console.WriteLine($"{feet} feet = {meters} meters");

            //5.to convert Celsius to Fahrenheit and vice versa
            float cels = 25f;
            float fah = (cels * 9 / 5) + 32;
            Console.WriteLine($"{cels}°C = {fah}°F");

            float fah2 = 77f;
            float cels2 = (fah2 - 32) * 5 / 9;
            Console.WriteLine($"{fah2}°F = {cels2}°C");

            //6.to find the Size of data types
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");

            //7.to Print ASCII Value(tip: read character, print number of this char)
            Console.Write("Enter a character: ");
            int c = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII Code of {(char)c} is {c}");

            //8.to Calculate Area of Circle
            Console.Write("Enter radius of circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"Area of circle with radius {r} is {area}");

            //9.to Calculate Area of Square
            Console.Write("Enter side length of square: ");
            double s = Convert.ToDouble(Console.ReadLine());
            double areaSquare = s * s;
            Console.WriteLine($"Area of square with side {s} is {areaSquare}");

            //10.to convert days to years, weeks and days
            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{days} days = {years} years, {weeks} weeks, {remainingDays} days");
        }

}