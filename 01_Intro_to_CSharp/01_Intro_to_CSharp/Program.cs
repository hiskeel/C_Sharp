using System.Net.NetworkInformation;
using System;

namespace _01_Intro_to_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            string str;
            Console.WriteLine("Enter num 1:");
            str = Console.ReadLine();
            int a = int.Parse(str);
            Console.WriteLine("Enter num 2:");
            str = Console.ReadLine();
            int b = int.Parse(str);
            Console.WriteLine("Enter num 3:");
            str = Console.ReadLine();
            int c = int.Parse(str);
            Console.WriteLine("Enter num 4:");
            str = Console.ReadLine();
            int d = int.Parse(str);
            Console.WriteLine("Enter num 5:");
            str = Console.ReadLine();
            //task 2
            int e = int.Parse(str);
            int sum = a + b + c + d + e;
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"Multiply = {a * b * c * d * e}");
            if (a < b && a < c && a < d && a < e) { Console.WriteLine($"{a} min value"); }
            if (b < a && b < c && b < d && b < e) { Console.WriteLine($"{b} min value"); }
            if (c < b && c < a && c < d && c < e) { Console.WriteLine($"{c} min value"); }
            if (e < b && e < c && e < d && e < a) { Console.WriteLine($"{d} min value"); }
            if (d < b && d < c && d < a && d < e) { Console.WriteLine($"{e} min value"); }

            //task 3
            int num;

            static int ReverseNumber(int num)
            {
                int reversedNum = 0;
                while (num > 0)
                {
                    int remainder = num % 10;
                    reversedNum = (reversedNum * 10) + remainder;
                    num = num / 10;
                }
                return reversedNum;
            }

            Console.WriteLine();
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Num before: {num} \nNum After: {ReverseNumber(num)}");

            //task 4


           
            








        }
    }
}