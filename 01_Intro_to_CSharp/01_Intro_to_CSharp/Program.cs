using System.Net.NetworkInformation;
using System;

namespace _01_Intro_to_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            //string str;
            //Console.WriteLine("Enter num 1:");
            //str = Console.ReadLine();
            //int a = int.Parse(str);
            //Console.WriteLine("Enter num 2:");
            //str = Console.ReadLine();
            //int b = int.Parse(str);
            //Console.WriteLine("Enter num 3:");
            //str = Console.ReadLine();
            //int c = int.Parse(str);
            //Console.WriteLine("Enter num 4:");
            //str = Console.ReadLine();
            //int d = int.Parse(str);
            //Console.WriteLine("Enter num 5:");
            //str = Console.ReadLine();
            ////task 2
            //int e = int.Parse(str);
            //int sum = a + b + c + d + e;
            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"Multiply = {a * b * c * d * e}");
            //if (a < b && a < c && a < d && a < e) { Console.WriteLine($"{a} min value"); }
            //if (b < a && b < c && b < d && b < e) { Console.WriteLine($"{b} min value"); }
            //if (c < b && c < a && c < d && c < e) { Console.WriteLine($"{c} min value"); }
            //if (e < b && e < c && e < d && e < a) { Console.WriteLine($"{d} min value"); }
            //if (d < b && d < c && d < a && d < e) { Console.WriteLine($"{e} min value"); }

            ////task 3
            //int num;

            //static int ReverseNumber(int num)
            //{
            //    int reversedNum = 0;
            //    while (num > 0)
            //    {
            //        int remainder = num % 10;
            //        reversedNum = (reversedNum * 10) + remainder;
            //        num = num / 10;
            //    }
            //    return reversedNum;
            //}

            //Console.WriteLine();
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Num before: {num} \nNum After: {ReverseNumber(num)}");

            //task 4

            //int eRange;
            //bool exit = false;

            //Console.WriteLine("Enter End range: ");
            //eRange = int.Parse(Console.ReadLine());

            //int sum, num2 = 1;
            //int num1= 0;
            //Console.Write($"{num1} {num2} ");
            //while (!exit)
            //{
            //    sum = num1 + num2;
            //    if (sum <= eRange)
            //    {
            //        Console.Write($"{sum} ");
            //        num1 = num2;
            //        num2 = sum;
            //    }
            //    else exit = true;
            //}
            //task 5

            //int a = 1;
            //int b = 5;

            //for (int i = a; i <= b; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write($"{i}");
            //    }
            //    Console.WriteLine();

            //}

            //task 6
            Console.WriteLine("Enter length of line:");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Symbol to fill line:");
            char ch = char.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter 1 to draw gorizontal line, or 2 to draw vertical:");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1) for (int i = 0; i < len; i++) Console.Write(ch);

            else if (choice == 2) for (int i = 0; i < len; i++) Console.Write(ch);
            else Console.WriteLine("Wrong Choice!");








        }
    }
}