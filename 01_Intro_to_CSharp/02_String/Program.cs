using System.Text;

namespace _02_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Task 1

            string str1 = "My str 1";
            string str2 = "appended str "; 

            str1= str1.Insert(3,str2);
            Console.WriteLine(str1);

            //task 2


            //bool IsPalindrom(string value)
            //{

            //    for(int i = 0; i < value.Length/2; i++)
            //    {
            //        if (value[i] != value[value.Length - i -1]) return false;
            //    }
            //    return true ;
            //}
            //Console.WriteLine(IsPalindrom("OKOKO"));

            //task 3
            //int countUp = 0, countDown = 0;
            //str2 = "Дано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.";
            //string[] strArr = str2.Split(new char[] { ',',' ','.' },StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    str2[i].
            //}
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    for(int j =0;j< strArr.Length; j++)
            //    {
            //        if (strArr[i] == 
            //    }
            //}


            //task 4
            //Дано масив слів.Замінити останні три символи слів, що мають обрану довжину, на символ "$".

            //str2 = "Дано масив слів. Замінити останні три символи слів, що мають обрану довжину, на символ \\\"$\\\".";
            //string[] strArr = str2.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    if(strArr[i].Length == 5) {
            //        strArr[i] = strArr[i].Substring(0,strArr[i].Length-3) + "$";
            //    }
            //}
            //for(int i = 0; i < strArr.Length; i++)
            //{
            //    Console.WriteLine(strArr[i]);
            //}

            //task 5
            //str2 = "Знайти слово, що стоїть в тексті під певним номером, і вивести його першу букву.";
            //strArr = str2.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //int request = 2;
            //for(int i = 0; i< strArr.Length; i++)
            //{
            //    if(i == request)
            //    { 
            //        Console.WriteLine(strArr[i][..1]);
            //    }
            //}
            //task 6
            str2 = "Дано рядок слів, розділених пробілами.  Між словами    може бути    кілька пробілів, на початку і вкінці рядка також можуть бути пробіли. Ви повинні змінити рядок так, щоб на початку і вкінці пробілів не було, а слова були розділені поодиноким символом \"*\" (зірочка).";
            string[] strArr = str2.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            




            str2 = string.Join('*', strArr);
            Console.WriteLine(str2);
            // task 7
            StringBuilder builder = new StringBuilder();

            string str="";
            do
            {
                str = Console.ReadLine();
                builder.Append(str + ", ");
            }
            while (str[str.Length-1] != '.');
            Console.WriteLine(builder);
            



        }



    }
}